namespace DOCUMED
{
    partial class FrmConsulta
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
            System.Windows.Forms.Label idConsultaLabel;
            System.Windows.Forms.Label idCitaLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label estaturaLabel;
            System.Windows.Forms.Label presionArterialLabel;
            System.Windows.Forms.Label motivoConsultaLabel;
            System.Windows.Forms.Label diagnosticoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idConsultaTextBox1 = new System.Windows.Forms.TextBox();
            this.binSrcConsultas = new System.Windows.Forms.BindingSource(this.components);
            this.medical_Center_HVIRFILLDataSetConsultas = new DOCUMED.Medical_Center_HVIRFILLDataSetConsultas();
            this.idCitaTextBox1 = new System.Windows.Forms.TextBox();
            this.idPacienteTextBox1 = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox1 = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pesoTextBox1 = new System.Windows.Forms.TextBox();
            this.estaturaTextBox1 = new System.Windows.Forms.TextBox();
            this.presionArterialTextBox1 = new System.Windows.Forms.TextBox();
            this.motivoConsultaTextBox1 = new System.Windows.Forms.TextBox();
            this.diagnosticoTextBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.consultasTableAdapter1 = new DOCUMED.Medical_Center_HVIRFILLDataSetConsultasTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager1 = new DOCUMED.Medical_Center_HVIRFILLDataSetConsultasTableAdapters.TableAdapterManager();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            idConsultaLabel = new System.Windows.Forms.Label();
            idCitaLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            estaturaLabel = new System.Windows.Forms.Label();
            presionArterialLabel = new System.Windows.Forms.Label();
            motivoConsultaLabel = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetConsultas)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idConsultaLabel.Location = new System.Drawing.Point(50, 36);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(82, 19);
            idConsultaLabel.TabIndex = 1;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // idCitaLabel
            // 
            idCitaLabel.AutoSize = true;
            idCitaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCitaLabel.Location = new System.Drawing.Point(50, 68);
            idCitaLabel.Name = "idCitaLabel";
            idCitaLabel.Size = new System.Drawing.Size(54, 19);
            idCitaLabel.TabIndex = 3;
            idCitaLabel.Text = "Id Cita:";
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPacienteLabel.Location = new System.Drawing.Point(50, 94);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(80, 19);
            idPacienteLabel.TabIndex = 5;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idMedicoLabel.Location = new System.Drawing.Point(50, 120);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(76, 19);
            idMedicoLabel.TabIndex = 7;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(50, 147);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(49, 19);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "Fecha:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.Location = new System.Drawing.Point(50, 172);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(42, 19);
            pesoLabel.TabIndex = 11;
            pesoLabel.Text = "Peso:";
            // 
            // estaturaLabel
            // 
            estaturaLabel.AutoSize = true;
            estaturaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estaturaLabel.Location = new System.Drawing.Point(50, 198);
            estaturaLabel.Name = "estaturaLabel";
            estaturaLabel.Size = new System.Drawing.Size(61, 19);
            estaturaLabel.TabIndex = 13;
            estaturaLabel.Text = "Estatura:";
            // 
            // presionArterialLabel
            // 
            presionArterialLabel.AutoSize = true;
            presionArterialLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            presionArterialLabel.Location = new System.Drawing.Point(50, 224);
            presionArterialLabel.Name = "presionArterialLabel";
            presionArterialLabel.Size = new System.Drawing.Size(105, 19);
            presionArterialLabel.TabIndex = 15;
            presionArterialLabel.Text = "Presion Arterial:";
            // 
            // motivoConsultaLabel
            // 
            motivoConsultaLabel.AutoSize = true;
            motivoConsultaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            motivoConsultaLabel.Location = new System.Drawing.Point(50, 250);
            motivoConsultaLabel.Name = "motivoConsultaLabel";
            motivoConsultaLabel.Size = new System.Drawing.Size(113, 19);
            motivoConsultaLabel.TabIndex = 17;
            motivoConsultaLabel.Text = "Motivo Consulta:";
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diagnosticoLabel.Location = new System.Drawing.Point(50, 276);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(83, 19);
            diagnosticoLabel.TabIndex = 19;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1901, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(755, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consultas";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bindingNavigator2);
            this.panel3.Controls.Add(idConsultaLabel);
            this.panel3.Controls.Add(this.idConsultaTextBox1);
            this.panel3.Controls.Add(idCitaLabel);
            this.panel3.Controls.Add(this.idCitaTextBox1);
            this.panel3.Controls.Add(idPacienteLabel);
            this.panel3.Controls.Add(this.idPacienteTextBox1);
            this.panel3.Controls.Add(idMedicoLabel);
            this.panel3.Controls.Add(this.idMedicoTextBox1);
            this.panel3.Controls.Add(fechaLabel);
            this.panel3.Controls.Add(this.fechaDateTimePicker1);
            this.panel3.Controls.Add(pesoLabel);
            this.panel3.Controls.Add(this.pesoTextBox1);
            this.panel3.Controls.Add(estaturaLabel);
            this.panel3.Controls.Add(this.estaturaTextBox1);
            this.panel3.Controls.Add(presionArterialLabel);
            this.panel3.Controls.Add(this.presionArterialTextBox1);
            this.panel3.Controls.Add(motivoConsultaLabel);
            this.panel3.Controls.Add(this.motivoConsultaTextBox1);
            this.panel3.Controls.Add(diagnosticoLabel);
            this.panel3.Controls.Add(this.diagnosticoTextBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(360, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 386);
            this.panel3.TabIndex = 1;
            // 
            // idConsultaTextBox1
            // 
            this.idConsultaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "IdConsulta", true));
            this.idConsultaTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idConsultaTextBox1.Location = new System.Drawing.Point(180, 36);
            this.idConsultaTextBox1.Name = "idConsultaTextBox1";
            this.idConsultaTextBox1.Size = new System.Drawing.Size(226, 26);
            this.idConsultaTextBox1.TabIndex = 2;
            // 
            // binSrcConsultas
            // 
            this.binSrcConsultas.DataMember = "Consultas";
            this.binSrcConsultas.DataSource = this.medical_Center_HVIRFILLDataSetConsultas;
            // 
            // medical_Center_HVIRFILLDataSetConsultas
            // 
            this.medical_Center_HVIRFILLDataSetConsultas.DataSetName = "Medical_Center_HVIRFILLDataSetConsultas";
            this.medical_Center_HVIRFILLDataSetConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idCitaTextBox1
            // 
            this.idCitaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "IdCita", true));
            this.idCitaTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCitaTextBox1.Location = new System.Drawing.Point(180, 68);
            this.idCitaTextBox1.Name = "idCitaTextBox1";
            this.idCitaTextBox1.Size = new System.Drawing.Size(226, 26);
            this.idCitaTextBox1.TabIndex = 4;
            // 
            // idPacienteTextBox1
            // 
            this.idPacienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "IdPaciente", true));
            this.idPacienteTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPacienteTextBox1.Location = new System.Drawing.Point(180, 94);
            this.idPacienteTextBox1.Name = "idPacienteTextBox1";
            this.idPacienteTextBox1.Size = new System.Drawing.Size(226, 26);
            this.idPacienteTextBox1.TabIndex = 6;
            // 
            // idMedicoTextBox1
            // 
            this.idMedicoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "IdMedico", true));
            this.idMedicoTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idMedicoTextBox1.Location = new System.Drawing.Point(180, 120);
            this.idMedicoTextBox1.Name = "idMedicoTextBox1";
            this.idMedicoTextBox1.Size = new System.Drawing.Size(226, 26);
            this.idMedicoTextBox1.TabIndex = 8;
            // 
            // fechaDateTimePicker1
            // 
            this.fechaDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binSrcConsultas, "Fecha", true));
            this.fechaDateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker1.Location = new System.Drawing.Point(180, 146);
            this.fechaDateTimePicker1.Name = "fechaDateTimePicker1";
            this.fechaDateTimePicker1.Size = new System.Drawing.Size(226, 26);
            this.fechaDateTimePicker1.TabIndex = 10;
            // 
            // pesoTextBox1
            // 
            this.pesoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "Peso", true));
            this.pesoTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTextBox1.Location = new System.Drawing.Point(180, 172);
            this.pesoTextBox1.Name = "pesoTextBox1";
            this.pesoTextBox1.Size = new System.Drawing.Size(226, 26);
            this.pesoTextBox1.TabIndex = 12;
            // 
            // estaturaTextBox1
            // 
            this.estaturaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "Estatura", true));
            this.estaturaTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estaturaTextBox1.Location = new System.Drawing.Point(180, 198);
            this.estaturaTextBox1.Name = "estaturaTextBox1";
            this.estaturaTextBox1.Size = new System.Drawing.Size(226, 26);
            this.estaturaTextBox1.TabIndex = 14;
            // 
            // presionArterialTextBox1
            // 
            this.presionArterialTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "PresionArterial", true));
            this.presionArterialTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presionArterialTextBox1.Location = new System.Drawing.Point(180, 224);
            this.presionArterialTextBox1.Name = "presionArterialTextBox1";
            this.presionArterialTextBox1.Size = new System.Drawing.Size(226, 26);
            this.presionArterialTextBox1.TabIndex = 16;
            // 
            // motivoConsultaTextBox1
            // 
            this.motivoConsultaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "MotivoConsulta", true));
            this.motivoConsultaTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivoConsultaTextBox1.Location = new System.Drawing.Point(180, 250);
            this.motivoConsultaTextBox1.Name = "motivoConsultaTextBox1";
            this.motivoConsultaTextBox1.Size = new System.Drawing.Size(226, 26);
            this.motivoConsultaTextBox1.TabIndex = 18;
            // 
            // diagnosticoTextBox1
            // 
            this.diagnosticoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsultas, "Diagnostico", true));
            this.diagnosticoTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosticoTextBox1.Location = new System.Drawing.Point(180, 276);
            this.diagnosticoTextBox1.Name = "diagnosticoTextBox1";
            this.diagnosticoTextBox1.Size = new System.Drawing.Size(226, 26);
            this.diagnosticoTextBox1.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClean);
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Location = new System.Drawing.Point(695, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 319);
            this.panel4.TabIndex = 0;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(31, 244);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(109, 46);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(31, 192);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 46);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(31, 140);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 46);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(31, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(31, 36);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 46);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1299, 461);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 98);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Menú Principal";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // consultasTableAdapter1
            // 
            this.consultasTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.ConsultasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = DOCUMED.Medical_Center_HVIRFILLDataSetConsultasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.binSrcConsultas;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3});
            this.bindingNavigator2.Location = new System.Drawing.Point(180, 324);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator2.TabIndex = 6;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConsulta_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetConsultas)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource binSrcConsulta;
        //private Medical_Center_HVIRFILLDataSetConsulta medical_Center_HVIRFILLDataSetConsulta;
        //private Medical_Center_HVIRFILLDataSetConsultaTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        //private Medical_Center_HVIRFILLDataSetConsultaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idConsultaTextBox;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        private System.Windows.Forms.TextBox motivoConsultaTextBox;
        private System.Windows.Forms.TextBox presionArterialTextBox;
        private System.Windows.Forms.TextBox estaturaTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox idCitaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource binSrcConsultas;
        private Medical_Center_HVIRFILLDataSetConsultas medical_Center_HVIRFILLDataSetConsultas;
        private Medical_Center_HVIRFILLDataSetConsultasTableAdapters.ConsultasTableAdapter consultasTableAdapter1;
        private System.Windows.Forms.TextBox idConsultaTextBox1;
        private System.Windows.Forms.TextBox idCitaTextBox1;
        private System.Windows.Forms.TextBox idPacienteTextBox1;
        private System.Windows.Forms.TextBox idMedicoTextBox1;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker1;
        private System.Windows.Forms.TextBox pesoTextBox1;
        private System.Windows.Forms.TextBox estaturaTextBox1;
        private System.Windows.Forms.TextBox presionArterialTextBox1;
        private System.Windows.Forms.TextBox motivoConsultaTextBox1;
        private System.Windows.Forms.TextBox diagnosticoTextBox1;
        private Medical_Center_HVIRFILLDataSetConsultasTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}