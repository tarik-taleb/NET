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
using System.Configuration;

namespace declickPneu
{
    public partial class Form2 : Form
    {
        private object dataGridViewP;
        private object connection;

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

            /*var cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tarik\source\repos\declickPneu\declickPneu\AppData\Database1.mdf;Integrated Security=True";
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
            }*/

            ConnectionStringSettings cx = ConfigurationManager.ConnectionStrings["MaConnexion"];
            var  connection = new SqlConnection(cx.ConnectionString );
            {
                string queryString = "INSERT INTO Tests (Id_commande,id_produit) Values ('" + text1.Text + "','" + text2.Text + "')";

                connection.Open();


                var dCmd = new SqlCommand(queryString, connection);
                dCmd.CommandType = CommandType.Text;
                dCmd.ExecuteNonQuery();
              int resultat = dCmd.ExecuteNonQuery();
                MessageBox.Show(resultat.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}