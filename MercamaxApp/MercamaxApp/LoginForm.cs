using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MercamaxApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?","Confirmación de salida",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Error de autenticación
        /// </summary>
        public void ErrorLogin()
        {
            if (MessageBox.Show("Usuario/contraseña no reconocidos.\n\nDesea intentarlo de nuevo?", "Error de auttenticación", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                txtPass.Clear();
                txtUser.Clear();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.con.Open();

                SqlCommand cmd = new SqlCommand(); ;

                switch (radClient.Checked)
                {
                    case true:
                        cmd = new SqlCommand("LoginCliente", MainForm.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@user", Convert.ToInt32(txtUser.Text)));
                        break;
                    case false:
                        cmd = new SqlCommand("Login", MainForm.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@user", Convert.ToInt32(txtUser.Text)));
                        cmd.Parameters.Add(new SqlParameter("@pass", txtPass.Text));
                        break;
                }
                
                SqlDataReader rdr = cmd.ExecuteReader();                

                if (!rdr.HasRows)
                {
                    ErrorLogin();
                }
                else
                {
                    MainForm.cc = Convert.ToInt32(txtUser.Text);
                    switch (radClient.Checked)
                    {
                        case true:
                            MainForm.isEmploy = false;
                            MainForm.isAdmin = false;
                            while (rdr.Read())
                            {
                                MainForm.nombre = rdr.GetString(1);
                            }                            
                            break;
                        case false:
                            MainForm.isEmploy = true;
                            while (rdr.Read())
                            {
                                MainForm.isAdmin = rdr.GetBoolean(1);
                                MainForm.nombre = rdr.GetString(2);
                            }
                            break;
                    }

                    this.Close();
                }

                MainForm.con.Close();
            }
            catch
            {
                MainForm.con.Close();

                ErrorLogin();
            }
        }
    }
}
