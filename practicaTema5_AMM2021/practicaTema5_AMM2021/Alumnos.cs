using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace practicaTema5_AMM2021
{
    class Alumnos
    {
        private ArrayList listaAlumnos = new ArrayList();

        // Agrega un nuevo alumno a la lista AMM2021
        //        
        public void Agregar(Alumno alu)
        {
            listaAlumnos.Add(alu);
        }

        // Devuelve el alumno que está en la posición num AMM2021
        //
        public Alumno Obtener(int num)
        {
            if (num >= 0 && num <= listaAlumnos.Count)
            {
                return ((Alumno)listaAlumnos[num]);
            }
            return null;
        }

        // Devuelve la nota media de los alumnos AMM2021
        //
        public float Media
        {
            get
            {
                if (listaAlumnos.Count == 0)
                    return 0;
                else
                {
                    float media = 0;
                    for (int i = 0; i < listaAlumnos.Count; i++)
                    {
                        media += ((Alumno)listaAlumnos[i]).Nota;
                    }
                    return (media / listaAlumnos.Count);
                }
            }
        }
    }
}
