using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPractica1
{
    public partial class Form1 : Form 
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBPractica1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Conexión creada con éxito");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "Select * from Apoderado where Edad>15";
            cmd = new SqlCommand(query, con);

            //set the sqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            // define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dadapter.Fill(ds);

            dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
