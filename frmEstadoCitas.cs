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
        decimal vIdECitas, vFCita;
        string vMotivo, vReprogramado;
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
            vFCita = decimal.Parse(folioCitaTextBox.Text);
            vMotivo = motivoTextBox.Text;
            vReprogramado = reprogramadoTextBox.Text;

            //this.estadoCitasTableAdapter.ActualizarECitas(vNombre, vMotivo, vReprogramado, vIdECitas);

            MessageBox.Show("Estado de cita actualizado correctamente", "ACTUALIZAR REGISTRO");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vIdECitas = decimal.Parse(idEstadoTextBox.Text);
            vFCita = decimal.Parse(folioCitaTextBox.Text);
            vMotivo = motivoTextBox.Text;
            vReprogramado = reprogramadoTextBox.Text;

            this.estadoCitasXYTableAdapter.Delete(vIdECitas, vFCita, vMotivo, vReprogramado);

            MessageBox.Show("Estado de cita eliminado correctamente", "ELIMINAR REGISTRO");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idEstadoTextBox.Clear();
            folioCitaTextBox.Clear();
            motivoTextBox.Clear();
            reprogramadoTextBox.Clear();
            idEstadoTextBox.Focus();
        }

        private void frmEstadoCitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetECitasXY.EstadoCitasXY' table. You can move, or remove it, as needed.
            this.estadoCitasXYTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetECitasXY.EstadoCitasXY);
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetECitas.EstadoCitas' table. You can move, or remove it, as needed.
            //this.estadoCitasTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetECitas.EstadoCitas);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vIdECitas = decimal.Parse(idEstadoTextBox.Text);
            vFCita = decimal.Parse(folioCitaTextBox.Text);
            vMotivo = motivoTextBox.Text;
            vReprogramado = reprogramadoTextBox.Text;

            this.estadoCitasXYTableAdapter.Insert(vIdECitas, vFCita, vMotivo, vReprogramado);
            estadoCitasXYDataGridView.Refresh();
            MessageBox.Show("Estado de cita agregado correctamente", "AGREGAR REGISTRO");
        }

        // private void label1_Click(object sender, EventArgs e)
        //  {

        // }
    }
}
