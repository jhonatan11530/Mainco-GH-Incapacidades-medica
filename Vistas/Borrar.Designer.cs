namespace GH_Incapacidades_medica.Vistas
{
    partial class Borrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNCAPACIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incapacidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new GH_Incapacidades_medica.DataSets.DataSet6();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet8 = new GH_Incapacidades_medica.DataSets.DataSet8();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.incapacidadTableAdapter = new GH_Incapacidades_medica.DataSets.DataSet6TableAdapters.incapacidadTableAdapter();
            this.personasTableAdapter = new GH_Incapacidades_medica.DataSets.DataSet8TableAdapters.personasTableAdapter();
            this.peticionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new GH_Incapacidades_medica.DataSets.DataSet7();
            this.peticionTableAdapter = new GH_Incapacidades_medica.DataSets.DataSet7TableAdapters.peticionTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rADICADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHARADICADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAPETICIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHATUTELADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incapacidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(5, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 343);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "SELECCIONE INCAPACIDAD A BORRAR";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Borrar Incapacidad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEDULADataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.iNCAPACIDADDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incapacidadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(383, 154);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cEDULADataGridViewTextBoxColumn
            // 
            this.cEDULADataGridViewTextBoxColumn.DataPropertyName = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.HeaderText = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.Name = "cEDULADataGridViewTextBoxColumn";
            this.cEDULADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNCAPACIDADDataGridViewTextBoxColumn
            // 
            this.iNCAPACIDADDataGridViewTextBoxColumn.DataPropertyName = "INCAPACIDAD";
            this.iNCAPACIDADDataGridViewTextBoxColumn.HeaderText = "INCAPACIDAD";
            this.iNCAPACIDADDataGridViewTextBoxColumn.Name = "iNCAPACIDADDataGridViewTextBoxColumn";
            this.iNCAPACIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incapacidadBindingSource
            // 
            this.incapacidadBindingSource.DataMember = "incapacidad";
            this.incapacidadBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese Radicado";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 26);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(425, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 343);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Borrar Radicado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ingrese Radicado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "SELECCIONE RADICADO A BORRAR";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(113, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 26);
            this.textBox2.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.rADICADODataGridViewTextBoxColumn,
            this.fECHARADICADODataGridViewTextBoxColumn,
            this.fECHAPETICIONDataGridViewTextBoxColumn,
            this.fECHATUTELADataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.peticionBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(383, 154);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BORRAR RADICADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "BORRAR INCAPACIDAD";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(238, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Borrar Incapacidad";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(637, 39);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(159, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Borrar Radicado";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Location = new System.Drawing.Point(845, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 343);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(129, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "Borrar Persona";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(145, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ingrese CC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "SELECCIONE PERSONA A BORRAR";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(111, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 26);
            this.textBox3.TabIndex = 11;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.cargaDataGridViewTextBoxColumn,
            this.grupadaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.personasBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(13, 96);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(383, 154);
            this.dataGridView3.TabIndex = 10;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // cedulaDataGridViewTextBoxColumn1
            // 
            this.cedulaDataGridViewTextBoxColumn1.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn1.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn1.Name = "cedulaDataGridViewTextBoxColumn1";
            this.cedulaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cargaDataGridViewTextBoxColumn
            // 
            this.cargaDataGridViewTextBoxColumn.DataPropertyName = "Carga";
            this.cargaDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargaDataGridViewTextBoxColumn.Name = "cargaDataGridViewTextBoxColumn";
            this.cargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupadaDataGridViewTextBoxColumn
            // 
            this.grupadaDataGridViewTextBoxColumn.DataPropertyName = "Grupada";
            this.grupadaDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupadaDataGridViewTextBoxColumn.Name = "grupadaDataGridViewTextBoxColumn";
            this.grupadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this.dataSet8;
            // 
            // dataSet8
            // 
            this.dataSet8.DataSetName = "DataSet8";
            this.dataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(874, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "BORRAR PERSONA";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox3.Location = new System.Drawing.Point(1055, 39);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(149, 24);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Borrar Persona";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
            // 
            // incapacidadTableAdapter
            // 
            this.incapacidadTableAdapter.ClearBeforeFill = true;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // peticionBindingSource
            // 
            this.peticionBindingSource.DataMember = "peticion";
            this.peticionBindingSource.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peticionTableAdapter
            // 
            this.peticionTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 411);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Borrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BORRAR INFORMACION";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incapacidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peticionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DataSets.DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource incapacidadBindingSource;
        private DataSets.DataSet6TableAdapters.incapacidadTableAdapter incapacidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEDULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNCAPACIDADDataGridViewTextBoxColumn;
        private DataSets.DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource peticionBindingSource;
        private DataSets.DataSet7TableAdapters.peticionTableAdapter peticionTableAdapter;
        private DataSets.DataSet8 dataSet8;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private DataSets.DataSet8TableAdapters.personasTableAdapter personasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rADICADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHARADICADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAPETICIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHATUTELADataGridViewTextBoxColumn;
    }
}