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
    public partial class frmPacientes : Form
    {
        string vNombre, vSexo, vAlergias, vPCronicos, vTelefono, vCorreo, vDireccion, vCEmergencia, vTEmergencia;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idPacienteTextBox.Clear();
            nombreTextBox.Clear();
            sexoTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Now;
            alergiasTextBox.Clear();
            padecimientosCronicosTextBox.Clear();
            telefonoTextBox.Clear();
            correoTextBox.Clear();
            direccionTextBox.Clear();
            contactoEmergenciaTextBox.Clear();
            telefonoEmergenciaTextBox.Clear();
            idPacienteTextBox.Focus();
        }

        decimal vIdP;
        string vFNacimiento;
        private void btnE_Click(object sender, EventArgs e)
        {
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vNombre = nombreTextBox.Text;
            vSexo = sexoTextBox.Text;
            vFNacimiento = fechaNacimientoDateTimePicker.Value.ToString("yyyy/MM/dd");
            vAlergias = alergiasTextBox.Text;
            vPCronicos = padecimientosCronicosTextBox.Text;
            vTelefono = telefonoTextBox.Text;
            vCorreo = correoTextBox.Text;
            vDireccion = direccionTextBox.Text;
            vCEmergencia = contactoEmergenciaTextBox.Text;
            vTEmergencia = telefonoEmergenciaTextBox.Text;

            this.pacientesTableAdapter.ActualizarPaciente(vNombre, vFNacimiento, vSexo, vAlergias, vPCronicos, vTelefono, vCorreo, vDireccion, vCEmergencia, vTEmergencia, vIdP);

            MessageBox.Show("Paciente actualizado correctamente", "ACTUALIZAR REGISTRO");
        }
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetPaciente.Pacientes' table. You can move, or remove it, as needed.
            this.pacientesTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetPaciente.Pacientes);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vNombre = nombreTextBox.Text;
            vSexo = sexoTextBox.Text;
            vFNacimiento = fechaNacimientoDateTimePicker.Value.ToString("yyyy/MM/dd");
            vAlergias = alergiasTextBox.Text;
            vPCronicos = padecimientosCronicosTextBox.Text;
            vTelefono = telefonoTextBox.Text;
            vCorreo = correoTextBox.Text;
            vDireccion = direccionTextBox.Text;
            vCEmergencia = contactoEmergenciaTextBox.Text;
            vTEmergencia = telefonoEmergenciaTextBox.Text;

            this.pacientesTableAdapter.AgregarPaciente(vIdP, vNombre, vSexo, vFNacimiento, vAlergias, vPCronicos, vTelefono, vCorreo, vDireccion, vCEmergencia, vTEmergencia);

            MessageBox.Show("Paciente agregado correctamente", "NUEVO REGISTRO");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vIdP = decimal.Parse(idPacienteTextBox.Text);
            vNombre = nombreTextBox.Text;
            vSexo = sexoTextBox.Text;
            vFNacimiento = fechaNacimientoDateTimePicker.Value.ToString("yyyy/MM/dd");
            vAlergias = alergiasTextBox.Text;
            vPCronicos = padecimientosCronicosTextBox.Text;
            vTelefono = telefonoTextBox.Text;
            vCorreo = correoTextBox.Text;
            vDireccion = direccionTextBox.Text;
            vCEmergencia = contactoEmergenciaTextBox.Text;
            vTEmergencia = telefonoEmergenciaTextBox.Text;

            this.pacientesTableAdapter.EliminarPaciente(vIdP);

            MessageBox.Show("Paciente eliminado correctamente", "ELIMINAR REGISTRO");
        }
    }
}
