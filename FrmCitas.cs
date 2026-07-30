using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOCUMED
{
    public partial class FrmCitas : Form
    {
        private void btnE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string vHora, vFecha;
            decimal vIdP, vIdM, vIdC, vIdE, vFCita;

            vIdC = decimal.Parse(idCitaTextBox.Text);
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vFecha = fechaTextBox.Text;
            vHora = horaTextBox.Text;
            vIdE = decimal.Parse(idEstadoTextBox.Text);
            vFCita = decimal.Parse(folioCitaTextBox.Text);

            this.citasXYTableAdapter.Delete(vIdC, vIdP, vIdM, vFecha, vHora, vIdE, vFCita);
            citasXYDataGridView.Refresh();

            MessageBox.Show("Cita eliminada correctamente", "ELIMINAR REGISTRO");
        }

        public FrmCitas()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idCitaTextBox.Clear();
            idPacienteTextBox.Clear();
            idMedicoTextBox.Clear();
            fechaTextBox.Clear();
            horaTextBox.Clear();
            idEstadoTextBox.Clear();
            folioCitaTextBox.Clear();
            idCitaTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetCitasXY.CitasXY' table. You can move, or remove it, as needed.
            this.citasXYTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetCitasXY.CitasXY);
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetCitasY.CitasY' table. You can move, or remove it, as needed.
            //this.citasYTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetCitasY.CitasY);
            //this.citasTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetCita.Citas);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string vHora, vFecha;
            decimal vIdP, vIdM, vIdC, vIdE, vFCita;

            vIdC = decimal.Parse(idCitaTextBox.Text);
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vFecha = fechaTextBox.Text;
            vHora = horaTextBox.Text;
            vIdE = decimal.Parse(idEstadoTextBox.Text);
            vFCita = decimal.Parse(folioCitaTextBox.Text);

            this.citasXYTableAdapter.Insert(vIdC, vIdP, vIdM, vFecha, vHora, vIdE, vFCita);
            citasXYDataGridView.Refresh();

            MessageBox.Show("Cita agregada correctamente", "NUEVO REGISTRO");
        }

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
