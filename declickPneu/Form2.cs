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

namespace declickPneu
{
    public partial class Form2 : Form
    {
        private object dataGridViewP;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1er phase  connection simple 
            //string querystring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tarik\source\repos\declickPneu\declickPneu\AppData\Database1.mdf;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(querystring);
            //cn.Open();
            //MessageBox.Show(cn.State.ToString());
            //cn.Close();
            //MessageBox.Show(cn.State.ToString());*/

            //2eme phase connection avec requete
            /*var cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tarik\source\repos\declickPneu\declickPneu\AppData\Database1.mdf;Integrated Security=True";
            String queryString = "SELECT Id,Marque FROM dbo.Produit;";
            var connection = new SqlConnection(cnx);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString(), reader[1].ToString());

                }*/

            // 3 eme test affichage donnée
            /*var cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tarik\source\repos\declickPneu\declickPneu\AppData\Database1.mdf;Integrated Security=True";
            String queryString = "SELECT Id,Marque FROM dbo.Produit;";
            var connection = new SqlConnection(cnx);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgP.DataSource = dt;
            }*/

            var cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tarik\source\repos\declickPneu\declickPneu\AppData\Database1.mdf;Integrated Security=True";
            String queryString = "SELECT Id,Nom FROM dbo.Fournisseur;";
            var connection = new SqlConnection(cnx);
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgP.DataSource = dt;
            }
        }
    }

}