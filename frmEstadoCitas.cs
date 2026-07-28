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

        private void frmEstadoCitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_Center_HVIRFILLDataSetECitas.EstadoCitas' table. You can move, or remove it, as needed.
            this.estadoCitasTableAdapter.Fill(this.medical_Center_HVIRFILLDataSetECitas.EstadoCitas);

        }

        // private void label1_Click(object sender, EventArgs e)
        //  {

        // }
    }
}
