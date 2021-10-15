using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMPrac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Model.DB2EntityContainer db = new Model.DB2EntityContainer())
            {
                var oAgents = db.AGENTS.ToList();
                if (oAgents.Count > 0)
                {
                    MessageBox.Show("La base de datos ya contiene información", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Todo
                    //Se debe llenar la base de datos


                    MessageBox.Show("La base de datos ha sido poblada con exito", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                button1.Enabled = false;
            }
        }
    }
}
