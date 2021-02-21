using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaTema5_AMM2021
{
    public partial class Form1 : Form
    {
        Alumnos misAlumnos = new Alumnos();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Alumno miAlumno = new Alumno();
        String miAlumnoStr;

        miAlumno.Nombre = aluNombre.Text;
        miAlumno.Nota = Convert.ToInt32(aluNota.Text);
        miAlumnoStr = aluNombre.Text + " " + aluNota.Text + (miAlumno.Aprobado ? " Aprobado" : " Suspenso") + "\n";
        listaAlumnos.AppendText(miAlumnoStr);
        misAlumnos.Agregar(miAlumno);
    }
    }
}
