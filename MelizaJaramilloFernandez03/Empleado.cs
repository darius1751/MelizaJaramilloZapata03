using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelizaJaramilloFernandez03
{
    class Empleado
    {
        private String nombre;
        private float salario;
        private int tiempo;
        private float deducciones;
        public Empleado(String nombre,float salario,int tiempo, float deducciones)
        {
            Nombre = nombre;
            Salario = salario;
            Tiempo = tiempo;
            Deducciones = deducciones;
        }
        public String Nombre
        {
            get => nombre;
            private set => nombre = value;
        }
        public float Salario
        {
            get => salario;
            private set => salario = value;
        }

        public int Tiempo
        {
            get => tiempo;
            private set => tiempo = value;
        }

        public float Deducciones
        {
            get => deducciones;
            private set => deducciones = value;
        }
    }
}
