using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAY_LatLongUTMToFrom_Converter
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            RichTxtAbout.SelectionColor = Color.ForestGreen;
            RichTxtAbout.SelectedText += "Software Info";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectionColor = Color.Black;
            RichTxtAbout.SelectedText += "Name: CSAY_LATLONG_UTM_TOFROM_CONVERTER";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectionColor = Color.Black;
            RichTxtAbout.SelectedText += "License: GNU GENERAL PUBLIC LICENSE V3.0";
            RichTxtAbout.SelectedText += Environment.NewLine;

            //RichTxtAbout.SelectionColor = Color.Black;
            RichTxtAbout.SelectedText += "Features:";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "\ta. Converts latitude, longitude to Easting, Northing";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "\tb. Converts Easting, Northing to latitude, longitude";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "\tc. Exports latitude, longitude to Kml";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "\td. Exports converted table to excel";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "\te. Allows user to choose their datum/ellipsoid";
            RichTxtAbout.SelectedText += Environment.NewLine;

            //RichTxtAbout.SelectionColor = Color.Black;
            RichTxtAbout.SelectedText += "This is continuation of software at https://github.com/ajayyadavay/LatLongToXYConverter";
            RichTxtAbout.SelectedText += Environment.NewLine;

            //RichTxtAbout.SelectionColor = Color.Black;
            RichTxtAbout.SelectedText += "Created by: Ajay Yadav";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "Version: 2023.1";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "email: ajayyadavay02@gmail.com";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "github: https://github.com/ajayyadavay";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "Video tutorial: https://www.youtube.com/justlearncivil";
            RichTxtAbout.SelectedText += Environment.NewLine;

            /*RichTxtAbout.SelectedText += "Thank you for using this software. Any recommendation to further improve it will be highly appreciated.";
            RichTxtAbout.SelectedText += Environment.NewLine;*/


            RichTxtAbout.SelectedText += Environment.NewLine;
            RichTxtAbout.SelectionColor = Color.Blue;
            RichTxtAbout.SelectedText += "Instruction To Users";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectionColor = Color.Black;
            RichTxtAbout.SelectedText += "1. Choose \"*.proj or *.txt\" file and click in \"File>load ellipsoid parameter\" menu";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "2. File>Import txt or you can drag and drop the text file over the grey area of the table";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "3. File>Calculate LatLongToEastNorth";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "4. Export>LatLong to Kml";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "5. Export>Table to Excel";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += Environment.NewLine;
            RichTxtAbout.SelectionColor = Color.Red;
            RichTxtAbout.SelectedText += "Setting menu";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectionColor = Color.Black;
            RichTxtAbout.SelectedText += "1. Mode: Choose LatLong to EastNorth or EastNorth to LatLong";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "2. Choose Input Zone or CM: If the *.proj or *.txt file contains Zone then choose Zone otherwise CM";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "3. Choose Import or Generate Row: You can input data by importing files or generating rows and entering/pasting your data";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += Environment.NewLine;
            RichTxtAbout.SelectionColor = Color.Magenta;
            RichTxtAbout.SelectedText += "Zone to Central Meridian and vice-versa conversion formula";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectionColor = Color.Black;
            RichTxtAbout.SelectedText += "1. Zone = (CM + 180 + 3) / 6";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "2. CM = Zone * 6 - 180 - 3";
            RichTxtAbout.SelectedText += Environment.NewLine;

            RichTxtAbout.SelectedText += "Note: There are 60 Zones in UTM, each with 6-degree longitude width";
            RichTxtAbout.SelectedText += Environment.NewLine;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
