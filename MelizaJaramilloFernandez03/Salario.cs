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
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado(
                    txtNombre.Text, 
                    float.Parse(txtSalario.Text), 
                    int.Parse(txtTiempoServicio.Text), 
                    float.Parse(txtDeducciones.Text)
                );
                float bonificacion = 0f;
                if (empleado.Salario < 0f || empleado.Deducciones < 0f || empleado.Tiempo <= 0)
                    throw new ArgumentException();

                if (empleado.Tiempo >= 3 && empleado.Tiempo <= 5)
                    bonificacion = 100000f;
                else if (empleado.Tiempo > 5)
                    bonificacion = 200000f;

                MessageBox.Show($"El total a pagar es: " +
                    $"{empleado.Salario + bonificacion - empleado.Deducciones}\r\n" +
                    $"{(bonificacion == 0 ? "No tiene bonificacion" : $"Tiene una bonificacion de {bonificacion}")}", "Total A Pagar");
            
            }catch(ArgumentException)
            {
                MessageBox.Show("Debe ingresar todos los datos correctamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Salario_Load(object sender, EventArgs e)
        {

        }

        private void Salario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Maestro maestro = new Maestro();
            maestro.Visible = true;
        }
    }
}
