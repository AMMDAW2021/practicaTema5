using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaTema5_AMM2021
{
    class Alumno
    {
        private string nombre;
        private int nota;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                    nota = value;
            }
        }
        public Boolean Aprobado
        {
            get
            {
                if (nota >= 5)
                    return true;
                else
                    return false;
            }
        }
    }
}
