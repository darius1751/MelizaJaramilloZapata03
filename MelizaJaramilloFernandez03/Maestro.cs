using MelizaJaramilloFernandez03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelizaJaramilloFernandez03
{
    public partial class Maestro : Form
    {
        public Maestro()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_btnSalir_Click(object sender,EventArgs evento)
        {
            Application.Exit();
        }
        private void menuStrip1_btnCambio_Click(object sender, EventArgs evento)
        {
            Cambio cambio = new Cambio();
            cambio.Visible = true;
            cambio.Show();
            Visible = false;
        }
        private void menuStrip1_btnSalario_Click(object sender, EventArgs evento)
        {
            Salario salario = new Salario();
            salario.Visible = true;
            salario.Show();
            Visible = false;
        }

        private void Maestro_Load(object sender, EventArgs e)
        {

        }
    }
}
