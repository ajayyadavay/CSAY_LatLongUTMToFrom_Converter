namespace CSAY_LatLongUTMToFrom_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadEllipsoidParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.importtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latLongToKMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.tableToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latLongToEastNorthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eastNorthToLatLongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseZoneOrCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseImportOrGenerateRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRowsModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblImportGenerate = new System.Windows.Forms.Label();
            this.LblZoneCM = new System.Windows.Forms.Label();
            this.LblMode = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEastingX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNorthingY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRowsNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtZone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtProjFile = new System.Windows.Forms.TextBox();
            this.ComboBoxProjFile = new System.Windows.Forms.ComboBox();
            this.TxtFalseEastingX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPhi0DD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtM0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtK0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOneByF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datumTransformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadEllipsoidParameterToolStripMenuItem,
            this.toolStripMenuItem3,
            this.importtxtToolStripMenuItem,
            this.toolStripMenuItem5,
            this.convertToolStripMenuItem,
            this.toolStripMenuItem4,
            this.aboutToolStripMenuItem,
            this.datumTransformationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadEllipsoidParameterToolStripMenuItem
            // 
            this.loadEllipsoidParameterToolStripMenuItem.Name = "loadEllipsoidParameterToolStripMenuItem";
            this.loadEllipsoidParameterToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.loadEllipsoidParameterToolStripMenuItem.Text = "Load Ellipsoid Parameter";
            this.loadEllipsoidParameterToolStripMenuItem.Click += new System.EventHandler(this.loadEllipsoidParameterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(272, 6);
            // 
            // importtxtToolStripMenuItem
            // 
            this.importtxtToolStripMenuItem.Name = "importtxtToolStripMenuItem";
            this.importtxtToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.importtxtToolStripMenuItem.Text = "Import (*.txt)";
            this.importtxtToolStripMenuItem.Click += new System.EventHandler(this.importtxtToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(272, 6);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.convertToolStripMenuItem.Text = "Convert LatLong To EastNorth";
            this.convertToolStripMenuItem.Click += new System.EventHandler(this.convertToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(272, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(272, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem6,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(177, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.latLongToKMLToolStripMenuItem,
            this.toolStripMenuItem7,
            this.tableToExcelToolStripMenuItem});
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // latLongToKMLToolStripMenuItem
            // 
            this.latLongToKMLToolStripMenuItem.Name = "latLongToKMLToolStripMenuItem";
            this.latLongToKMLToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.latLongToKMLToolStripMenuItem.Text = "LatLong To KML";
            this.latLongToKMLToolStripMenuItem.Click += new System.EventHandler(this.latLongToKMLToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(181, 6);
            // 
            // tableToExcelToolStripMenuItem
            // 
            this.tableToExcelToolStripMenuItem.Name = "tableToExcelToolStripMenuItem";
            this.tableToExcelToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.tableToExcelToolStripMenuItem.Text = "Table to Excel";
            this.tableToExcelToolStripMenuItem.Click += new System.EventHandler(this.tableToExcelToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.chooseZoneOrCMToolStripMenuItem,
            this.chooseImportOrGenerateRowToolStripMenuItem});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.latLongToEastNorthToolStripMenuItem,
            this.eastNorthToLatLongToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(301, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // latLongToEastNorthToolStripMenuItem
            // 
            this.latLongToEastNorthToolStripMenuItem.Checked = true;
            this.latLongToEastNorthToolStripMenuItem.CheckOnClick = true;
            this.latLongToEastNorthToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.latLongToEastNorthToolStripMenuItem.Name = "latLongToEastNorthToolStripMenuItem";
            this.latLongToEastNorthToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.latLongToEastNorthToolStripMenuItem.Text = "LatLong to EastNorth";
            this.latLongToEastNorthToolStripMenuItem.Click += new System.EventHandler(this.latLongToEastNorthToolStripMenuItem_Click);
            // 
            // eastNorthToLatLongToolStripMenuItem
            // 
            this.eastNorthToLatLongToolStripMenuItem.CheckOnClick = true;
            this.eastNorthToLatLongToolStripMenuItem.Name = "eastNorthToLatLongToolStripMenuItem";
            this.eastNorthToLatLongToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.eastNorthToLatLongToolStripMenuItem.Text = "EastNorth to LatLong";
            this.eastNorthToLatLongToolStripMenuItem.Click += new System.EventHandler(this.eastNorthToLatLongToolStripMenuItem_Click);
            // 
            // chooseZoneOrCMToolStripMenuItem
            // 
            this.chooseZoneOrCMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneToolStripMenuItem,
            this.cMToolStripMenuItem});
            this.chooseZoneOrCMToolStripMenuItem.Name = "chooseZoneOrCMToolStripMenuItem";
            this.chooseZoneOrCMToolStripMenuItem.Size = new System.Drawing.Size(301, 24);
            this.chooseZoneOrCMToolStripMenuItem.Text = "Choose Input {Zone or CM}";
            // 
            // zoneToolStripMenuItem
            // 
            this.zoneToolStripMenuItem.Checked = true;
            this.zoneToolStripMenuItem.CheckOnClick = true;
            this.zoneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zoneToolStripMenuItem.Name = "zoneToolStripMenuItem";
            this.zoneToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.zoneToolStripMenuItem.Text = "Zone";
            this.zoneToolStripMenuItem.Click += new System.EventHandler(this.zoneToolStripMenuItem_Click);
            // 
            // cMToolStripMenuItem
            // 
            this.cMToolStripMenuItem.CheckOnClick = true;
            this.cMToolStripMenuItem.Name = "cMToolStripMenuItem";
            this.cMToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.cMToolStripMenuItem.Text = "CM";
            this.cMToolStripMenuItem.Click += new System.EventHandler(this.cMToolStripMenuItem_Click);
            // 
            // chooseImportOrGenerateRowToolStripMenuItem
            // 
            this.chooseImportOrGenerateRowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importModeToolStripMenuItem,
            this.generateRowsModeToolStripMenuItem});
            this.chooseImportOrGenerateRowToolStripMenuItem.Name = "chooseImportOrGenerateRowToolStripMenuItem";
            this.chooseImportOrGenerateRowToolStripMenuItem.Size = new System.Drawing.Size(301, 24);
            this.chooseImportOrGenerateRowToolStripMenuItem.Text = "Choose {Import or Generate Row}";
            // 
            // importModeToolStripMenuItem
            // 
            this.importModeToolStripMenuItem.Checked = true;
            this.importModeToolStripMenuItem.CheckOnClick = true;
            this.importModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.importModeToolStripMenuItem.Name = "importModeToolStripMenuItem";
            this.importModeToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.importModeToolStripMenuItem.Text = "Import mode";
            this.importModeToolStripMenuItem.Click += new System.EventHandler(this.importModeToolStripMenuItem_Click);
            // 
            // generateRowsModeToolStripMenuItem
            // 
            this.generateRowsModeToolStripMenuItem.CheckOnClick = true;
            this.generateRowsModeToolStripMenuItem.Name = "generateRowsModeToolStripMenuItem";
            this.generateRowsModeToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.generateRowsModeToolStripMenuItem.Text = "Generate Rows mode";
            this.generateRowsModeToolStripMenuItem.Click += new System.EventHandler(this.generateRowsModeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.LblImportGenerate);
            this.panel1.Controls.Add(this.LblZoneCM);
            this.panel1.Controls.Add(this.LblMode);
            this.panel1.Location = new System.Drawing.Point(0, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 64);
            this.panel1.TabIndex = 1;
            // 
            // LblImportGenerate
            // 
            this.LblImportGenerate.AutoSize = true;
            this.LblImportGenerate.BackColor = System.Drawing.Color.Transparent;
            this.LblImportGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImportGenerate.ForeColor = System.Drawing.Color.Green;
            this.LblImportGenerate.Location = new System.Drawing.Point(577, 27);
            this.LblImportGenerate.Name = "LblImportGenerate";
            this.LblImportGenerate.Size = new System.Drawing.Size(311, 18);
            this.LblImportGenerate.TabIndex = 5;
            this.LblImportGenerate.Text = "Chosen Input {Import or Genrete Row}: Import";
            // 
            // LblZoneCM
            // 
            this.LblZoneCM.AutoSize = true;
            this.LblZoneCM.BackColor = System.Drawing.Color.Transparent;
            this.LblZoneCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblZoneCM.ForeColor = System.Drawing.Color.Red;
            this.LblZoneCM.Location = new System.Drawing.Point(316, 27);
            this.LblZoneCM.Name = "LblZoneCM";
            this.LblZoneCM.Size = new System.Drawing.Size(231, 18);
            this.LblZoneCM.TabIndex = 4;
            this.LblZoneCM.Text = "Chosen Input {Zone or CM}: Zone";
            // 
            // LblMode
            // 
            this.LblMode.AutoSize = true;
            this.LblMode.BackColor = System.Drawing.Color.Transparent;
            this.LblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMode.ForeColor = System.Drawing.Color.Blue;
            this.LblMode.Location = new System.Drawing.Point(12, 27);
            this.LblMode.Name = "LblMode";
            this.LblMode.Size = new System.Drawing.Size(286, 18);
            this.LblMode.TabIndex = 3;
            this.LblMode.Text = "Mode: Convert from LatLong to EastNorth";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSN,
            this.ColLatitude,
            this.ColLongitude,
            this.ColEastingX,
            this.ColNorthingY});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 373);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // ColSN
            // 
            this.ColSN.HeaderText = "Point Name";
            this.ColSN.Name = "ColSN";
            this.ColSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColLatitude
            // 
            this.ColLatitude.HeaderText = "LatitudeN";
            this.ColLatitude.Name = "ColLatitude";
            this.ColLatitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLatitude.Width = 200;
            // 
            // ColLongitude
            // 
            this.ColLongitude.HeaderText = "LongitudeE";
            this.ColLongitude.Name = "ColLongitude";
            this.ColLongitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLongitude.Width = 200;
            // 
            // ColEastingX
            // 
            this.ColEastingX.HeaderText = "EastingX";
            this.ColEastingX.Name = "ColEastingX";
            this.ColEastingX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColEastingX.Width = 200;
            // 
            // ColNorthingY
            // 
            this.ColNorthingY.HeaderText = "NorthingY";
            this.ColNorthingY.Name = "ColNorthingY";
            this.ColNorthingY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNorthingY.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 52);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRowsNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtCM);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtZone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtProjFile);
            this.groupBox1.Controls.Add(this.ComboBoxProjFile);
            this.groupBox1.Controls.Add(this.TxtFalseEastingX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtPhi0DD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtM0);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtK0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtOneByF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ellipsoid:... and Projection: ...";
            // 
            // TxtRowsNo
            // 
            this.TxtRowsNo.Enabled = false;
            this.TxtRowsNo.Location = new System.Drawing.Point(735, 55);
            this.TxtRowsNo.Name = "TxtRowsNo";
            this.TxtRowsNo.Size = new System.Drawing.Size(200, 24);
            this.TxtRowsNo.TabIndex = 20;
            this.TxtRowsNo.TextChanged += new System.EventHandler(this.TxtRowsNo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(732, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Enter No. of rows to generate";
            // 
            // TxtCM
            // 
            this.TxtCM.Location = new System.Drawing.Point(652, 55);
            this.TxtCM.Name = "TxtCM";
            this.TxtCM.Size = new System.Drawing.Size(64, 24);
            this.TxtCM.TabIndex = 18;
            this.TxtCM.TextChanged += new System.EventHandler(this.TxtCM_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "CM";
            // 
            // TxtZone
            // 
            this.TxtZone.ForeColor = System.Drawing.Color.Red;
            this.TxtZone.Location = new System.Drawing.Point(652, 28);
            this.TxtZone.Name = "TxtZone";
            this.TxtZone.Size = new System.Drawing.Size(64, 24);
            this.TxtZone.TabIndex = 16;
            this.TxtZone.TextChanged += new System.EventHandler(this.TxtZone_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(606, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Zone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Choose File (*.proj/*.txt) in Ellipsoid Folder";
            // 
            // TxtProjFile
            // 
            this.TxtProjFile.Location = new System.Drawing.Point(6, 81);
            this.TxtProjFile.Name = "TxtProjFile";
            this.TxtProjFile.Size = new System.Drawing.Size(286, 24);
            this.TxtProjFile.TabIndex = 13;
            // 
            // ComboBoxProjFile
            // 
            this.ComboBoxProjFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProjFile.FormattingEnabled = true;
            this.ComboBoxProjFile.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProjFile.Name = "ComboBoxProjFile";
            this.ComboBoxProjFile.Size = new System.Drawing.Size(286, 26);
            this.ComboBoxProjFile.TabIndex = 12;
            this.ComboBoxProjFile.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProjFile_SelectedIndexChanged);
            // 
            // TxtFalseEastingX
            // 
            this.TxtFalseEastingX.Location = new System.Drawing.Point(565, 87);
            this.TxtFalseEastingX.Name = "TxtFalseEastingX";
            this.TxtFalseEastingX.Size = new System.Drawing.Size(151, 24);
            this.TxtFalseEastingX.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "False Easting X";
            // 
            // TxtPhi0DD
            // 
            this.TxtPhi0DD.Location = new System.Drawing.Point(521, 58);
            this.TxtPhi0DD.Name = "TxtPhi0DD";
            this.TxtPhi0DD.Size = new System.Drawing.Size(79, 24);
            this.TxtPhi0DD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phi0_DD";
            // 
            // TxtM0
            // 
            this.TxtM0.Location = new System.Drawing.Point(521, 28);
            this.TxtM0.Name = "TxtM0";
            this.TxtM0.Size = new System.Drawing.Size(79, 24);
            this.TxtM0.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "M0";
            // 
            // TxtK0
            // 
            this.TxtK0.Location = new System.Drawing.Point(344, 88);
            this.TxtK0.Name = "TxtK0";
            this.TxtK0.Size = new System.Drawing.Size(100, 24);
            this.TxtK0.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "K0";
            // 
            // TxtOneByF
            // 
            this.TxtOneByF.Location = new System.Drawing.Point(342, 58);
            this.TxtOneByF.Name = "TxtOneByF";
            this.TxtOneByF.Size = new System.Drawing.Size(100, 24);
            this.TxtOneByF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "1/f";
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(342, 28);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 24);
            this.TxtA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // datumTransformationToolStripMenuItem
            // 
            this.datumTransformationToolStripMenuItem.Name = "datumTransformationToolStripMenuItem";
            this.datumTransformationToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.datumTransformationToolStripMenuItem.Text = "Datum Transformation";
            this.datumTransformationToolStripMenuItem.Click += new System.EventHandler(this.datumTransformationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CSAY LatLongUTMToFrom_Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latLongToEastNorthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eastNorthToLatLongToolStripMenuItem;
        private System.Windows.Forms.Label LblMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtM0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtK0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOneByF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFalseEastingX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPhi0DD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProjFile;
        private System.Windows.Forms.ComboBox ComboBoxProjFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem loadEllipsoidParameterToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtZone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem chooseZoneOrCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMToolStripMenuItem;
        private System.Windows.Forms.Label LblZoneCM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEastingX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNorthingY;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtRowsNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem chooseImportOrGenerateRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRowsModeToolStripMenuItem;
        private System.Windows.Forms.Label LblImportGenerate;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latLongToKMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem tableToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datumTransformationToolStripMenuItem;
    }
}

