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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            decimal vIdConsulta, vIdCita, vIdP, vIdM, vPeso, vEstatura;
            string vFecha, vPArterial, vMConsulta, vDiagnostico;
            vIdConsulta = decimal.Parse(idConsultaTextBox.Text);
            vIdCita = decimal.Parse(idCitaTextBox.Text);
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vPeso = decimal.Parse(pesoTextBox.Text);
            vEstatura = decimal.Parse(estaturaTextBox.Text);
            vFecha = fechaDateTimePicker.Value.ToString("yyyy/MM/dd");
            vPArterial = presionArterialTextBox.Text;
            vMConsulta = motivoConsultaTextBox.Text;
            vDiagnostico = diagnosticoTextBox.Text;

            this.consultasTableAdapter.ActualizarConsulta(vIdCita, vIdP, vIdM, vFecha, vPeso, vEstatura, vPArterial, vMConsulta, vDiagnostico, vIdConsulta);

            MessageBox.Show("Consulta actualizada correctamente", "ACTUALIZAR REGISTRO");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        { 
            decimal vIdConsulta, vIdCita, vIdP, vIdM, vPeso, vEstatura;
            string vFecha, vPArterial, vMConsulta, vDiagnostico;

            vIdConsulta = decimal.Parse(idConsultaTextBox.Text);
            vIdCita = decimal.Parse(idCitaTextBox.Text);
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vPeso = decimal.Parse(pesoTextBox.Text);
            vEstatura = decimal.Parse(estaturaTextBox.Text);
            vFecha = fechaDateTimePicker.Value.ToString("yyyy/MM/dd");
            vPArterial = presionArterialTextBox.Text;
            vMConsulta = motivoConsultaTextBox.Text;
            vDiagnostico = diagnosticoTextBox.Text;

            this.consultasTableAdapter.EliminarConsulta(vIdConsulta);

            MessageBox.Show("Consulta eliminada correctamente", "ELIMINAR REGISTRO");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idConsultaTextBox.Clear();
            idCitaTextBox.Clear();
            idPacienteTextBox.Clear();
            idMedicoTextBox.Clear();
            pesoTextBox.Clear();
            estaturaTextBox.Clear();
            fechaDateTimePicker.Value = DateTime.Now;
            presionArterialTextBox.Clear();
            motivoConsultaTextBox.Clear();
            diagnosticoTextBox.Clear();
            idConsultaTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetConsulta.Consultas' table. You can move, or remove it, as needed.
            this.consultasTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetConsulta.Consultas);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal vIdConsulta, vIdCita, vIdP, vIdM, vPeso, vEstatura;
            string vFecha, vPArterial, vMConsulta, vDiagnostico;

            vIdConsulta = decimal.Parse(idConsultaTextBox.Text);
            vIdCita = decimal.Parse(idCitaTextBox.Text);
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vPeso = decimal.Parse(pesoTextBox.Text);
            vEstatura = decimal.Parse(estaturaTextBox.Text);
            vFecha = fechaDateTimePicker.Value.ToString("yyyy/MM/dd");
            vPArterial = presionArterialTextBox.Text;
            vMConsulta = motivoConsultaTextBox.Text;
            vDiagnostico = diagnosticoTextBox.Text;

            this.consultasTableAdapter.AgregarConsulta(vIdConsulta, vIdCita, vIdP, vIdM, vFecha, vPeso, vEstatura, vPArterial, vMConsulta, vDiagnostico);

            MessageBox.Show("Consulta agregada correctamente", "AGREGAR REGISTRO");
        }
    }
}
