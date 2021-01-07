namespace GH_Incapacidades_medica
{
    partial class InforRadicado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InforRadicado));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rADICADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNCAPACIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASINCAPACIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASASUMIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIASNOLABORADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIAINICIAINCAPACIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incapacidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new GH_Incapacidades_medica.DataSets.DataSet3();
            this.incapacidadTableAdapter = new GH_Incapacidades_medica.DataSets.DataSet3TableAdapters.incapacidadTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rADICADODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHARADICADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAPETICIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHATUTELADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peticionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new GH_Incapacidades_medica.DataSets.DataSet4();
            this.peticionTableAdapter = new GH_Incapacidades_medica.DataSets.DataSet4TableAdapters.peticionTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incapacidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORMACION DE RADICADO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mESDataGridViewTextBoxColumn,
            this.cEDULADataGridViewTextBoxColumn,
            this.rADICADODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.ePSDataGridViewTextBoxColumn,
            this.cARGODataGridViewTextBoxColumn,
            this.aREADataGridViewTextBoxColumn,
            this.eMPRESADataGridViewTextBoxColumn,
            this.iNCAPACIDADDataGridViewTextBoxColumn,
            this.cODIGODataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.fECHAINICIODataGridViewTextBoxColumn,
            this.fECHAFINALDataGridViewTextBoxColumn,
            this.dIASINCAPACIDADDataGridViewTextBoxColumn,
            this.dIASASUMIDADataGridViewTextBoxColumn,
            this.dIASNOLABORADODataGridViewTextBoxColumn,
            this.dIAINICIAINCAPACIDADDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incapacidadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(785, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // mESDataGridViewTextBoxColumn
            // 
            this.mESDataGridViewTextBoxColumn.DataPropertyName = "MES";
            this.mESDataGridViewTextBoxColumn.HeaderText = "MES";
            this.mESDataGridViewTextBoxColumn.Name = "mESDataGridViewTextBoxColumn";
            this.mESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEDULADataGridViewTextBoxColumn
            // 
            this.cEDULADataGridViewTextBoxColumn.DataPropertyName = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.HeaderText = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.Name = "cEDULADataGridViewTextBoxColumn";
            this.cEDULADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rADICADODataGridViewTextBoxColumn
            // 
            this.rADICADODataGridViewTextBoxColumn.DataPropertyName = "RADICADO";
            this.rADICADODataGridViewTextBoxColumn.HeaderText = "RADICADO";
            this.rADICADODataGridViewTextBoxColumn.Name = "rADICADODataGridViewTextBoxColumn";
            this.rADICADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ePSDataGridViewTextBoxColumn
            // 
            this.ePSDataGridViewTextBoxColumn.DataPropertyName = "EPS";
            this.ePSDataGridViewTextBoxColumn.HeaderText = "EPS";
            this.ePSDataGridViewTextBoxColumn.Name = "ePSDataGridViewTextBoxColumn";
            this.ePSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cARGODataGridViewTextBoxColumn
            // 
            this.cARGODataGridViewTextBoxColumn.DataPropertyName = "CARGO";
            this.cARGODataGridViewTextBoxColumn.HeaderText = "CARGO";
            this.cARGODataGridViewTextBoxColumn.Name = "cARGODataGridViewTextBoxColumn";
            this.cARGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aREADataGridViewTextBoxColumn
            // 
            this.aREADataGridViewTextBoxColumn.DataPropertyName = "AREA";
            this.aREADataGridViewTextBoxColumn.HeaderText = "AREA";
            this.aREADataGridViewTextBoxColumn.Name = "aREADataGridViewTextBoxColumn";
            this.aREADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMPRESADataGridViewTextBoxColumn
            // 
            this.eMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMPRESA";
            this.eMPRESADataGridViewTextBoxColumn.HeaderText = "EMPRESA";
            this.eMPRESADataGridViewTextBoxColumn.Name = "eMPRESADataGridViewTextBoxColumn";
            this.eMPRESADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNCAPACIDADDataGridViewTextBoxColumn
            // 
            this.iNCAPACIDADDataGridViewTextBoxColumn.DataPropertyName = "INCAPACIDAD";
            this.iNCAPACIDADDataGridViewTextBoxColumn.HeaderText = "INCAPACIDAD";
            this.iNCAPACIDADDataGridViewTextBoxColumn.Name = "iNCAPACIDADDataGridViewTextBoxColumn";
            this.iNCAPACIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAINICIODataGridViewTextBoxColumn
            // 
            this.fECHAINICIODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.HeaderText = "FECHA INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.Name = "fECHAINICIODataGridViewTextBoxColumn";
            this.fECHAINICIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAFINALDataGridViewTextBoxColumn
            // 
            this.fECHAFINALDataGridViewTextBoxColumn.DataPropertyName = "FECHA_FINAL";
            this.fECHAFINALDataGridViewTextBoxColumn.HeaderText = "FECHA FINAL";
            this.fECHAFINALDataGridViewTextBoxColumn.Name = "fECHAFINALDataGridViewTextBoxColumn";
            this.fECHAFINALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIASINCAPACIDADDataGridViewTextBoxColumn
            // 
            this.dIASINCAPACIDADDataGridViewTextBoxColumn.DataPropertyName = "DIAS_INCAPACIDAD";
            this.dIASINCAPACIDADDataGridViewTextBoxColumn.HeaderText = "DIAS INCAPACIDAD";
            this.dIASINCAPACIDADDataGridViewTextBoxColumn.Name = "dIASINCAPACIDADDataGridViewTextBoxColumn";
            this.dIASINCAPACIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIASASUMIDADataGridViewTextBoxColumn
            // 
            this.dIASASUMIDADataGridViewTextBoxColumn.DataPropertyName = "DIAS_ASUMIDA";
            this.dIASASUMIDADataGridViewTextBoxColumn.HeaderText = "DIAS ASUMIDA";
            this.dIASASUMIDADataGridViewTextBoxColumn.Name = "dIASASUMIDADataGridViewTextBoxColumn";
            this.dIASASUMIDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIASNOLABORADODataGridViewTextBoxColumn
            // 
            this.dIASNOLABORADODataGridViewTextBoxColumn.DataPropertyName = "DIAS_NO_LABORADO";
            this.dIASNOLABORADODataGridViewTextBoxColumn.HeaderText = "DIAS NO LABORADO";
            this.dIASNOLABORADODataGridViewTextBoxColumn.Name = "dIASNOLABORADODataGridViewTextBoxColumn";
            this.dIASNOLABORADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIAINICIAINCAPACIDADDataGridViewTextBoxColumn
            // 
            this.dIAINICIAINCAPACIDADDataGridViewTextBoxColumn.DataPropertyName = "DIA_INICIA_INCAPACIDAD";
            this.dIAINICIAINCAPACIDADDataGridViewTextBoxColumn.HeaderText = "DIA INICIA INCAPACIDAD";
            this.dIAINICIAINCAPACIDADDataGridViewTextBoxColumn.Name = "dIAINICIAINCAPACIDADDataGridViewTextBoxColumn";
            this.dIAINICIAINCAPACIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incapacidadBindingSource
            // 
            this.incapacidadBindingSource.DataMember = "incapacidad";
            this.incapacidadBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incapacidadTableAdapter
            // 
            this.incapacidadTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rADICADODataGridViewTextBoxColumn1,
            this.fECHARADICADODataGridViewTextBoxColumn,
            this.fECHAPETICIONDataGridViewTextBoxColumn,
            this.fECHATUTELADataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.peticionBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(192, 461);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(446, 113);
            this.dataGridView2.TabIndex = 2;
            // 
            // rADICADODataGridViewTextBoxColumn1
            // 
            this.rADICADODataGridViewTextBoxColumn1.DataPropertyName = "RADICADO";
            this.rADICADODataGridViewTextBoxColumn1.HeaderText = "RADICADO";
            this.rADICADODataGridViewTextBoxColumn1.Name = "rADICADODataGridViewTextBoxColumn1";
            this.rADICADODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fECHARADICADODataGridViewTextBoxColumn
            // 
            this.fECHARADICADODataGridViewTextBoxColumn.DataPropertyName = "FECHA_RADICADO";
            this.fECHARADICADODataGridViewTextBoxColumn.HeaderText = "FECHA_RADICADO";
            this.fECHARADICADODataGridViewTextBoxColumn.Name = "fECHARADICADODataGridViewTextBoxColumn";
            this.fECHARADICADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAPETICIONDataGridViewTextBoxColumn
            // 
            this.fECHAPETICIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_PETICION";
            this.fECHAPETICIONDataGridViewTextBoxColumn.HeaderText = "FECHA_PETICION";
            this.fECHAPETICIONDataGridViewTextBoxColumn.Name = "fECHAPETICIONDataGridViewTextBoxColumn";
            this.fECHAPETICIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHATUTELADataGridViewTextBoxColumn
            // 
            this.fECHATUTELADataGridViewTextBoxColumn.DataPropertyName = "FECHA_TUTELA";
            this.fECHATUTELADataGridViewTextBoxColumn.HeaderText = "FECHA_TUTELA";
            this.fECHATUTELADataGridViewTextBoxColumn.Name = "fECHATUTELADataGridViewTextBoxColumn";
            this.fECHATUTELADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peticionBindingSource
            // 
            this.peticionBindingSource.DataMember = "peticion";
            this.peticionBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peticionTableAdapter
            // 
            this.peticionTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "INFORMACION SOBRE LA PERSONA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "INFORMACION SOBRE EL RADICADO";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(257, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "N° DE RADICADO";
            // 
            // InforRadicado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 586);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InforRadicado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InforRadicado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incapacidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSets.DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource incapacidadBindingSource;
        private DataSets.DataSet3TableAdapters.incapacidadTableAdapter incapacidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEDULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADICADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNCAPACIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASINCAPACIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASASUMIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIASNOLABORADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIAINICIAINCAPACIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSets.DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource peticionBindingSource;
        private DataSets.DataSet4TableAdapters.peticionTableAdapter peticionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADICADODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHARADICADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAPETICIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHATUTELADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}