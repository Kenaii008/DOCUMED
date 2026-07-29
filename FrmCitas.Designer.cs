namespace DOCUMED
{
    partial class FrmCitas
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
            System.Windows.Forms.Label idCitaLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label idEstadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.binSrcCita = new System.Windows.Forms.BindingSource(this.components);
            this.medical_Center_HVIRFILLDataSetCita = new DOCUMED.Medical_Center_HVIRFILLDataSetCita();
            this.citasTableAdapter = new DOCUMED.Medical_Center_HVIRFILLDataSetCitaTableAdapters.CitasTableAdapter();
            this.tableAdapterManager = new DOCUMED.Medical_Center_HVIRFILLDataSetCitaTableAdapters.TableAdapterManager();
            this.idCitaTextBox = new System.Windows.Forms.TextBox();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.idEstadoTextBox = new System.Windows.Forms.TextBox();
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
            idCitaLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            idEstadoLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCitaLabel
            // 
            idCitaLabel.AutoSize = true;
            idCitaLabel.Location = new System.Drawing.Point(407, 283);
            idCitaLabel.Name = "idCitaLabel";
            idCitaLabel.Size = new System.Drawing.Size(54, 19);
            idCitaLabel.TabIndex = 93;
            idCitaLabel.Text = "Id Cita:";
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Location = new System.Drawing.Point(407, 315);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(80, 19);
            idPacienteLabel.TabIndex = 95;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Location = new System.Drawing.Point(407, 347);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(76, 19);
            idMedicoLabel.TabIndex = 97;
            idMedicoLabel.Text = "Id Médico:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(407, 380);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(49, 19);
            fechaLabel.TabIndex = 99;
            fechaLabel.Text = "Fecha:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(407, 411);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(43, 19);
            horaLabel.TabIndex = 101;
            horaLabel.Text = "Hora:";
            // 
            // idEstadoLabel
            // 
            idEstadoLabel.AutoSize = true;
            idEstadoLabel.Location = new System.Drawing.Point(407, 443);
            idEstadoLabel.Name = "idEstadoLabel";
            idEstadoLabel.Size = new System.Drawing.Size(71, 19);
            idEstadoLabel.TabIndex = 103;
            idEstadoLabel.Text = "Id Estado:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(1086, 244);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 46);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1086, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 46);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(1086, 353);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(109, 46);
            this.btnE.TabIndex = 18;
            this.btnE.Text = "Editar";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1086, 408);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 46);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1086, 460);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 46);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(1058, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 319);
            this.label8.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(360, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(898, 360);
            this.label9.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1299, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 98);
            this.button1.TabIndex = 92;
            this.button1.Text = "Menú Principal";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1901, 100);
            this.panel2.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(755, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 40);
            this.label1.TabIndex = 94;
            this.label1.Text = "Citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // binSrcCita
            // 
            this.binSrcCita.DataMember = "Citas";
            this.binSrcCita.DataSource = this.medical_Center_HVIRFILLDataSetCita;
            // 
            // medical_Center_HVIRFILLDataSetCita
            // 
            this.medical_Center_HVIRFILLDataSetCita.DataSetName = "Medical_Center_HVIRFILLDataSetCita";
            this.medical_Center_HVIRFILLDataSetCita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitasTableAdapter = this.citasTableAdapter;
            this.tableAdapterManager.UpdateOrder = DOCUMED.Medical_Center_HVIRFILLDataSetCitaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idCitaTextBox
            // 
            this.idCitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCita, "IdCita", true));
            this.idCitaTextBox.Location = new System.Drawing.Point(493, 280);
            this.idCitaTextBox.Name = "idCitaTextBox";
            this.idCitaTextBox.Size = new System.Drawing.Size(234, 26);
            this.idCitaTextBox.TabIndex = 94;
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCita, "IdPaciente", true));
            this.idPacienteTextBox.Location = new System.Drawing.Point(493, 312);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(234, 26);
            this.idPacienteTextBox.TabIndex = 96;
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCita, "IdMedico", true));
            this.idMedicoTextBox.Location = new System.Drawing.Point(493, 344);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(234, 26);
            this.idMedicoTextBox.TabIndex = 98;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binSrcCita, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(493, 376);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(234, 26);
            this.fechaDateTimePicker.TabIndex = 100;
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCita, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(493, 408);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(234, 26);
            this.horaTextBox.TabIndex = 102;
            // 
            // idEstadoTextBox
            // 
            this.idEstadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCita, "IdEstado", true));
            this.idEstadoTextBox.Location = new System.Drawing.Point(493, 440);
            this.idEstadoTextBox.Name = "idEstadoTextBox";
            this.idEstadoTextBox.Size = new System.Drawing.Size(234, 26);
            this.idEstadoTextBox.TabIndex = 104;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.binSrcCita;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(508, 502);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 105;
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
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(idCitaLabel);
            this.Controls.Add(this.idCitaTextBox);
            this.Controls.Add(idPacienteLabel);
            this.Controls.Add(this.idPacienteTextBox);
            this.Controls.Add(idMedicoLabel);
            this.Controls.Add(this.idMedicoTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(idEstadoLabel);
            this.Controls.Add(this.idEstadoTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocuMed - Gestión de Citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource binSrcCita;
        private Medical_Center_HVIRFILLDataSetCita medical_Center_HVIRFILLDataSetCita;
        private Medical_Center_HVIRFILLDataSetCitaTableAdapters.CitasTableAdapter citasTableAdapter;
        private Medical_Center_HVIRFILLDataSetCitaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idCitaTextBox;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox idEstadoTextBox;
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