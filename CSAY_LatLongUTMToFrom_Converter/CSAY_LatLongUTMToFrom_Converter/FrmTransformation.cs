﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CSAY_LatLongUTMToFrom_Converter
{
    public partial class FrmTransformation : Form
    {
        public FrmTransformation()
        {
            InitializeComponent();
        }

        private void ComboBoxDatumFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtDatumFile.Text = ComboBoxDatumFile.Text;
        }

        private void FrmTransformation_Load(object sender, EventArgs e)
        {
            string dir = Environment.CurrentDirectory + "\\DatumTransformation";
            string[] files = Directory.GetFiles(dir, "*.txt", SearchOption.AllDirectories);//Directory.GetFiles(dir);
            foreach (string filePath in files) ComboBoxDatumFile.Items.Add(Path.GetFileName(filePath));

        }

        private void loadDatumTransformationParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Loading RWY COORD of airport code specified in Default
                string[] ReadingText = new string[100];
                string RWYCoordFilenName;
                string line1;
                line1 = "";
                string dir = Environment.CurrentDirectory + "\\DatumTransformation\\";
                RWYCoordFilenName = dir + TxtDatumFile.Text;
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(RWYCoordFilenName);
                //Read the first line of text
                line1 = sr.ReadLine();
                ReadingText[0] = line1;
                //Continue to read until you reach end of file
                int j = 1;
                while (line1 != null)
                {
                    //Read the next line
                    line1 = sr.ReadLine();
                    ReadingText[j] = line1;
                    j++;
                }
                //close the file
                sr.Close();

                //load data to datagridview by splitting by tab character
                string[] splittedtext;

                dataGridView1.Rows.Clear();

                int row = 0;
                for(int i =1; i<15; i++)
                {
                    splittedtext = ReadingText[i].Split('\t');
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Cells[0].Value = splittedtext[0];
                    dataGridView1.Rows[row].Cells[1].Value = splittedtext[1];
                    row++;
                }

                

                groupBox1.Text = "From Ellipsoid: " + dataGridView1.Rows[0].Cells[1].Value + " To: " + dataGridView1.Rows[11].Cells[1].Value;
            }
            catch
            {

            }
        }

        private void geodeticTo3DCartesianForDatum1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int no_of_data = dataGridView2.RowCount - 1;
                double[] XYZ = new double[3];
                double lat1, long1, h1, a1, one_by_f1;
                a1 = Convert.ToDouble(dataGridView1.Rows[1].Cells[1].Value);
                one_by_f1 = Convert.ToDouble(dataGridView1.Rows[2].Cells[1].Value);

                //MessageBox.Show("a1 = " + a1.ToString() + "\n1/f1 = " + one_by_f1.ToString());

                //double[] data = new double[3];
                for (int i = 0; i < no_of_data; i++)
                {
                    lat1 = Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value);
                    long1 = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value);
                    h1 = Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);

                    XYZ = GeodeticTo3DCartesian(lat1, long1, h1, a1, one_by_f1);
                    //data = Convert_UTM_To_Latitude_Longitude(latEast, LongNorth, a, one_by_f, K0, M0, False_Easting_X, lambda0_DD);
                    dataGridView2.Rows[i].Cells[4].Value = XYZ[0];
                    dataGridView2.Rows[i].Cells[5].Value = XYZ[1];
                    dataGridView2.Rows[i].Cells[6].Value = XYZ[2];

                }

            }
            catch
            {

            }        
        }
        private double[] GeodeticTo3DCartesian(double Lat1, double Long1, double Eh1, double a1, double one_by_f1)
        {
            double nu, h, phi, lambda, e2, f;
            double[] CartesianCOORD = new double[3];
            phi = Lat1 * Math.PI / 180.0; //converting decimal degree to radian
            lambda = Long1 * Math.PI / 180.0;
            h = Eh1;

            f = 1 / one_by_f1;
            e2 = f * (2 - f);
            nu = a1 / Math.Sqrt(1 - e2 * Math.Sin(phi) * Math.Sin(phi));

            //MessageBox.Show("f = " + f.ToString() + "\ne2 = " + e2.ToString() + "\nnu = " + nu.ToString());

            CartesianCOORD[0] = (nu + h) * Math.Cos(phi) * Math.Cos(lambda); //X
            CartesianCOORD[1] = (nu + h) * Math.Cos(phi) * Math.Sin(lambda); //Y
            CartesianCOORD[2] = (nu * (1 - e2) + h) * Math.Sin(phi); //Z

            return CartesianCOORD;
        }

        private double[] DatumTransformation_Using_7Parameter(double[] XYZ1, double[] SevenParameter)
        {
            double[] XYZ2 = new double[3];
            double rx, ry, rz, s;
             
            rx = SevenParameter[3] / 3600.0 * Math.PI / 180.0;
            ry = SevenParameter[4] / 3600.0 * Math.PI / 180.0;
            rz = SevenParameter[5] / 3600.0 * Math.PI / 180.0;
            s = SevenParameter[6] / 1000000.0;

            //MessageBox.Show("rx = " + rx.ToString() + "\nry = " + ry.ToString() + "\nrz = " + rz.ToString());
            //MessageBox.Show("s = " + s.ToString());

            XYZ2[0] = SevenParameter[0] + (1 + s) * (XYZ1[0] + rz * XYZ1[1] - ry * XYZ1[2]);
            XYZ2[1] = SevenParameter[1] + (1 + s) * (-rz * XYZ1[0] + XYZ1[1] + rx * XYZ1[2]);
            XYZ2[2] = SevenParameter[2] + (1 + s) * (ry * XYZ1[0] - rx * XYZ1[1] + XYZ1[2]);

            return XYZ2;
        }

        private double[] Cartesian3DToGedetic(double[] XYZ, double a2, double one_by_f2)
        {
            double lambda, phi1, h, phi0, e2, f,p, error, nu, diff;

            double[] LLH = new double[3];

            error = Math.Pow(10, -15);
            f = 1 / one_by_f2;
            e2 = f * (2 - f);
            p = Math.Sqrt(XYZ[0] * XYZ[0] + XYZ[1] * XYZ[1]);
            //MessageBox.Show("p = " + p.ToString());

            lambda = Math.Atan(XYZ[1] / XYZ[0]);//radian

            phi0 = Math.Atan(XYZ[2] / (p * (1 - e2)));
            nu = a2 / Math.Sqrt(1 - e2 * Math.Sin(phi0) * Math.Sin(phi0));
            phi1 =Math.Atan((XYZ[2] + nu * e2 * Math.Sin(phi0)) / p);
            diff = Math.Abs(phi0 - phi1);

            while (diff > error) 
            {
                //phi0 = XYZ[2] / (p * (1 - e2));
                phi0 = phi1;
                nu = a2 / Math.Sqrt(1 - e2 * Math.Sin(phi0) * Math.Sin(phi0));
                phi1 = Math.Atan((XYZ[2] + nu * e2 * Math.Sin(phi0)) / p);
                diff = Math.Abs(phi0 - phi1);
                //MessageBox.Show("diff = " + diff.ToString());
            }
            //MessageBox.Show("phi1 = " + phi1.ToString() + "\nphi0 = " + phi0.ToString());
            

            nu = a2 / Math.Sqrt(1 - e2 * Math.Sin(phi1) * Math.Sin(phi1));
            //MessageBox.Show("nu = " + nu.ToString());

            h = p / Math.Cos(phi1) - nu;
            //MessageBox.Show("h = " + h.ToString());

            LLH[0] = phi1 * 180.0 / Math.PI; //latitude in decimal degree

           // MessageBox.Show("lat1 = " + LLH[0].ToString());

            LLH[1] = lambda * 180.0 / Math.PI; //longitude in decimal degree
            LLH[2] = h; // ellipsoidal height in meter



            return LLH;
        }

        public void Generaterows()
        {
            int n;
            try
            {
                n = Convert.ToInt32(TxtRowsNo.Text);
                dataGridView2.Rows.Clear();

                for (int i = 0; i < n; i++)
                {
                    i = dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch
            {

            }


        }
        private void TxtRowsNo_TextChanged(object sender, EventArgs e)
        {
            Generaterows();
        }

        private void importModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importModeToolStripMenuItem.Checked = true;
            generateRowsModeToolStripMenuItem.Checked = false;

            TxtRowsNo.Enabled = false;
            importLLHtxtToolStripMenuItem.Enabled = true;

            lblImportGenerate.Text = "Choose {Import or Generate Row}: Import";
        }

        private void generateRowsModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importModeToolStripMenuItem.Checked = false;
            generateRowsModeToolStripMenuItem.Checked = true;

            TxtRowsNo.Enabled = true;
            importLLHtxtToolStripMenuItem.Enabled = false;

            lblImportGenerate.Text = "Choose {Import or Generate Row}: Generate Row";
        }

        private void dCartesianTransformationUsing7ParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int no_of_data = dataGridView2.RowCount - 1;
                double[] XYZ1 = new double[3];
                double[] XYZ2 = new double[3];
                double[] SvnPara = new double[7];

                int r = 0;
                for(int i = 4; i<=10; i++)
                {
                    SvnPara[r] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    r++;
                }
                //MessageBox.Show("Para1th = " + SvnPara[0].ToString() + "Para7th = " + SvnPara[6].ToString());

                //double[] data = new double[3];
                for (int i = 0; i < no_of_data; i++)
                {
                    XYZ1[0] = Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value);
                    XYZ1[1] = Convert.ToDouble(dataGridView2.Rows[i].Cells[5].Value);
                    XYZ1[2] = Convert.ToDouble(dataGridView2.Rows[i].Cells[6].Value);

                    XYZ2 = DatumTransformation_Using_7Parameter(XYZ1, SvnPara);

                    //data = Convert_UTM_To_Latitude_Longitude(latEast, LongNorth, a, one_by_f, K0, M0, False_Easting_X, lambda0_DD);
                    dataGridView2.Rows[i].Cells[7].Value = XYZ2[0];
                    dataGridView2.Rows[i].Cells[8].Value = XYZ2[1];
                    dataGridView2.Rows[i].Cells[9].Value = XYZ2[2];

                }

            }
            catch
            {

            }
        }

        private void dCartesianToGeodeticForDatum2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int no_of_data = dataGridView2.RowCount - 1;
                double[] XYZ2 = new double[3];
                double[] LLH = new double[3];
                double a2, one_by_f2;
                a2 = Convert.ToDouble(dataGridView1.Rows[12].Cells[1].Value);
                one_by_f2 = Convert.ToDouble(dataGridView1.Rows[13].Cells[1].Value);

                //MessageBox.Show("a2 = " + a2.ToString() + "\n1/f2 = " + one_by_f2.ToString());

                //double[] data = new double[3];
                for (int i = 0; i < no_of_data; i++)
                {
                    XYZ2[0] = Convert.ToDouble(dataGridView2.Rows[i].Cells[7].Value);
                    XYZ2[1] = Convert.ToDouble(dataGridView2.Rows[i].Cells[8].Value);
                    XYZ2[2] = Convert.ToDouble(dataGridView2.Rows[i].Cells[9].Value);

                    //MessageBox.Show("Y2 = " + XYZ2[1].ToString());

                    LLH = Cartesian3DToGedetic(XYZ2, a2, one_by_f2);
                    //data = Convert_UTM_To_Latitude_Longitude(latEast, LongNorth, a, one_by_f, K0, M0, False_Easting_X, lambda0_DD);
                    dataGridView2.Rows[i].Cells[10].Value = LLH[0];
                    dataGridView2.Rows[i].Cells[11].Value = LLH[1];
                    dataGridView2.Rows[i].Cells[12].Value = LLH[2];

                }

            }
            catch
            {

            }
        }

        private void autoProcessAllThreeStepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geodeticTo3DCartesianForDatum1ToolStripMenuItem_Click(sender, e);
            dCartesianTransformationUsing7ParameterToolStripMenuItem_Click(sender, e);
            dCartesianToGeodeticForDatum2ToolStripMenuItem_Click(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopySelectedtoClipboard();
        }

        private void CopySelectedtoClipboard()
        {
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView2.MultiSelect = true;
            //datagridview1.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedCells.Count < 1) return;

                string[] lines;

                int row = dataGridView2.SelectedCells[0].RowIndex;
                int col = dataGridView2.SelectedCells[0].ColumnIndex;

                //get copied values
                lines = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split('\t');

                    if (row >= dataGridView2.Rows.Count || dataGridView2.Rows[row].IsNewRow) continue;
                    //if (row >= dataGridView2.Rows.Count || dataGridView2.Rows[row].IsNewRow) dataGridView2.Rows.Add();
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (col + j >= dataGridView2.Columns.Count) continue;
                        dataGridView2.Rows[row].Cells[col + j].Value = values[j];
                    }

                    row++;
                }

            }
            catch
            {

            }
        }

        private void importLLHtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Text File(*.txt)|*.txt";//"Text File(*.txt)|*.txt|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
                LoadTxtToDatagridview(dataGridView2, path, 1, 4);
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
            //string filename = Environment.CurrentDirectory + "\\LATLONG.txt";
        }

        public void LoadTxtToDatagridview(DataGridView Dgv, string FileName, int TxtStartRow, int no_of_Col)
        {
            string[] ReadingText = new string[100];
            //string RWYCoordFilenName;
            int i;
            StreamReader sr;
            string line;


            line = "";
            //FileName = @".\InputFolder\" + TxtAirportCode.Text + "\\" + "Strip_RL.txt";
            //Pass the file path and file name to the StreamReader constructor
            sr = new StreamReader(FileName);
            //Read the first line of text
            line = sr.ReadLine();
            ReadingText[0] = line;
            //Continue to read until you reach end of file
            i = 1;
            while (line != null)
            {
                //Read the next line
                line = sr.ReadLine();
                ReadingText[i] = line;
                i++;
            }
            //close the file
            sr.Close();

            //load RL data of strip
            Dgv.Rows.Clear();
            int startrow = TxtStartRow;
            int sn = 1;
            for (int row = startrow; row < (i - startrow); row++)
            {
                Dgv.Rows.Add();
                //Dgv.Rows[row - startrow].Cells[0].Value = sn.ToString();
                sn++;
            }

            for (int row = startrow; row < (i - startrow); row++)
            {
                string[] splittedtext = ReadingText[row].Split('\t');
                for (int col = 0; col < no_of_Col; col++)
                {
                    Dgv.Rows[row - startrow].Cells[col].Value = splittedtext[col];
                }
            }

        }
        private void CopyAlltoClipboard()
        {
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView2.MultiSelect = true;
            dataGridView2.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CopyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = groupBox1.Text + "  " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");
                int r = 0;
                for(int i = 3; i<=16; i++)
                {
                    for(int j = 1; j<=2; j++)
                    {
                        ((Excel.Range)xlWorkSheet.Cells[i, j]).Value = dataGridView1.Rows[r].Cells[j - 1].Value;
                    }
                    r++;
                }
                
                //((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Projection system";
                //value of IMS in Cell[1,2]
                //((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = "UTM WGS 84";


                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 4];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reverseTransformationParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Swap(dataGridView1, 0, 1, 11, 1);//swap Datum Names
            Swap(dataGridView1, 1, 1, 12, 1);//swap Datum Names
            Swap(dataGridView1, 2, 1, 13, 1);//swap Datum Names

            for(int i =4; i<=10; i++)
            {
                double a = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                a = a * -1;
                dataGridView1.Rows[i].Cells[1].Value = a;
            }

            groupBox1.Text = "From Ellipsoid: " + dataGridView1.Rows[0].Cells[1].Value + " To: " + dataGridView1.Rows[11].Cells[1].Value;
        }

        private void Swap(DataGridView DGV, int rowNoA, int colNoA, int rowNoB, int colNoB)
        {
            string temp, a, b;
            a = DGV.Rows[rowNoA].Cells[colNoA].Value.ToString();
            b = DGV.Rows[rowNoB].Cells[colNoB].Value.ToString();

            temp = a;
            a = b;
            b = temp;

            DGV.Rows[rowNoA].Cells[colNoA].Value = a;
            DGV.Rows[rowNoB].Cells[colNoB].Value = b;
        }

        private void dataGridView2_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the Data format of the file(s) can be accepted
            // (we only accept file drops from Windows Explorer, etc.)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // modify the drag drop effects to Move
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // no need for any drag drop effect
                e.Effect = DragDropEffects.None;
            }
        }

        private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        {
            // still check if the associated data from the file(s) can be used for this purpose
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Fetch the file(s) names with full path here to be processed
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
                string path = fileList[0];

                // Your desired code goes here to process the file(s) being dropped

                try
                {
                    LoadTxtToDatagridview(dataGridView2, path, 1, 4);

                }

                catch
                {

                }
                //MessageBox.Show("IMPORT COMPLETE !");
            }
        }
    }
}
