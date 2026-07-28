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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // private void pictureBox3_Click(object sender, EventArgs e)
        // {


        // }

        // private void pictureBox4_Click(object sender, EventArgs e)
        // {

        // }

        // private void pictureBox5_Click(object sender, EventArgs e)
        //  {

        // }

        // private void pictureBox6_Click(object sender, EventArgs e)
        // {

        // }

        //private void pictureBox7_Click(object sender, EventArgs e)
        // {

        // }

        private void picBoxCitas(object sender, EventArgs e)
        {
            FrmCitas frmCit = new FrmCitas();
            this.Hide();
            frmCit.Show();
        }

        private void picboxPacientes(object sender, EventArgs e)
        {
            frmPacientes frmPac = new frmPacientes();
            this.Hide();
            frmPac.Show();
        }

        private void picBoxConsulta(object sender, EventArgs e)
        {
            FrmConsulta frmCon = new FrmConsulta();
            this.Hide();
            frmCon.Show();
        }

        private void picBoxEstado(object sender, EventArgs e)
        {
            frmEstadoCitas frmEstCit = new frmEstadoCitas();
            this.Hide();
            frmEstCit.Show();
        }

        private void picBoxMedico(object sender, EventArgs e)
        {
            frmMedico frmMed = new frmMedico();
            this.Hide();
            frmMed.Show();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar el sistema DOCUMED", "Saliendo del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
