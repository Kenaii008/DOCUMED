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
    public partial class frmEstadoCitas : Form
    {
        decimal vIdECitas;
        string vNombre, vMotivo, vReprogramado;
        public frmEstadoCitas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            vIdECitas = decimal.Parse(idEstadoTextBox.Text);
            vNombre = nombreTextBox.Text;
            vMotivo = motivoTextBox.Text;
            vReprogramado = reprogramadoTextBox.Text;

            this.estadoCitasTableAdapter.ActualizarECitas(vNombre, vMotivo, vReprogramado, vIdECitas);

            MessageBox.Show("Estado de cita actualizado correctamente", "ACTUALIZAR REGISTRO");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vIdECitas = decimal.Parse(idEstadoTextBox.Text);
            vNombre = nombreTextBox.Text;
            vMotivo = motivoTextBox.Text;
            vReprogramado = reprogramadoTextBox.Text;

            this.estadoCitasTableAdapter.EliminarECitas(vIdECitas);

            MessageBox.Show("Estado de cita eliminado correctamente", "ELIMINAR REGISTRO");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idEstadoTextBox.Clear();
            nombreTextBox.Clear();
            motivoTextBox.Clear();
            reprogramadoTextBox.Clear();
            idEstadoTextBox.Focus();
        }

        private void frmEstadoCitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetECitas.EstadoCitas' table. You can move, or remove it, as needed.
            this.estadoCitasTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetECitas.EstadoCitas);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vIdECitas = decimal.Parse(idEstadoTextBox.Text);
            vNombre = nombreTextBox.Text;
            vMotivo = motivoTextBox.Text;
            vReprogramado = reprogramadoTextBox.Text;

            this.estadoCitasTableAdapter.AgregarECitas(vIdECitas, vNombre, vMotivo, vReprogramado);

            MessageBox.Show("Estado de cita agregado correctamente", "AGREGAR REGISTRO");
        }

        // private void label1_Click(object sender, EventArgs e)
        //  {

        // }
    }
}
