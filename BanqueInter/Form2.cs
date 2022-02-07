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
    public partial class Form2 : Form
    {
        public Client c1;
        public List<Compte> comptes = new List<Compte>();
        public DataGridView info;
        public TextBox prenom;
        public TextBox nom;
        public TextBox adresse;
        Form3 fr = new Form3();
        public Form2()
        {
            InitializeComponent();
            this.info = dataGridView1;
            this.prenom = prenomBox;
            this.nom = nomBox;
            this.adresse = adrBox;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            if (dataGridView1.CurrentCell.Value.ToString() == "") MessageBox.Show("vous dever choisir un compte");
            else
            {
                int id = Int32.Parse(dataGridView1.CurrentCell.Value.ToString().Trim());
                fr.id = id;
                fr.c2 = this.c1;
                fr.comptes = this.comptes;
                SqlConnection c;
                String connString;
                connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banque;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                c = new SqlConnection(connString);
                c.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commande;
                SqlDataReader reader;
                string qr = "select solde from Compte where Compte.Id=" + id;
                commande = new SqlCommand(qr, c);
                reader = commande.ExecuteReader();
                string solde = "";
                while (reader.Read())
                {
                    solde = reader.GetValue(0).ToString();
                }
                fr.solde.Text = solde;
                reader.Close();

                c.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr.Show();
            this.Hide();
        }

    }
}
