namespace GH_Incapacidades_medica
{
    partial class Notificacion_Radicado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificacion_Radicado));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rADICADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHARADICADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAPETICIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHATUTELADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peticionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new GH_Incapacidades_medica.DataSets.DataSet5();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.peticionTableAdapter = new GH_Incapacidades_medica.DataSets.DataSet5TableAdapters.peticionTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTIFICACION DE RADICADOS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 287);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rADICADODataGridViewTextBoxColumn,
            this.fECHARADICADODataGridViewTextBoxColumn,
            this.fECHAPETICIONDataGridViewTextBoxColumn,
            this.fECHATUTELADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.peticionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(768, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // rADICADODataGridViewTextBoxColumn
            // 
            this.rADICADODataGridViewTextBoxColumn.DataPropertyName = "RADICADO";
            this.rADICADODataGridViewTextBoxColumn.HeaderText = "RADICADO";
            this.rADICADODataGridViewTextBoxColumn.Name = "rADICADODataGridViewTextBoxColumn";
            this.rADICADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHARADICADODataGridViewTextBoxColumn
            // 
            this.fECHARADICADODataGridViewTextBoxColumn.DataPropertyName = "FECHA_RADICADO";
            this.fECHARADICADODataGridViewTextBoxColumn.HeaderText = "FECHA RADICADO";
            this.fECHARADICADODataGridViewTextBoxColumn.Name = "fECHARADICADODataGridViewTextBoxColumn";
            this.fECHARADICADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAPETICIONDataGridViewTextBoxColumn
            // 
            this.fECHAPETICIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_PETICION";
            this.fECHAPETICIONDataGridViewTextBoxColumn.HeaderText = "FECHA PETICION";
            this.fECHAPETICIONDataGridViewTextBoxColumn.Name = "fECHAPETICIONDataGridViewTextBoxColumn";
            this.fECHAPETICIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHATUTELADataGridViewTextBoxColumn
            // 
            this.fECHATUTELADataGridViewTextBoxColumn.DataPropertyName = "FECHA_TUTELA";
            this.fECHATUTELADataGridViewTextBoxColumn.HeaderText = "FECHA TUTELA";
            this.fECHATUTELADataGridViewTextBoxColumn.Name = "fECHATUTELADataGridViewTextBoxColumn";
            this.fECHATUTELADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peticionBindingSource
            // 
            this.peticionBindingSource.DataMember = "peticion";
            this.peticionBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA LIMITE DE RADICADOS";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "CONTINUAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // peticionTableAdapter
            // 
            this.peticionTableAdapter.ClearBeforeFill = true;
            // 
            // Notificacion_Radicado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notificacion_Radicado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTIFICACION DE RADICADOS";
            this.Load += new System.EventHandler(this.Notificacion_Radicado_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private DataSets.DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource peticionBindingSource;
        private DataSets.DataSet5TableAdapters.peticionTableAdapter peticionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADICADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHARADICADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAPETICIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHATUTELADataGridViewTextBoxColumn;
    }
}