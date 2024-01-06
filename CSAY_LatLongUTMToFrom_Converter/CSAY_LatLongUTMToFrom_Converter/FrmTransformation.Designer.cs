namespace CSAY_LatLongUTMToFrom_Converter
{
    partial class FrmTransformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatumTransformationParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geodeticTo3DCartesianForDatum1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dCartesianTransformationUsing7ParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dCartesianToGeodeticForDatum2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.autoProcessAllThreeStepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRowsNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDatumFile = new System.Windows.Forms.TextBox();
            this.ComboBoxDatumFile = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZ1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZ2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImportGenerate = new System.Windows.Forms.Label();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importOrGenerateRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRowsModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importLLHtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColParameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColParameters,
            this.ColValue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(309, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transformationToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDatumTransformationParametersToolStripMenuItem,
            this.importLLHtxtToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDatumTransformationParametersToolStripMenuItem
            // 
            this.loadDatumTransformationParametersToolStripMenuItem.Name = "loadDatumTransformationParametersToolStripMenuItem";
            this.loadDatumTransformationParametersToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.loadDatumTransformationParametersToolStripMenuItem.Text = "Load Datum Transformation Parameters";
            this.loadDatumTransformationParametersToolStripMenuItem.Click += new System.EventHandler(this.loadDatumTransformationParametersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(306, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // transformationToolStripMenuItem
            // 
            this.transformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geodeticTo3DCartesianForDatum1ToolStripMenuItem,
            this.dCartesianTransformationUsing7ParameterToolStripMenuItem,
            this.dCartesianToGeodeticForDatum2ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.autoProcessAllThreeStepsToolStripMenuItem});
            this.transformationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transformationToolStripMenuItem.Name = "transformationToolStripMenuItem";
            this.transformationToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.transformationToolStripMenuItem.Text = "Transformation";
            // 
            // geodeticTo3DCartesianForDatum1ToolStripMenuItem
            // 
            this.geodeticTo3DCartesianForDatum1ToolStripMenuItem.Name = "geodeticTo3DCartesianForDatum1ToolStripMenuItem";
            this.geodeticTo3DCartesianForDatum1ToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.geodeticTo3DCartesianForDatum1ToolStripMenuItem.Text = "Geodetic to 3D Cartesian for Datum1";
            this.geodeticTo3DCartesianForDatum1ToolStripMenuItem.Click += new System.EventHandler(this.geodeticTo3DCartesianForDatum1ToolStripMenuItem_Click);
            // 
            // dCartesianTransformationUsing7ParameterToolStripMenuItem
            // 
            this.dCartesianTransformationUsing7ParameterToolStripMenuItem.Name = "dCartesianTransformationUsing7ParameterToolStripMenuItem";
            this.dCartesianTransformationUsing7ParameterToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.dCartesianTransformationUsing7ParameterToolStripMenuItem.Text = "3D Cartesian Transformation using 7 Parameter";
            this.dCartesianTransformationUsing7ParameterToolStripMenuItem.Click += new System.EventHandler(this.dCartesianTransformationUsing7ParameterToolStripMenuItem_Click);
            // 
            // dCartesianToGeodeticForDatum2ToolStripMenuItem
            // 
            this.dCartesianToGeodeticForDatum2ToolStripMenuItem.Name = "dCartesianToGeodeticForDatum2ToolStripMenuItem";
            this.dCartesianToGeodeticForDatum2ToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.dCartesianToGeodeticForDatum2ToolStripMenuItem.Text = "3D Cartesian to Geodetic for Datum 2";
            this.dCartesianToGeodeticForDatum2ToolStripMenuItem.Click += new System.EventHandler(this.dCartesianToGeodeticForDatum2ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(349, 6);
            // 
            // autoProcessAllThreeStepsToolStripMenuItem
            // 
            this.autoProcessAllThreeStepsToolStripMenuItem.Name = "autoProcessAllThreeStepsToolStripMenuItem";
            this.autoProcessAllThreeStepsToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.autoProcessAllThreeStepsToolStripMenuItem.Text = "Auto Process All Three Steps";
            this.autoProcessAllThreeStepsToolStripMenuItem.Click += new System.EventHandler(this.autoProcessAllThreeStepsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRowsNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtDatumFile);
            this.groupBox1.Controls.Add(this.ComboBoxDatumFile);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From Ellipsoid....To...";
            // 
            // TxtRowsNo
            // 
            this.TxtRowsNo.Enabled = false;
            this.TxtRowsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRowsNo.Location = new System.Drawing.Point(332, 65);
            this.TxtRowsNo.Name = "TxtRowsNo";
            this.TxtRowsNo.Size = new System.Drawing.Size(200, 22);
            this.TxtRowsNo.TabIndex = 20;
            this.TxtRowsNo.TextChanged += new System.EventHandler(this.TxtRowsNo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Enter No. of rows to generate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Choose (*.txt) in Datum Transformation Folder";
            // 
            // TxtDatumFile
            // 
            this.TxtDatumFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatumFile.Location = new System.Drawing.Point(6, 81);
            this.TxtDatumFile.Name = "TxtDatumFile";
            this.TxtDatumFile.Size = new System.Drawing.Size(286, 22);
            this.TxtDatumFile.TabIndex = 13;
            // 
            // ComboBoxDatumFile
            // 
            this.ComboBoxDatumFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDatumFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDatumFile.FormattingEnabled = true;
            this.ComboBoxDatumFile.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxDatumFile.Name = "ComboBoxDatumFile";
            this.ComboBoxDatumFile.Size = new System.Drawing.Size(286, 24);
            this.ComboBoxDatumFile.TabIndex = 12;
            this.ComboBoxDatumFile.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDatumFile_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPoint,
            this.ColLat1,
            this.ColLong1,
            this.Colh1,
            this.ColX1,
            this.ColY1,
            this.ColZ1,
            this.ColX2,
            this.ColY2,
            this.ColZ2,
            this.ColLat2,
            this.ColLong2,
            this.Colh2});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(327, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1031, 422);
            this.dataGridView2.TabIndex = 5;
            // 
            // ColPoint
            // 
            this.ColPoint.HeaderText = "Point";
            this.ColPoint.Name = "ColPoint";
            this.ColPoint.Width = 50;
            // 
            // ColLat1
            // 
            this.ColLat1.HeaderText = "Latitude1";
            this.ColLat1.Name = "ColLat1";
            // 
            // ColLong1
            // 
            this.ColLong1.HeaderText = "Longitude1";
            this.ColLong1.Name = "ColLong1";
            // 
            // Colh1
            // 
            this.Colh1.HeaderText = "Ellipsoid Height1";
            this.Colh1.Name = "Colh1";
            this.Colh1.Width = 60;
            // 
            // ColX1
            // 
            this.ColX1.HeaderText = "X1";
            this.ColX1.Name = "ColX1";
            // 
            // ColY1
            // 
            this.ColY1.HeaderText = "Y1";
            this.ColY1.Name = "ColY1";
            // 
            // ColZ1
            // 
            this.ColZ1.HeaderText = "Z1";
            this.ColZ1.Name = "ColZ1";
            // 
            // ColX2
            // 
            this.ColX2.HeaderText = "X2";
            this.ColX2.Name = "ColX2";
            // 
            // ColY2
            // 
            this.ColY2.HeaderText = "Y2";
            this.ColY2.Name = "ColY2";
            // 
            // ColZ2
            // 
            this.ColZ2.HeaderText = "Z2";
            this.ColZ2.Name = "ColZ2";
            // 
            // ColLat2
            // 
            this.ColLat2.HeaderText = "Latitude2";
            this.ColLat2.Name = "ColLat2";
            // 
            // ColLong2
            // 
            this.ColLong2.HeaderText = "Longitude2";
            this.ColLong2.Name = "ColLong2";
            // 
            // Colh2
            // 
            this.Colh2.HeaderText = "Ellipsoid Height2";
            this.Colh2.Name = "Colh2";
            this.Colh2.Width = 60;
            // 
            // lblImportGenerate
            // 
            this.lblImportGenerate.AutoSize = true;
            this.lblImportGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportGenerate.Location = new System.Drawing.Point(584, 58);
            this.lblImportGenerate.Name = "lblImportGenerate";
            this.lblImportGenerate.Size = new System.Drawing.Size(251, 16);
            this.lblImportGenerate.TabIndex = 22;
            this.lblImportGenerate.Text = "Choose {Import or Generate Row}: Import";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importOrGenerateRowsToolStripMenuItem});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // importOrGenerateRowsToolStripMenuItem
            // 
            this.importOrGenerateRowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importModeToolStripMenuItem,
            this.generateRowsModeToolStripMenuItem});
            this.importOrGenerateRowsToolStripMenuItem.Name = "importOrGenerateRowsToolStripMenuItem";
            this.importOrGenerateRowsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.importOrGenerateRowsToolStripMenuItem.Text = "Import or Generate Rows";
            // 
            // importModeToolStripMenuItem
            // 
            this.importModeToolStripMenuItem.Checked = true;
            this.importModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.importModeToolStripMenuItem.Name = "importModeToolStripMenuItem";
            this.importModeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.importModeToolStripMenuItem.Text = "Import Mode";
            this.importModeToolStripMenuItem.Click += new System.EventHandler(this.importModeToolStripMenuItem_Click);
            // 
            // generateRowsModeToolStripMenuItem
            // 
            this.generateRowsModeToolStripMenuItem.Name = "generateRowsModeToolStripMenuItem";
            this.generateRowsModeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.generateRowsModeToolStripMenuItem.Text = "Generate Rows mode";
            this.generateRowsModeToolStripMenuItem.Click += new System.EventHandler(this.generateRowsModeToolStripMenuItem_Click);
            // 
            // importLLHtxtToolStripMenuItem
            // 
            this.importLLHtxtToolStripMenuItem.Name = "importLLHtxtToolStripMenuItem";
            this.importLLHtxtToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.importLLHtxtToolStripMenuItem.Text = "Import LLH (*.txt)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // ColParameters
            // 
            this.ColParameters.HeaderText = "Parameters";
            this.ColParameters.Name = "ColParameters";
            this.ColParameters.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColParameters.Width = 150;
            // 
            // ColValue
            // 
            this.ColValue.HeaderText = "Values";
            this.ColValue.Name = "ColValue";
            this.ColValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColValue.Width = 150;
            // 
            // FrmTransformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 611);
            this.Controls.Add(this.lblImportGenerate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTransformation";
            this.Text = "Datum Transformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTransformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtRowsNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDatumFile;
        private System.Windows.Forms.ComboBox ComboBoxDatumFile;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem loadDatumTransformationParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZ1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZ2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colh2;
        private System.Windows.Forms.ToolStripMenuItem transformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geodeticTo3DCartesianForDatum1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dCartesianTransformationUsing7ParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dCartesianToGeodeticForDatum2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem autoProcessAllThreeStepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importLLHtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importOrGenerateRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRowsModeToolStripMenuItem;
        private System.Windows.Forms.Label lblImportGenerate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
    }
}