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
using BanqueApp;

namespace BanqueInter
{
    public partial class Form1 : Form
    {
        public Client c ;
        public List<Compte> comptes = new List<Compte>();
        Form2 f = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string mdp = passBox.Text;
            SqlConnection c;
            String connString;
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banque;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            c = new SqlConnection(connString);
            c.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand commande;
            SqlDataReader reader;
            string qr = "select * from Client";
            commande = new SqlCommand(qr, c);
            reader = commande.ExecuteReader();
            string idClient = "";
            int test = 0;
            while (reader.Read())
            {
                if ((reader.GetValue(4).ToString().Trim()==login) & (reader.GetValue(5).ToString().Trim()==mdp))
                {
                    test = 1;
                    idClient = reader.GetValue(0).ToString().Trim();
                    this.c = new Client(reader.GetValue(1).ToString().Trim(), reader.GetValue(2).ToString().Trim(), reader.GetValue(3).ToString().Trim(), reader.GetValue(4).ToString().Trim(), reader.GetValue(5).ToString().Trim());

                }
            }
            reader.Close();
            //dataGridView1.DataSource = l;
            if (test == 0) MessageBox.Show("wrong informations\n");
            else
            {
                SqlDataReader reader1;
                string qr1 = "select * from Compte where Compte.idClient=" + idClient;
                SqlCommand commande1 = new SqlCommand(qr1, c);
                reader1 = commande1.ExecuteReader();
                
                while (reader1.Read())
                {
                    Compte cmp=new Compte(Double.Parse(reader1.GetValue(2).ToString().Trim()), this.c, Int32.Parse(reader1.GetValue(1).ToString().Trim()));
                    //this.c.ajouter_compte(cmp);
                    this.comptes.Add(cmp);
                }
                reader1.Close();
                DataTable table = new DataTable();
                table.Clear();
                adapter.SelectCommand = commande1;
                adapter.Fill(table);
                f.info.DataSource = table;
                f.prenom.Text = this.c.getPrenom();
                f.nom.Text = this.c.getNom();
                f.adresse.Text = this.c.getAdresse();
                f.c1 = this.c;
                f.comptes = this.comptes;
                f.Show();
                this.Hide();


            }
            c.Close();
        }
    }
}
