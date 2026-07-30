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
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        { 
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void FrmConsulta_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetConsultasW.ConsultasW' table. You can move, or remove it, as needed.
            this.consultasWTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetConsultasW.ConsultasW);
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetConsultas.Consultas' table. You can move, or remove it, as needed.
            //this.consultasTableAdapter1.Fill(this.medical_Center_HVIRFILLDataSetConsultas.Consultas);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal vIdConsulta, vIdCita, vIdP, vIdM, vPeso, vEstatura;
            string vFecha, vPArterial, vMConsulta, vDiagnostico;

            vIdConsulta = decimal.Parse(idConsultaTextBox1.Text);
            vIdCita = decimal.Parse(idCitaTextBox1.Text);
            vIdP = decimal.Parse(idPacienteTextBox1.Text);
            vIdM = decimal.Parse(idMedicoTextBox1.Text);
            vPeso = decimal.Parse(pesoTextBox1.Text);
            vEstatura = decimal.Parse(estaturaTextBox1.Text);
            vFecha = fechaTextBox.Text;
            vPArterial = presionArterialTextBox1.Text;
            vMConsulta = motivoConsultaTextBox1.Text;
            vDiagnostico = diagnosticoTextBox1.Text;

            this.consultasWTableAdapter.Insert(vIdConsulta, vIdCita, vIdP, vIdM, vFecha, vPeso, vEstatura, vPArterial, vMConsulta, vDiagnostico);

            MessageBox.Show("Consulta agregada correctamente", "AGREGAR REGISTRO");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            decimal vIdConsulta, vIdCita, vIdP, vIdM, vPeso, vEstatura;
            string vFecha, vPArterial, vMConsulta, vDiagnostico;

            vIdConsulta = decimal.Parse(idConsultaTextBox1.Text);
            vIdCita = decimal.Parse(idCitaTextBox1.Text);
            vIdP = decimal.Parse(idPacienteTextBox1.Text);
            vIdM = decimal.Parse(idMedicoTextBox1.Text);
            vPeso = decimal.Parse(pesoTextBox1.Text);
            vEstatura = decimal.Parse(estaturaTextBox1.Text);
            vFecha = fechaTextBox.Text;
            vPArterial = presionArterialTextBox1.Text;
            vMConsulta = motivoConsultaTextBox1.Text;
            vDiagnostico = diagnosticoTextBox1.Text;

            this.consultasWTableAdapter.Delete(vIdConsulta, vIdCita, vIdP, vIdM, vFecha, vPeso, vEstatura, vPArterial, vMConsulta, vDiagnostico);

            MessageBox.Show("Consulta eliminada correctamente", "ELIMINAR REGISTRO");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            idConsultaTextBox1.Clear();
            idCitaTextBox1.Clear();
            idPacienteTextBox1.Clear();
            idMedicoTextBox1.Clear();
            pesoTextBox1.Clear();
            estaturaTextBox1.Clear();
            fechaTextBox.Clear();
            presionArterialTextBox1.Clear();
            motivoConsultaTextBox1.Clear();
            diagnosticoTextBox1.Clear();
            idConsultaTextBox1.Focus();
        }

       // private void estaturaTextBox1_TextChanged(object sender, EventArgs e)
       // {

       // }
    }
}
