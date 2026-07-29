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
            System.Windows.Forms.Label diagnosticoLabel;
            System.Windows.Forms.Label motivoConsultaLabel;
            System.Windows.Forms.Label presionArterialLabel;
            System.Windows.Forms.Label estaturaLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label idCitaLabel;
            System.Windows.Forms.Label idConsultaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.binSrcConsulta = new System.Windows.Forms.BindingSource(this.components);
            this.medical_Center_HVIRFILLDataSetConsulta = new DOCUMED.Medical_Center_HVIRFILLDataSetConsulta();
            this.consultasTableAdapter = new DOCUMED.Medical_Center_HVIRFILLDataSetConsultaTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager = new DOCUMED.Medical_Center_HVIRFILLDataSetConsultaTableAdapters.TableAdapterManager();
            this.idConsultaTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.motivoConsultaTextBox = new System.Windows.Forms.TextBox();
            this.presionArterialTextBox = new System.Windows.Forms.TextBox();
            this.estaturaTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.idCitaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            diagnosticoLabel = new System.Windows.Forms.Label();
            motivoConsultaLabel = new System.Windows.Forms.Label();
            presionArterialLabel = new System.Windows.Forms.Label();
            estaturaLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            idCitaLabel = new System.Windows.Forms.Label();
            idConsultaLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(380, 431);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(83, 19);
            diagnosticoLabel.TabIndex = 109;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // motivoConsultaLabel
            // 
            motivoConsultaLabel.AutoSize = true;
            motivoConsultaLabel.Location = new System.Drawing.Point(380, 399);
            motivoConsultaLabel.Name = "motivoConsultaLabel";
            motivoConsultaLabel.Size = new System.Drawing.Size(113, 19);
            motivoConsultaLabel.TabIndex = 107;
            motivoConsultaLabel.Text = "Motivo Consulta:";
            // 
            // presionArterialLabel
            // 
            presionArterialLabel.AutoSize = true;
            presionArterialLabel.Location = new System.Drawing.Point(380, 367);
            presionArterialLabel.Name = "presionArterialLabel";
            presionArterialLabel.Size = new System.Drawing.Size(105, 19);
            presionArterialLabel.TabIndex = 105;
            presionArterialLabel.Text = "Presión Arterial:";
            // 
            // estaturaLabel
            // 
            estaturaLabel.AutoSize = true;
            estaturaLabel.Location = new System.Drawing.Point(380, 335);
            estaturaLabel.Name = "estaturaLabel";
            estaturaLabel.Size = new System.Drawing.Size(61, 19);
            estaturaLabel.TabIndex = 103;
            estaturaLabel.Text = "Estatura:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(380, 303);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(42, 19);
            pesoLabel.TabIndex = 101;
            pesoLabel.Text = "Peso:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(380, 272);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(49, 19);
            fechaLabel.TabIndex = 99;
            fechaLabel.Text = "Fecha:";
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Location = new System.Drawing.Point(380, 239);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(76, 19);
            idMedicoLabel.TabIndex = 97;
            idMedicoLabel.Text = "Id Médico:";
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Location = new System.Drawing.Point(380, 207);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(80, 19);
            idPacienteLabel.TabIndex = 95;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // idCitaLabel
            // 
            idCitaLabel.AutoSize = true;
            idCitaLabel.Location = new System.Drawing.Point(380, 175);
            idCitaLabel.Name = "idCitaLabel";
            idCitaLabel.Size = new System.Drawing.Size(54, 19);
            idCitaLabel.TabIndex = 93;
            idCitaLabel.Text = "Id Cita:";
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Location = new System.Drawing.Point(380, 143);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(82, 19);
            idConsultaLabel.TabIndex = 91;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(755, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(251, 36);
            this.label14.TabIndex = 86;
            this.label14.Text = "Datos De Consulta";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(859, 381);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 41);
            this.btnLimpiar.TabIndex = 69;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(859, 329);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 41);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(859, 274);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(109, 41);
            this.btnE.TabIndex = 67;
            this.btnE.Text = "Editar";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(859, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 41);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(859, 165);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 41);
            this.btnNuevo.TabIndex = 65;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(831, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 314);
            this.label8.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1901, 100);
            this.panel2.TabIndex = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::DOCUMED.Properties.Resources.hvLog;
            this.pictureBox1.Location = new System.Drawing.Point(1526, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::DOCUMED.Properties.Resources.docMedLogo;
            this.pictureBox2.Location = new System.Drawing.Point(1681, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1283, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 98);
            this.button1.TabIndex = 91;
            this.button1.Text = "Menú Principal";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // binSrcConsulta
            // 
            this.binSrcConsulta.DataMember = "Consultas";
            this.binSrcConsulta.DataSource = this.medical_Center_HVIRFILLDataSetConsulta;
            // 
            // medical_Center_HVIRFILLDataSetConsulta
            // 
            this.medical_Center_HVIRFILLDataSetConsulta.DataSetName = "Medical_Center_HVIRFILLDataSetConsulta";
            this.medical_Center_HVIRFILLDataSetConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DOCUMED.Medical_Center_HVIRFILLDataSetConsultaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idConsultaTextBox
            // 
            this.idConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "IdConsulta", true));
            this.idConsultaTextBox.Location = new System.Drawing.Point(499, 140);
            this.idConsultaTextBox.Name = "idConsultaTextBox";
            this.idConsultaTextBox.Size = new System.Drawing.Size(228, 26);
            this.idConsultaTextBox.TabIndex = 92;
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "Diagnostico", true));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(499, 428);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(228, 26);
            this.diagnosticoTextBox.TabIndex = 110;
            // 
            // motivoConsultaTextBox
            // 
            this.motivoConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "MotivoConsulta", true));
            this.motivoConsultaTextBox.Location = new System.Drawing.Point(499, 396);
            this.motivoConsultaTextBox.Name = "motivoConsultaTextBox";
            this.motivoConsultaTextBox.Size = new System.Drawing.Size(228, 26);
            this.motivoConsultaTextBox.TabIndex = 108;
            // 
            // presionArterialTextBox
            // 
            this.presionArterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "PresionArterial", true));
            this.presionArterialTextBox.Location = new System.Drawing.Point(499, 364);
            this.presionArterialTextBox.Name = "presionArterialTextBox";
            this.presionArterialTextBox.Size = new System.Drawing.Size(228, 26);
            this.presionArterialTextBox.TabIndex = 106;
            // 
            // estaturaTextBox
            // 
            this.estaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "Estatura", true));
            this.estaturaTextBox.Location = new System.Drawing.Point(499, 332);
            this.estaturaTextBox.Name = "estaturaTextBox";
            this.estaturaTextBox.Size = new System.Drawing.Size(228, 26);
            this.estaturaTextBox.TabIndex = 104;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "Peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(499, 300);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(228, 26);
            this.pesoTextBox.TabIndex = 102;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binSrcConsulta, "Fecha", true));
            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(499, 268);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(228, 26);
            this.fechaDateTimePicker.TabIndex = 100;
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "IdMedico", true));
            this.idMedicoTextBox.Location = new System.Drawing.Point(499, 236);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(228, 26);
            this.idMedicoTextBox.TabIndex = 98;
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "IdPaciente", true));
            this.idPacienteTextBox.Location = new System.Drawing.Point(499, 204);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(228, 26);
            this.idPacienteTextBox.TabIndex = 96;
            // 
            // idCitaTextBox
            // 
            this.idCitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcConsulta, "IdCita", true));
            this.idCitaTextBox.Location = new System.Drawing.Point(499, 172);
            this.idCitaTextBox.Name = "idCitaTextBox";
            this.idCitaTextBox.Size = new System.Drawing.Size(228, 26);
            this.idCitaTextBox.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(354, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 401);
            this.label1.TabIndex = 111;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.binSrcConsulta;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(509, 481);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 112;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(idConsultaLabel);
            this.Controls.Add(this.idConsultaTextBox);
            this.Controls.Add(idCitaLabel);
            this.Controls.Add(this.idCitaTextBox);
            this.Controls.Add(idPacienteLabel);
            this.Controls.Add(this.idPacienteTextBox);
            this.Controls.Add(idMedicoLabel);
            this.Controls.Add(this.idMedicoTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(estaturaLabel);
            this.Controls.Add(this.estaturaTextBox);
            this.Controls.Add(presionArterialLabel);
            this.Controls.Add(this.presionArterialTextBox);
            this.Controls.Add(motivoConsultaLabel);
            this.Controls.Add(this.motivoConsultaTextBox);
            this.Controls.Add(diagnosticoLabel);
            this.Controls.Add(this.diagnosticoTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocuMed - Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Medical_Center_HVIRFILLDataSetConsulta medical_Center_HVIRFILLDataSetConsulta;
        private Medical_Center_HVIRFILLDataSetConsultaTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private Medical_Center_HVIRFILLDataSetConsultaTableAdapters.TableAdapterManager tableAdapterManager;
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
    }
}