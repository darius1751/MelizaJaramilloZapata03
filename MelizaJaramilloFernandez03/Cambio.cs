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
    public partial class Cambio : Form
    {
        private int cantDineroCambiado;
        private float[] totalDineroCambiado;
        private float gananciaEmpresa;
        private float totalDineroCambiadoP;
        private float totalIva;
        public Cambio()
        {
            InitializeComponent();
            cantDineroCambiado = 0;
            totalDineroCambiado = new float[4] {0f,0f,0f,0f};
            totalDineroCambiadoP = 0f;
            gananciaEmpresa = 0f;
            totalIva = 0f;
        }
        
        private void btnCambio_Click(object sender, EventArgs e)
        {
            float tasaCambio = 0f;
            float cobroS = 0f;
            float pagar = 0f;
            float cambio = 0f;
            float iva = 0f;
            try
            {
                float dineroACambiar = float.Parse(txtDinero.Text);
                switch (lsbxTipoMoneda.SelectedItem.ToString())
                {
                    case "Dolares":
                        tasaCambio = 3400f;
                        break;
                    case "Pesos Mexicanos":
                        tasaCambio = 175f;
                        break;
                    case "Euros":
                        tasaCambio = 3700f;
                        break;
                    case "Yenes":
                        tasaCambio = 32f;
                        break;
                }
                int tipoUsuario = lsbxTipoUsuario.SelectedIndex;
                totalDineroCambiadoP = cambio = tasaCambio * dineroACambiar;
                totalDineroCambiado[lsbxTipoMoneda.SelectedIndex] += dineroACambiar;
                switch (tipoUsuario)
                {
                    case 0:
                        cobroS = cambio * 0.05f;
                        break;
                    case 1:
                        cobroS = cambio * 0.07f;
                        break;
                    case 2:
                        cobroS = cambio * 0.1f;
                        break;
                }
                pagar = cambio + cobroS;
                if (rdbtnColombiano.Checked)
                    pagar += (iva = pagar * 0.19f);
                else
                    pagar += (iva = pagar * 0.25f);
                totalIva += iva;
                txtTotalPagar.Text = pagar.ToString();
                txtMonedaR.Text = lsbxTipoMoneda.SelectedItem.ToString();
                txtTipoUsuarioR.Text = lsbxTipoUsuario.SelectedItem.ToString();
                txtTotalEntregar.Text = cambio.ToString();
                lblIvaR.Text = iva.ToString();
                lblTasaCambioR.Text = tasaCambio.ToString();
                pnlCambio.Visible = true;
                cantDineroCambiado++;
                gananciaEmpresa += cobroS;
            }
            catch
            {
                MessageBox.Show("Debe llenar todos los campos y seleccionar las opciones necesarias","Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDinero.Text = "";
            pnlCambio.Visible = false;
            lsbxTipoMoneda.SelectedItem = null;
            lsbxTipoUsuario.SelectedItem = null;
            rdbtnColombiano.Checked = true;
        }

        private void Cambio_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MessageBox.Show($"Cantidad de usuarios atendidos: {cantDineroCambiado}\r\n" +
                $"Total Dinero Cambiado:\r\n" +
                $"Dolares: ${totalDineroCambiado[0]} \r\n"+
                $"Euros: €{totalDineroCambiado[1]} \r\n" +
                $"Pesos Mexicanos: ${totalDineroCambiado[2]} \r\n" +
                $"Yenes: ${totalDineroCambiado[3]} \r\n" +
                $"Total Dinero cambiado en pesos: ${totalDineroCambiadoP}\r\n" +
                $"Total Iva:${totalIva}", "Total Realizado en el dia");
            Maestro maestro = new Maestro();
            maestro.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        
    }
}
