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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Conexión a la base de datos
        /// </summary>
        public static SqlConnection con= new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDMercamax;Integrated Security=True");

        /// <summary>
        /// cc del usuario conectado
        /// </summary>
        public static int cc;

        /// <summary>
        /// indica si es empleado o no
        /// </summary>
        public static bool isEmploy;

        /// <summary>
        /// indica si es administrador o no
        /// </summary>
        public static bool isAdmin;

        /// <summary>
        /// Form de autenticación de usuario
        /// </summary>
        public LoginForm loginForm;

        /// <summary>
        /// nombre del usuario
        /// </summary>
        public static string nombre;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            loginForm.ShowDialog();

            lblNombre.Text = "Bienvenido " + nombre;

            //MessageBox.Show(isAdmin.ToString());
        }

        private void btnPuntos_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand("VerPuntos", MainForm.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@user", cc));

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        MessageBox.Show("El usuario " + cc.ToString() + " tiene " + rdr.GetInt32(0).ToString() + " puntos", "Sistema de puntos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario " + cc.ToString() + " no aparece listado en el sistema de puntos", "Sistema de puntos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ocurrió un error.\n\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand("SELECT * FROM VerProductos", MainForm.con);
                cmd.CommandType = CommandType.Text;
                
                SqlDataReader rdr = cmd.ExecuteReader();

                MessageBox.Show("Consulta realizada con exito", "Listado de productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error.\n\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBodega.Text))
            {
                return;
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand("VerProductoBodega", MainForm.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codProd", Convert.ToInt32(txtBodega.Text)));

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        MessageBox.Show("El producto " + txtBodega.Text + " tiene " + rdr.GetInt32(0).ToString() + " existencias en la seccion " + rdr.GetInt32(1).ToString(), "Consulta de bodega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El producto existe en la bodega", "Consulta de bodega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error.\n\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btnGondola_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGondola.Text))
            {
                return;
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand("VerProductoGondola", MainForm.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codProd", Convert.ToInt32(txtGondola.Text)));

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        MessageBox.Show("El producto " + txtBodega.Text + " tiene " + rdr.GetInt32(0).ToString() + " existencias en la seccion " + rdr.GetInt32(1).ToString(), "Consulta en gondolas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El producto existe en las gondolas", "Consulta en gondolas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error.\n\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}
