﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMPrac1
{
    public partial class Form1 : Form
    {
        public List<Model.ALUMNO> oAlumno;
        public List<Model.APODERADO> oApoderado;
        public List<Model.CURSO> oCurso;
        public List<Model.INSCRITO> oInscrito;
        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //se llena el combobox
            comboBox1.Items.Add("ALUMNO");
            comboBox1.Items.Add("APODERADO");
            comboBox1.Items.Add("CURSO");
            comboBox1.Items.Add("INSCRITO");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Model.DBPractica1Entities db = new Model.DBPractica1Entities())
            {
                switch(comboBox1.SelectedIndex)
                {
                    case 0:
                        oAlumno = db.ALUMNO.ToList();
                        break;
                    case 1:
                        oApoderado = db.APODERADO.ToList();
                        break;
                    case 2:
                        oCurso = db.CURSO.ToList();
                        break;
                    case 3:
                        oInscrito = db.INSCRITO.ToList();
                        break;
                }

            }

            indice = 0;
            Llenar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            indice--;
            Llenar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indice++;
            Llenar();
        }

        public void Llenar()
        {
            if (indice < 0)
                indice = 0;

            string cadena = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (indice >= oAlumno.Count)
                        indice = oAlumno.Count - 1;
                
                    cadena = oAlumno[indice].Id.ToString() + "," + oAlumno.[indice].Nombre + ", de" + oAlumno[indice].Ciudad + "," + oAlumno[indice].Edad + "años";
                    break;
                case 1:
                    if (indice >= oApoderado.Count)
                        indice = oApoderado.Count - 1;
                    // se abre la conexion a la base de datos
                    using (Model.DBPractica1Entities db = new Model.DBPractica1Entities())
                    {
                        // se instancia el objeto alumno
                        oAlumno = db.ALUMNO.ToList();

                        cadena = oApoderado[indice].Id.ToString() + "," + oApoderado[indice].Nombre + ", es de el|la apoderado|a de " + oAlumno.Find(a => a.Id == (int)oApoderado[indice].Id_Alumno).Nombre;
                        // de la tabla de apoderado muestra el id, el nombre

                    }
                    break;

                case 2:
                    if (indice >= oCurso.Count)
                        indice = oCurso.Count - 1;
                    cadena = oCurso[indice].Cod.ToString() + " , " + oCurso[indice].Nombre + " -- Fecha de inicio: " + oCurso[indice].Fecha_inicio + " -- Duracion: " + oCurso[indice].Duracion + "--Valor" + oCurso[indice].Valor;
                    break;

                case 3:
                    if (indice >= oInscrito.Count)
                        indice = oInscrito.Count - 1;

                    using (Model.DBPractica1Entities db = new Model.DBPractica1Entities())
                    {
                        oAlumno = db.ALUMNO.ToList();
                        oCurso = db.CURSO.ToList();

                        cadena = oInscrito[indice].Id.ToString() + " , " + oAlumno.Find(a => a.Id == (int)oInscrito[indice].Id_Alumno).Nombre + " estudia " + oCurso.Find(a => a.Cod == (int)oInscrito[indice].Cod_Curso);
                     }
                    break;

            }
            textBox1.Text = cadena;

        }
    }
}
