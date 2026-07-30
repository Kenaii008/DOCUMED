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

            //this.consultasTableAdapter.Update(vIdCita, vIdP, vIdM, vFecha, vPeso, vEstatura, vPArterial, vMConsulta, vDiagnostico, vIdConsulta);

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

            //this.consultasTableAdapter.EliminarConsulta(vIdConsulta);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void FrmConsulta_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetConsultas.Consultas' table. You can move, or remove it, as needed.
            this.consultasTableAdapter1.Fill(this.medical_Center_HVIRFILLDataSetConsultas.Consultas);

        }

        private void btnAdd_Click(object sender, EventArgs e)
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

            this.consultasTableAdapter1.Insert(vIdConsulta, vIdCita, vIdP, vIdM, Convert.ToDateTime(vFecha), vPeso, vEstatura, vPArterial, vMConsulta, vDiagnostico);

            MessageBox.Show("Consulta agregada correctamente", "AGREGAR REGISTRO");
        }
    }
}
