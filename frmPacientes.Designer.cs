namespace DOCUMED
{
    partial class frmPacientes
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
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label alergiasLabel;
            System.Windows.Forms.Label padecimientosCronicosLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label contactoEmergenciaLabel;
            System.Windows.Forms.Label telefonoEmergenciaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.binSrcPaciente = new System.Windows.Forms.BindingSource(this.components);
            this.medical_Center_HVIRFILLDataSetPaciente = new DOCUMED.Medical_Center_HVIRFILLDataSetPaciente();
            this.pacientesTableAdapter = new DOCUMED.Medical_Center_HVIRFILLDataSetPacienteTableAdapters.PacientesTableAdapter();
            this.tableAdapterManager = new DOCUMED.Medical_Center_HVIRFILLDataSetPacienteTableAdapters.TableAdapterManager();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.alergiasTextBox = new System.Windows.Forms.TextBox();
            this.padecimientosCronicosTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.contactoEmergenciaTextBox = new System.Windows.Forms.TextBox();
            this.telefonoEmergenciaTextBox = new System.Windows.Forms.TextBox();
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
            idPacienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            alergiasLabel = new System.Windows.Forms.Label();
            padecimientosCronicosLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            contactoEmergenciaLabel = new System.Windows.Forms.Label();
            telefonoEmergenciaLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Location = new System.Drawing.Point(624, 214);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(80, 19);
            idPacienteLabel.TabIndex = 118;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(624, 246);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(63, 19);
            nombreLabel.TabIndex = 120;
            nombreLabel.Text = "Nombre:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(624, 279);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(122, 19);
            fechaNacimientoLabel.TabIndex = 122;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(624, 310);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(43, 19);
            sexoLabel.TabIndex = 124;
            sexoLabel.Text = "Sexo:";
            // 
            // alergiasLabel
            // 
            alergiasLabel.AutoSize = true;
            alergiasLabel.Location = new System.Drawing.Point(624, 342);
            alergiasLabel.Name = "alergiasLabel";
            alergiasLabel.Size = new System.Drawing.Size(61, 19);
            alergiasLabel.TabIndex = 126;
            alergiasLabel.Text = "Alergias:";
            // 
            // padecimientosCronicosLabel
            // 
            padecimientosCronicosLabel.AutoSize = true;
            padecimientosCronicosLabel.Location = new System.Drawing.Point(624, 374);
            padecimientosCronicosLabel.Name = "padecimientosCronicosLabel";
            padecimientosCronicosLabel.Size = new System.Drawing.Size(158, 19);
            padecimientosCronicosLabel.TabIndex = 128;
            padecimientosCronicosLabel.Text = "Padecimientos Crónicos:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(624, 406);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(64, 19);
            telefonoLabel.TabIndex = 130;
            telefonoLabel.Text = "Teléfono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(624, 438);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(56, 19);
            correoLabel.TabIndex = 132;
            correoLabel.Text = "Correo:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(624, 470);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(70, 19);
            direccionLabel.TabIndex = 134;
            direccionLabel.Text = "Dirección:";
            // 
            // contactoEmergenciaLabel
            // 
            contactoEmergenciaLabel.AutoSize = true;
            contactoEmergenciaLabel.Location = new System.Drawing.Point(624, 502);
            contactoEmergenciaLabel.Name = "contactoEmergenciaLabel";
            contactoEmergenciaLabel.Size = new System.Drawing.Size(142, 19);
            contactoEmergenciaLabel.TabIndex = 136;
            contactoEmergenciaLabel.Text = "Contacto Emergencia:";
            // 
            // telefonoEmergenciaLabel
            // 
            telefonoEmergenciaLabel.AutoSize = true;
            telefonoEmergenciaLabel.Location = new System.Drawing.Point(624, 534);
            telefonoEmergenciaLabel.Name = "telefonoEmergenciaLabel";
            telefonoEmergenciaLabel.Size = new System.Drawing.Size(138, 19);
            telefonoEmergenciaLabel.TabIndex = 138;
            telefonoEmergenciaLabel.Text = "Teléfono Emergencia:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(755, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(257, 36);
            this.label14.TabIndex = 116;
            this.label14.Text = "Datos Del Paciente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1303, 468);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 46);
            this.btnLimpiar.TabIndex = 99;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1303, 416);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 46);
            this.btnEliminar.TabIndex = 98;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(1303, 361);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(109, 46);
            this.btnE.TabIndex = 97;
            this.btnE.Text = "Editar";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1303, 308);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 46);
            this.btnGuardar.TabIndex = 96;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(1303, 252);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 46);
            this.btnNuevo.TabIndex = 95;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(1275, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 319);
            this.label8.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(577, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(901, 422);
            this.label9.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1901, 100);
            this.panel2.TabIndex = 117;
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
            this.button1.Location = new System.Drawing.Point(1508, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 98);
            this.button1.TabIndex = 118;
            this.button1.Text = "Menú Principal";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // binSrcPaciente
            // 
            this.binSrcPaciente.DataMember = "Pacientes";
            this.binSrcPaciente.DataSource = this.medical_Center_HVIRFILLDataSetPaciente;
            // 
            // medical_Center_HVIRFILLDataSetPaciente
            // 
            this.medical_Center_HVIRFILLDataSetPaciente.DataSetName = "Medical_Center_HVIRFILLDataSetPaciente";
            this.medical_Center_HVIRFILLDataSetPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DOCUMED.Medical_Center_HVIRFILLDataSetPacienteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "IdPaciente", true));
            this.idPacienteTextBox.Location = new System.Drawing.Point(788, 211);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(239, 26);
            this.idPacienteTextBox.TabIndex = 119;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(788, 243);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(239, 26);
            this.nombreTextBox.TabIndex = 121;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binSrcPaciente, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(788, 275);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(239, 26);
            this.fechaNacimientoDateTimePicker.TabIndex = 123;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(788, 307);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(239, 26);
            this.sexoTextBox.TabIndex = 125;
            // 
            // alergiasTextBox
            // 
            this.alergiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "Alergias", true));
            this.alergiasTextBox.Location = new System.Drawing.Point(788, 339);
            this.alergiasTextBox.Name = "alergiasTextBox";
            this.alergiasTextBox.Size = new System.Drawing.Size(239, 26);
            this.alergiasTextBox.TabIndex = 127;
            // 
            // padecimientosCronicosTextBox
            // 
            this.padecimientosCronicosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "PadecimientosCronicos", true));
            this.padecimientosCronicosTextBox.Location = new System.Drawing.Point(788, 371);
            this.padecimientosCronicosTextBox.Name = "padecimientosCronicosTextBox";
            this.padecimientosCronicosTextBox.Size = new System.Drawing.Size(239, 26);
            this.padecimientosCronicosTextBox.TabIndex = 129;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(788, 403);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(239, 26);
            this.telefonoTextBox.TabIndex = 131;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(788, 435);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(239, 26);
            this.correoTextBox.TabIndex = 133;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(788, 467);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(239, 26);
            this.direccionTextBox.TabIndex = 135;
            // 
            // contactoEmergenciaTextBox
            // 
            this.contactoEmergenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "ContactoEmergencia", true));
            this.contactoEmergenciaTextBox.Location = new System.Drawing.Point(788, 499);
            this.contactoEmergenciaTextBox.Name = "contactoEmergenciaTextBox";
            this.contactoEmergenciaTextBox.Size = new System.Drawing.Size(239, 26);
            this.contactoEmergenciaTextBox.TabIndex = 137;
            // 
            // telefonoEmergenciaTextBox
            // 
            this.telefonoEmergenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcPaciente, "TelefonoEmergencia", true));
            this.telefonoEmergenciaTextBox.Location = new System.Drawing.Point(788, 531);
            this.telefonoEmergenciaTextBox.Name = "telefonoEmergenciaTextBox";
            this.telefonoEmergenciaTextBox.Size = new System.Drawing.Size(239, 26);
            this.telefonoEmergenciaTextBox.TabIndex = 139;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.binSrcPaciente;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(800, 573);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 140;
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
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(idPacienteLabel);
            this.Controls.Add(this.idPacienteTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(alergiasLabel);
            this.Controls.Add(this.alergiasTextBox);
            this.Controls.Add(padecimientosCronicosLabel);
            this.Controls.Add(this.padecimientosCronicosTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(contactoEmergenciaLabel);
            this.Controls.Add(this.contactoEmergenciaTextBox);
            this.Controls.Add(telefonoEmergenciaLabel);
            this.Controls.Add(this.telefonoEmergenciaTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocuMed - Gestión de Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetPaciente)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource binSrcPaciente;
        private Medical_Center_HVIRFILLDataSetPaciente medical_Center_HVIRFILLDataSetPaciente;
        private Medical_Center_HVIRFILLDataSetPacienteTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private Medical_Center_HVIRFILLDataSetPacienteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox alergiasTextBox;
        private System.Windows.Forms.TextBox padecimientosCronicosTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox contactoEmergenciaTextBox;
        private System.Windows.Forms.TextBox telefonoEmergenciaTextBox;
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