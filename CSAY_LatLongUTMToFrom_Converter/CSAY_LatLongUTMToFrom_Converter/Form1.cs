using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using SharpKml.Dom;
using SharpKml.Base;
using SharpKml.Engine;

namespace CSAY_LatLongUTMToFrom_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void latLongToEastNorthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eastNorthToLatLongToolStripMenuItem.Checked = false;
            latLongToEastNorthToolStripMenuItem.Checked = true;

            convertToolStripMenuItem.Text = "Convert LatLong to EastNorth";

            LblMode.Text = "Mode: Convert From LatLong to EastNorth";

            dataGridView1.Columns[1].HeaderText = "LatitudeN";
            dataGridView1.Columns[2].HeaderText = "LongitudeE";
            dataGridView1.Columns[3].HeaderText = "EastingX";
            dataGridView1.Columns[4].HeaderText = "NorthingY";
        }

        private void eastNorthToLatLongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eastNorthToLatLongToolStripMenuItem.Checked = true;
            latLongToEastNorthToolStripMenuItem.Checked = false;

            convertToolStripMenuItem.Text = "Convert EastNorth to LatLong";

            LblMode.Text = "Mode: Convert From EastNorth to LatLong";

            dataGridView1.Columns[1].HeaderText = "EastingX";
            dataGridView1.Columns[2].HeaderText = "NorthingY";
            dataGridView1.Columns[3].HeaderText = "LatitudeN";
            dataGridView1.Columns[4].HeaderText = "LongitudeE";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dir = Environment.CurrentDirectory + "\\Ellipsoid";
            string[] files = Directory.GetFiles(dir, "*.proj", SearchOption.AllDirectories);//Directory.GetFiles(dir);
            foreach (string filePath in files) ComboBoxProjFile.Items.Add(Path.GetFileName(filePath));


            string[] files1 = Directory.GetFiles(dir, "*.txt", SearchOption.AllDirectories);//Directory.GetFiles(dir);
            foreach (string filePath in files1) ComboBoxProjFile.Items.Add(Path.GetFileName(filePath));
            //Path.GetFileName(filePath) or Path.GetFileNameWithoutExtension(filePath);
        }

        private void CopyAlltoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void CopySelectedtoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            //datagridview1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ComboBoxProjFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtProjFile.Text = ComboBoxProjFile.Text;
        }

        private void loadEllipsoidParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Loading RWY COORD of airport code specified in Default
                string[] ReadingText = new string[100];
                string RWYCoordFilenName;
                string line1;
                line1 = "";
                string dir = Environment.CurrentDirectory + "\\Ellipsoid\\";
                RWYCoordFilenName = dir + TxtProjFile.Text;
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

                if (zoneToolStripMenuItem.Checked == true)
                {
                    splittedtext = ReadingText[2].Split('\t');
                    TxtZone.Text = splittedtext[1];
                }
                else if (cMToolStripMenuItem.Checked == true)
                {
                    splittedtext = ReadingText[2].Split('\t');
                    TxtCM.Text = splittedtext[1];
                }

                splittedtext = ReadingText[3].Split('\t');
                TxtA.Text = splittedtext[1];

                splittedtext = ReadingText[4].Split('\t');
                TxtOneByF.Text = splittedtext[1];

                splittedtext = ReadingText[5].Split('\t');
                TxtK0.Text = splittedtext[1];

                splittedtext = ReadingText[6].Split('\t');
                TxtM0.Text = splittedtext[1];

                splittedtext = ReadingText[7].Split('\t');
                TxtPhi0DD.Text = splittedtext[1];

                splittedtext = ReadingText[8].Split('\t');
                TxtFalseEastingX.Text = splittedtext[1];

                string Ellip, proj;
                splittedtext = ReadingText[0].Split('\t');
                Ellip = splittedtext[1];

                splittedtext = ReadingText[1].Split('\t');
                proj = splittedtext[1];

                groupBox1.Text = "Ellipsoid: " + Ellip + " and Projection: " + proj;
            }
            catch
            {

            }
            
        }

        private void TxtZone_TextChanged(object sender, EventArgs e)
        {
            if(zoneToolStripMenuItem.Checked == true)
            {
                ConvertZoneToCM();
            }
        }

        private void ConvertZoneToCM()
        {
            double cm, zone;
            zone = Convert.ToInt32(TxtZone.Text);
            cm = zone * 6 - 180 - 3;
            TxtCM.Text = cm.ToString();
        }

        private void ConvertCMToZone()
        {
            double cm, zone;
            cm = Convert.ToInt32(TxtCM.Text);
            zone = (cm + 180 + 3) / 6;
            TxtZone.Text = zone.ToString();
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

        private void importtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Text File(*.txt)|*.txt";//"Text File(*.txt)|*.txt|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
                LoadTxtToDatagridview(dataGridView1, path, 1, 3);
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
            //string filename = Environment.CurrentDirectory + "\\LATLONG.txt";
        }

        private void zoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoneToolStripMenuItem.Checked = true;
            cMToolStripMenuItem.Checked = false;

            label8.ForeColor = Color.Red;
            TxtZone.ForeColor = Color.Red;

            label9.ForeColor = Color.Black;
            TxtCM.ForeColor = Color.Black;

            LblZoneCM.Text = "Chosen Input {Zone or CM}: Zone";
        }

        private void cMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoneToolStripMenuItem.Checked = false;
            cMToolStripMenuItem.Checked = true;

            label8.ForeColor = Color.Black;
            TxtZone.ForeColor = Color.Black;

            label9.ForeColor = Color.Red;
            TxtCM.ForeColor = Color.Red;

            LblZoneCM.Text = "Chosen Input {Zone or CM}: CM";
        }

        private void TxtCM_TextChanged(object sender, EventArgs e)
        {
            if(cMToolStripMenuItem.Checked == true)
            {
                ConvertCMToZone();
            }
        }

        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double latEast, LongNorth;
            double a, one_by_f, K0, M0, phi0_DD, lambda0_DD;
            double False_Easting_X;
            a = Convert.ToDouble(TxtA.Text);
            one_by_f = Convert.ToDouble(TxtOneByF.Text);
            K0 = Convert.ToDouble(TxtK0.Text);
            M0= Convert.ToDouble(TxtM0.Text);
            phi0_DD= Convert.ToDouble(TxtPhi0DD.Text);
            lambda0_DD = Convert.ToDouble(TxtCM.Text);
            False_Easting_X = Convert.ToDouble(TxtFalseEastingX.Text);

            int no_of_data = dataGridView1.RowCount - 1;
            double[] data = new double[2];
            for(int i = 0; i < no_of_data; i++)
            {
                latEast = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                LongNorth = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                if(latLongToEastNorthToolStripMenuItem.Checked == true)
                {
                    data = Convert_LatLong_To_UTM(latEast, LongNorth, a, one_by_f, K0, M0, phi0_DD, lambda0_DD);
                    dataGridView1.Rows[i].Cells[3].Value = data[0];
                    dataGridView1.Rows[i].Cells[4].Value = data[1];
                }
                if (eastNorthToLatLongToolStripMenuItem.Checked == true)
                {
                    data = Convert_UTM_To_Latitude_Longitude(latEast, LongNorth, a, one_by_f, K0, M0, False_Easting_X, lambda0_DD);
                    dataGridView1.Rows[i].Cells[3].Value = data[0];
                    dataGridView1.Rows[i].Cells[4].Value = data[1];
                }
            }
        }

        public double[] Convert_LatLong_To_UTM(double latitude_in_degree, double longitude_in_degree, double a, double one_by_f, double K0, double M0, double phi0_DD, double lambda0_DD)
        {
            //double a, one_by_f, lambda0_DD, phi0_DD, K0, M0, f;
            double f;
            double[] EastNorthXY = new double[2];
            //double Easting_X, Northing_Y, f; 
            //double e_2, e_prime_2, mu, e1, phi1, R1, T1, C1, x, N1, D, phi, lambda;

            //Parameter values for WGS and UTM84

            //Input parameters
            /*a = 6378137.0;
            one_by_f = 298.2572201;
            K0 = 0.9996;
            M0 = 0; //distance in meter of origin latitude from equator
            f = 1 / one_by_f;
            phi0_DD = 0;
            lambda0_DD = 84;
            //lambda0_DD = Convert.ToDouble(TxtCM.Text);*/
            f = 1 / one_by_f;
            var phi0 = phi0_DD * Math.PI / 180;
            var lambda0 = lambda0_DD * Math.PI / 180;

            double Phi_DD = latitude_in_degree; //latitude input in degree decimal
            var Phi = Phi_DD * Math.PI / 180;//lat in radian

            double Lambda_DD = longitude_in_degree; //longitude input in degree decimal
            var Lambda = Lambda_DD * Math.PI / 180; //long in radian

            var e2 = 2 * f - f * f;
            var e_prime2 = e2 / (1 - e2);
            var RM = a * (1 - e2) / Math.Pow((1 - e2 * Math.Pow(Math.Sin(Phi), 2)), 3 / 2);
            var RN = a / Math.Sqrt(1 - e2 * Math.Sin(Phi) * Math.Sin(Phi));
            var T = Math.Tan(Phi) * Math.Tan(Phi);
            var C = e_prime2 * Math.Cos(Phi) * Math.Cos(Phi);
            var A1 = (Lambda - lambda0) * Math.Cos(Phi);
            var M_term1 = (1 - e2 / 4 - 3 * e2 * e2 / 64 - 5 * e2 * e2 * e2 / 256) * Phi;
            var M_term2 = (3 * e2 / 8 + 3 * e2 * e2 / 32 + 45 * e2 * e2 * e2 / 1024) * Math.Sin(2 * Phi);
            var M_term3 = (15 * e2 * e2 / 256 + 45 * e2 * e2 * e2 / 1024) * Math.Sin(4 * Phi);
            var M_term4 = (35 * e2 * e2 * e2 / 3072) * Math.Sin(6 * Phi);
            var M = a * (M_term1 - M_term2 + M_term3 - M_term4);


            var X_term1 = (1 - T + C) * A1 * A1 * A1 / 6;
            var X_term2 = (5 - 18 * T + T * T + 72 * C - 58 * e_prime2) * Math.Pow(A1, 5) / 6;

            var Easting_X = K0 * RN * (A1 + X_term1 + X_term2) + 500000;             //x coordinate

            var Y_term1 = (5 - T + 9 * C + 4 * C * C) * Math.Pow(A1, 4) / 24;

            var Y_term2 = (61 - 58 * T + T * T + 600 * C - 330 * e_prime2) * Math.Pow(A1, 6) / 720;
            var Northing_Y = K0 * (M - M0 + RN * Math.Tan(Phi) * (A1 * A1 / 2 + Y_term1 + Y_term2)); // y coordinate

            EastNorthXY[0] = Easting_X;
            EastNorthXY[1] = Northing_Y;
            return EastNorthXY;
        }

        public double[] Convert_UTM_To_Latitude_Longitude(double Easting_X, double Northing_Y, double a, double one_by_f, double K0, double M0, double False_Easting_X, double lambda0)
        {
            //double a, one_by_f, lambda0, K0, M0, False_Easting_X;
            //double lambda0;
            double f;
            double M, e_2, e_prime_2, mu, e1, phi1, R1, T1, C1, x, N1, D, phi, lambda;
            double[] LatLong = new double[2];

            //Parameter values for WGS and UTM84
            /*False_Easting_X = 500000.0;
            //False_Northing_Y = 0;
            a = 6378137.0;
            one_by_f = 298.2572201;
            K0 = 0.9996;
            M0 = 0; //distance in meter of origin latitude from equator

            //Input
            lambda0 = 84.0; //central meridian for zone 44*/

            //Formula and equation for conversion from UTM to WGS
            f = 1 / one_by_f;
            M = M0 + Northing_Y / K0;
            e_2 = 2.0 * f - f * f;
            e_prime_2 = e_2 / (1.0 - e_2);
            mu = M / (a * (1.0 - e_2 / 4.0 - 3.0 * e_2 * e_2 / 64.0 - 5.0 * e_2 * e_2 * e_2 / 256.0));
            e1 = (1.0 - Math.Sqrt(1 - e_2)) / (1 + Math.Sqrt(1.0 - e_2));

            double phi1_term1 = (3.0 * e1 / 2.0 - 27.0 * e1 * e1 * e1 / 32) * Math.Sin(2 * mu);
            double phi1_term2 = (21.0 * e1 * e1 / 16.0 - 55.0 * e1 * e1 * e1 * e1 / 32.0) * Math.Sin(4 * mu);
            double phi1_term3 = (151.0 * e1 * e1 * e1 / 96.0) * Math.Sin(6 * mu);
            double phi1_term4 = (1097.0 * e1 * e1 * e1 * e1 / 512.0) * Math.Sin(8 * mu);

            phi1 = mu + phi1_term1 + phi1_term2 + phi1_term3 + phi1_term4;

            R1 = a * (1.0 - e_2) / Math.Pow((1.0 - e_2 * Math.Sin(phi1) * Math.Sin(phi1)), 3.0 / 2.0);
            T1 = Math.Tan(phi1) * Math.Tan(phi1);
            C1 = e_prime_2 * Math.Cos(phi1) * Math.Cos(phi1);
            x = Easting_X - False_Easting_X;
            N1 = a / (Math.Sqrt(1.0 - e_2 * Math.Sin(phi1) * Math.Sin(phi1)));
            D = x / (N1 * K0);
            double phi_t1 = D * D / 2.0 - (5.0 + 3.0 * T1 + 10.0 * C1 - 4.0 * C1 * C1 - 9.0 * e_prime_2) * D * D * D * D / 24.0;
            double phi_t2 = (61.0 + 90.0 * T1 + 298.0 * C1 + 45.0 * T1 * T1 - 252.0 * e_prime_2 - 3.0 * C1 * C1) * D * D * D * D * D * D / 720.0;

            phi = phi1 - (N1 * Math.Tan(phi1) / R1) * (phi_t1 + phi_t2); //latitude in radian

            double lambda_t1 = D - (1.0 + 2.0 * T1 + C1) * D * D * D / 6.0;
            double lambda_t2 = (5.0 - 2.0 * C1 + 28.0 * T1 - 3 * C1 * C1 + 8.0 * e_prime_2 + 24.0 * T1 * T1) * D * D * D * D * D / 120.0;
            lambda = lambda0 * Math.PI / 180.0 + (lambda_t1 + lambda_t2) / Math.Cos(phi1); //longitude in radian

            //Final_Latitude_DD = phi * 180.0 / Math.PI;
            //Final_Longitude_DD = lambda * 180.0 / Math.PI;
            LatLong[0] = phi * 180.0 / Math.PI;
            LatLong[1] = lambda * 180.0 / Math.PI;
            return LatLong;

            //MessageBox.Show("phi_t1 +t2 = " + (phi_t1+phi_t2)* ((N1 * Math.Tan(phi1) / R1)) + "\nphi1 = " + phi1);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CopySelectedtoClipboard();

            }
            catch
            {

            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count < 1) return;

                string[] lines;

                int row = dataGridView1.SelectedCells[0].RowIndex;
                int col = dataGridView1.SelectedCells[0].ColumnIndex;

                //get copied values
                lines = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split('\t');

                    if (row >= dataGridView1.Rows.Count || dataGridView1.Rows[row].IsNewRow) continue;
                    //if (row >= dataGridView1.Rows.Count || dataGridView1.Rows[row].IsNewRow) dataGridView1.Rows.Add();
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (col + j >= dataGridView1.Columns.Count) continue;
                        dataGridView1.Rows[row].Cells[col + j].Value = values[j];
                    }

                    row++;
                }

            }
            catch
            {

            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
            }
            catch
            {
            }
        }
        public void Generaterows()
        {
            int n;
            try
            {
               n = Convert.ToInt32(TxtRowsNo.Text);
               dataGridView1.Rows.Clear();

                for (int i = 0; i < n; i++)
                {
                    i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;

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
            importtxtToolStripMenuItem.Enabled = true;

            LblImportGenerate.Text = "Choose {Import or Generate Row}: Import";
        }

        private void generateRowsModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importModeToolStripMenuItem.Checked = false;
            generateRowsModeToolStripMenuItem.Checked = true;

            TxtRowsNo.Enabled = true;
            importtxtToolStripMenuItem.Enabled = false;

            LblImportGenerate.Text = "Choose {Import or Generate Row}: Generate Row";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout fabout = new FrmAbout();
            fabout.Show();
        }

        private void latLongToKMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double lat1, long1;


            string path = "";
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.Filter = "KML Files(*.kml)|*.kml";//"Text File(*.txt)|*.txt|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            savefiledialog1.FilterIndex = 1;

            if (savefiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = savefiledialog1.FileName;
                //LoadTxtToDatagridview(dataGridView1, path, 1, 3);
            }
            else if (savefiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;



            string MyFolder = path;

            var serializer = new Serializer();

            //Vertical i.e., perpendicular points
            var document_VP = new SharpKml.Dom.Document
            {
                Description = new SharpKml.Dom.Description
                {
                    Text = "Detail of points lat long"
                },
                Name = "PointsName"
            };

            // This will be used for the placemark-----------------
            int lstrow = dataGridView1.RowCount - 1;
            for (int i = 0; i < lstrow; i++)
            {
                if(latLongToEastNorthToolStripMenuItem.Checked == true)
                {
                    lat1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    long1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                }
                else
                {
                    lat1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    long1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }

                SharpKml.Dom.Point ptV = new SharpKml.Dom.Point();

                ptV.Coordinate = new SharpKml.Base.Vector(lat1, long1);
                SharpKml.Dom.Placemark placemark_VP = new SharpKml.Dom.Placemark();
                placemark_VP.Name = i.ToString() + "_" + dataGridView1.Rows[i].Cells[0].Value.ToString();
                placemark_VP.Geometry = ptV;
                document_VP.AddFeature(placemark_VP);

            }

            // This is the root element of the file--------------------------
            var kmlVP = new Kml
            {
                Feature = document_VP
            };
            //var serializer = new Serializer();
            //string kmlfilename = Environment.CurrentDirectory + "\\KML_Files" + "\\ThisKML.kml";
            string kmlfilenameVP = MyFolder;
            FileStream fileStreamVP = new FileStream(kmlfilenameVP, FileMode.OpenOrCreate);
            serializer.Serialize(kmlVP, fileStreamVP);

            MessageBox.Show("Points exported to KML");
        }

        private void tableToExcelToolStripMenuItem_Click(object sender, EventArgs e)
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


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "LatLong To XY in UTM WGS 84 " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                //((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Projection system";
                //value of IMS in Cell[1,2]
                //((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = "UTM WGS 84";


                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 1];
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

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
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

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
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
                    LoadTxtToDatagridview(dataGridView1, path, 1, 3);

                }

                catch
                {

                }
                //MessageBox.Show("IMPORT COMPLETE !");
            }
        }
    }
}
