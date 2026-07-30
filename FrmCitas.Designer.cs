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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            System.Windows.Forms.Label idCitaLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label idEstadoLabel;
            System.Windows.Forms.Label folioCitaLabel;
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.binSrcCitasXY = new System.Windows.Forms.BindingSource(this.components);
            this.medical_Center_HVIRFILLDataSetCitasXY = new DOCUMED.Medical_Center_HVIRFILLDataSetCitasXY();
            this.citasXYTableAdapter = new DOCUMED.Medical_Center_HVIRFILLDataSetCitasXYTableAdapters.CitasXYTableAdapter();
            this.tableAdapterManager = new DOCUMED.Medical_Center_HVIRFILLDataSetCitasXYTableAdapters.TableAdapterManager();
            this.idCitaTextBox = new System.Windows.Forms.TextBox();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.idEstadoTextBox = new System.Windows.Forms.TextBox();
            this.folioCitaTextBox = new System.Windows.Forms.TextBox();
            this.citasXYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idCitaLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            idEstadoLabel = new System.Windows.Forms.Label();
            folioCitaLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcCitasXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetCitasXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasXYDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1319, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 51);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1319, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 51);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1319, 416);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 51);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(1291, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 307);
            this.label8.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(593, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(898, 612);
            this.label9.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1319, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
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
            this.panel2.Location = new System.Drawing.Point(234, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1901, 110);
            this.panel2.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(755, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 47);
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
            this.pictureBox1.Size = new System.Drawing.Size(127, 126);
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
            this.pictureBox2.Size = new System.Drawing.Size(127, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // binSrcCitasXY
            // 
            this.binSrcCitasXY.DataMember = "CitasXY";
            this.binSrcCitasXY.DataSource = this.medical_Center_HVIRFILLDataSetCitasXY;
            // 
            // medical_Center_HVIRFILLDataSetCitasXY
            // 
            this.medical_Center_HVIRFILLDataSetCitasXY.DataSetName = "Medical_Center_HVIRFILLDataSetCitasXY";
            this.medical_Center_HVIRFILLDataSetCitasXY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasXYTableAdapter
            // 
            this.citasXYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitasXYTableAdapter = this.citasXYTableAdapter;
            this.tableAdapterManager.UpdateOrder = DOCUMED.Medical_Center_HVIRFILLDataSetCitasXYTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idCitaLabel
            // 
            idCitaLabel.AutoSize = true;
            idCitaLabel.Location = new System.Drawing.Point(659, 291);
            idCitaLabel.Name = "idCitaLabel";
            idCitaLabel.Size = new System.Drawing.Size(57, 21);
            idCitaLabel.TabIndex = 93;
            idCitaLabel.Text = "Id Cita:";
            // 
            // idCitaTextBox
            // 
            this.idCitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCitasXY, "IdCita", true));
            this.idCitaTextBox.Location = new System.Drawing.Point(752, 288);
            this.idCitaTextBox.Name = "idCitaTextBox";
            this.idCitaTextBox.Size = new System.Drawing.Size(214, 29);
            this.idCitaTextBox.TabIndex = 94;
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Location = new System.Drawing.Point(659, 326);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(87, 21);
            idPacienteLabel.TabIndex = 95;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCitasXY, "IdPaciente", true));
            this.idPacienteTextBox.Location = new System.Drawing.Point(752, 323);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(214, 29);
            this.idPacienteTextBox.TabIndex = 96;
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Location = new System.Drawing.Point(659, 361);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(81, 21);
            idMedicoLabel.TabIndex = 97;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCitasXY, "IdMedico", true));
            this.idMedicoTextBox.Location = new System.Drawing.Point(752, 358);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(214, 29);
            this.idMedicoTextBox.TabIndex = 98;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(659, 396);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(53, 21);
            fechaLabel.TabIndex = 99;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCitasXY, "Fecha", true));
            this.fechaTextBox.Location = new System.Drawing.Point(752, 393);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.Size = new System.Drawing.Size(214, 29);
            this.fechaTextBox.TabIndex = 100;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(659, 431);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(47, 21);
            horaLabel.TabIndex = 101;
            horaLabel.Text = "Hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCitasXY, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(752, 428);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(214, 29);
            this.horaTextBox.TabIndex = 102;
            // 
            // idEstadoLabel
            // 
            idEstadoLabel.AutoSize = true;
            idEstadoLabel.Location = new System.Drawing.Point(659, 466);
            idEstadoLabel.Name = "idEstadoLabel";
            idEstadoLabel.Size = new System.Drawing.Size(76, 21);
            idEstadoLabel.TabIndex = 103;
            idEstadoLabel.Text = "Id Estado:";
            // 
            // idEstadoTextBox
            // 
            this.idEstadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCitasXY, "IdEstado", true));
            this.idEstadoTextBox.Location = new System.Drawing.Point(752, 463);
            this.idEstadoTextBox.Name = "idEstadoTextBox";
            this.idEstadoTextBox.Size = new System.Drawing.Size(214, 29);
            this.idEstadoTextBox.TabIndex = 104;
            // 
            // folioCitaLabel
            // 
            folioCitaLabel.AutoSize = true;
            folioCitaLabel.Location = new System.Drawing.Point(659, 501);
            folioCitaLabel.Name = "folioCitaLabel";
            folioCitaLabel.Size = new System.Drawing.Size(78, 21);
            folioCitaLabel.TabIndex = 105;
            folioCitaLabel.Text = "Folio Cita:";
            // 
            // folioCitaTextBox
            // 
            this.folioCitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcCitasXY, "FolioCita", true));
            this.folioCitaTextBox.Location = new System.Drawing.Point(752, 498);
            this.folioCitaTextBox.Name = "folioCitaTextBox";
            this.folioCitaTextBox.Size = new System.Drawing.Size(214, 29);
            this.folioCitaTextBox.TabIndex = 106;
            // 
            // citasXYDataGridView
            // 
            this.citasXYDataGridView.AutoGenerateColumns = false;
            this.citasXYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citasXYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.citasXYDataGridView.DataSource = this.binSrcCitasXY;
            this.citasXYDataGridView.Location = new System.Drawing.Point(663, 573);
            this.citasXYDataGridView.Name = "citasXYDataGridView";
            this.citasXYDataGridView.Size = new System.Drawing.Size(765, 220);
            this.citasXYDataGridView.TabIndex = 106;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCita";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCita";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdPaciente";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdPaciente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdMedico";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdMedico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdEstado";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdEstado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FolioCita";
            this.dataGridViewTextBoxColumn7.HeaderText = "FolioCita";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.citasXYDataGridView);
            this.Controls.Add(idCitaLabel);
            this.Controls.Add(this.idCitaTextBox);
            this.Controls.Add(idPacienteLabel);
            this.Controls.Add(this.idPacienteTextBox);
            this.Controls.Add(idMedicoLabel);
            this.Controls.Add(this.idMedicoTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(idEstadoLabel);
            this.Controls.Add(this.idEstadoTextBox);
            this.Controls.Add(folioCitaLabel);
            this.Controls.Add(this.folioCitaTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
            ((System.ComponentModel.ISupportInitialize)(this.binSrcCitasXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Center_HVIRFILLDataSetCitasXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasXYDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource binSrcCitasXY;
        private Medical_Center_HVIRFILLDataSetCitasXY medical_Center_HVIRFILLDataSetCitasXY;
        private Medical_Center_HVIRFILLDataSetCitasXYTableAdapters.CitasXYTableAdapter citasXYTableAdapter;
        private Medical_Center_HVIRFILLDataSetCitasXYTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idCitaTextBox;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox idEstadoTextBox;
        private System.Windows.Forms.TextBox folioCitaTextBox;
        private System.Windows.Forms.DataGridView citasXYDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}