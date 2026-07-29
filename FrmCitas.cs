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
        string vHora;
        decimal vIdP, vIdM, vIdC, vIdE;
        string vFecha;

        private void btnE_Click(object sender, EventArgs e)
        {
            vIdC = decimal.Parse(idCitaTextBox.Text);
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vFecha = fechaDateTimePicker.Value.ToString("yyyy/MM/dd");
            vHora = horaTextBox.Text;
            vIdE = decimal.Parse(idEstadoTextBox.Text);

            MessageBox.Show(vIdC + ", " + vIdP + ", " + vIdM + ", " + vFecha + ", " + vHora + ", " + vIdE);

            this.citasTableAdapter.ActualizarCitas(vIdP, vIdM, Convert.ToDateTime(vFecha), vHora, vIdE, vIdC);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vIdC = decimal.Parse(idCitaTextBox.Text);
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vIdM = decimal.Parse(idMedicoTextBox.Text);
           // vFecha = fechaDateTimePicker.Value;
            vHora = horaTextBox.Text;
            vIdE = decimal.Parse(idEstadoTextBox.Text);

            this.citasTableAdapter.EliminarCitas(vIdC);

            MessageBox.Show("Cita eliminada correctamente", "ELIMINAR REGISTRO");
        }

        public FrmCitas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            this.citasTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetCita.Citas);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vIdC = decimal.Parse(idCitaTextBox.Text);
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            fechaDateTimePicker.CustomFormat="yyyy/mm/dd";
            //vFecha = (fechaDateTimePicker.Value);
            vHora = horaTextBox.Text;
            vIdE = decimal.Parse(idEstadoTextBox.Text);

            //this.citasTableAdapter.AgregarCita(vIdC, vIdP, vIdM, vFecha, vHora, vIdE);

            MessageBox.Show("Cita agregada correctamente", "NUEVO REGISTRO");
        }

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
