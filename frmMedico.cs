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
    public partial class frmMedico : Form
    {
        string vNombre, vEspecialidad, vCProfesional, vTelefono, vCorreo;
        decimal vIdM;

        private void btnE_Click(object sender, EventArgs e)
        {
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vNombre = nombreTextBox.Text;
            vEspecialidad = especialidadTextBox.Text;
            vCProfesional = cedulaProfesionalTextBox.Text;
            vTelefono = telefonoTextBox.Text;
            vCorreo = correoTextBox.Text;

            this.medicosTableAdapter.ActualizarMedico(vNombre, vEspecialidad, vCProfesional, vTelefono, vCorreo, vIdM);

            MessageBox.Show("Médico actualizado correctamente", "ACTUALIZAR REGISTRO");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vNombre = nombreTextBox.Text;
            vEspecialidad = especialidadTextBox.Text;
            vCProfesional = cedulaProfesionalTextBox.Text;
            vTelefono = telefonoTextBox.Text;
            vCorreo = correoTextBox.Text;

            this.medicosTableAdapter.EliminarMedico(vIdM);

            MessageBox.Show("Médico eliminado correctamente", "ELIMINAR REGISTRO");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idMedicoTextBox.Clear();
            nombreTextBox.Clear();
            especialidadTextBox.Clear();
            cedulaProfesionalTextBox.Clear();
            telefonoTextBox.Clear();
            correoTextBox.Clear();
            idMedicoTextBox.Focus();
        }

        public frmMedico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetMedico.Medicos' table. You can move, or remove it, as needed.
            this.medicosTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetMedico.Medicos);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vIdM = decimal.Parse(idMedicoTextBox.Text);
            vNombre = nombreTextBox.Text;
            vEspecialidad = especialidadTextBox.Text;
            vCProfesional = cedulaProfesionalTextBox.Text;
            vTelefono = telefonoTextBox.Text;
            vCorreo = correoTextBox.Text;

            this.medicosTableAdapter.AgregarMedico(vIdM, vNombre, vEspecialidad, vCProfesional, vTelefono, vCorreo);

            MessageBox.Show("Médico agregado correctamente", "NUEVO REGISTRO");
        }
    }
}
