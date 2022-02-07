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
    public partial class Form3 : Form
    {
        public Client c2;
        public Compte comp;
        public List<Compte> comptes = new List<Compte>();
        public int id;
        private int compt ;
        public TextBox solde;
        public Form3()
        {
            InitializeComponent();
            this.solde = adrBox;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label7Transfert.Hide();
            this.labelTransfert.Hide();
            this.textBoxTransfert.Hide();
        }

        private void adrBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection c;
            String connString;
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Banque;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            c = new SqlConnection(connString);
            c.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            float compte2_old_solde = 0;
            double montant=0;
            int test = 0;
            int existe = 0;
            string type = "";
            //Compte comp;
            SqlDataReader reader;
            string q = "select numCompte,solde from Compte where Compte.Id=" + this.id;
            SqlCommand commande2 = new SqlCommand(q, c);
            reader = commande2.ExecuteReader();
            int num=0;
            float soldeCompte = 0;
            int identifiant = 0;
            while (reader.Read())
            {

               num=Int32.Parse(reader.GetValue(0).ToString().Trim());
                soldeCompte = float.Parse(reader.GetValue(1).ToString().Trim());
                


            }
            reader.Close();
            
            for (int i = 0; i < this.comptes.Count(); i++)
            {
                if (this.comptes[i].num_equals(num))
                {
                    Compte comp = this.comptes[i];
                    identifiant = i;
                }
            }
            if (textBox1.Text == "") { MessageBox.Show("vous dever indiquer le montant de l'operation"); }
            else
            {
                
                montant = Double.Parse(textBox1.Text);
                test = 1;
               
                if (radioret.Checked)
                {
                    //Compte cp = comp;
                    type = "retrait";
                    OperationR op = new OperationR(montant,comp);
                    this.comptes[identifiant].ajouter_operation(op);
                }
                else if (radiodep.Checked)
                {
                    type = "virement";
                    OperationV op = new OperationV(montant, comp);
                    this.comptes[identifiant].ajouter_operation(op);
                }
                else if(radiotrn.Checked)
                {
                    type = "transfert";
                    if (textBoxTransfert.Text == "")
                    {
                        MessageBox.Show("vous dever indiquer le numero du compte");
                    }
                    else
                    {
                        int iden = 0;
                        int num_compte = Int32.Parse(this.textBoxTransfert.Text);
                        for(int i=0;i<this.comptes.Count();i++)
                        {
                            if (this.comptes[i].num_equals(num_compte))
                            {
                                iden = i;
                            }
                        }
                        SqlDataReader reader1;
                        string qr1 = "select * from Compte";
                        SqlCommand commande1 = new SqlCommand(qr1, c);
                        reader1 = commande1.ExecuteReader();
                        Compte cmp;
                        while (reader1.Read())
                        {
                            if (Int32.Parse(reader1.GetValue(1).ToString().Trim()) == num_compte)
                            {
                                compte2_old_solde = (float)Double.Parse(reader1.GetValue(2).ToString().Trim());
                                existe = 1;
                                cmp = new Compte(Double.Parse(reader1.GetValue(2).ToString().Trim()), this.c2, num_compte);
                                this.comptes[iden].transfert(cmp, montant);
                                OperationR op = new OperationR(montant, comp);
                                this.comptes[identifiant].ajouter_operation(op);
                                OperationV op2 = new OperationV(montant, cmp);
                                cmp.ajouter_operation(op);
                                for(int i = 0; i < this.comptes.Count(); i++)
                                {
                                    if (this.comptes[i].num_equals(num_compte))
                                    {
                                        this.comptes[i] = cmp;
                                    }
                                }
                            }
                        }
                        reader1.Close();
                        if (existe == 0)
                        {
                            MessageBox.Show("erreur ce compte n'existe pas");
                            
                        }
                       
                    }
                }
                else
                {
                    test = 0;
                    MessageBox.Show("vous dever indiquer le type de l'operation");
                }
            }
            if (test == 1||existe==1)
            {
                //SqlDataReader reader1;
                //string qr1 = "select MAX(Id) as Id from Operation";
                SqlCommand commande1 = c.CreateCommand();
                commande1.CommandText = "SELECT MAX(Id) FROM Operation";
                if (commande1.ExecuteScalar().ToString() != "") this.compt = Convert.ToInt32(commande1.ExecuteScalar());
                else this.compt = 0;
                //reader1 = commande1.ExecuteReader();

                // while (reader1.Read())
                //{
                //   this.compt = Int32.Parse(reader1.GetValue(0).ToString().Trim());
                //}
                //reader1.Close();
                if (type == "virement"&&test==1)
                {
                    float nouv_solde = (float)montant + soldeCompte;
                    this.adrBox.Text = nouv_solde.ToString(); 
                    string query = "INSERT INTO Operation (Id,idCompte,montant,type) VALUES(" + ++compt + "," + this.id + "," + montant + "," + '\'' + type.ToString() + '\'' + ")";
                    SqlCommand commande = new SqlCommand(query, c);
                    adapter.InsertCommand = commande;
                    adapter.InsertCommand.ExecuteNonQuery();
                    string query2 = "update Compte set solde=" + nouv_solde + " where Id=" + this.id;
                    SqlCommand command2 = new SqlCommand(query2, c);
                    adapter.UpdateCommand = command2;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("operation finie");
                }
                else if (type == "retrait"&&test==1)
                {
                    float nouv_solde = soldeCompte- (float)montant;
                    this.adrBox.Text = nouv_solde.ToString();
                    string query = "INSERT INTO Operation (Id,idCompte,montant,type) VALUES(" + ++compt + "," + this.id + "," + montant + "," + '\'' + type.ToString() + '\'' + ")";
                    SqlCommand commande = new SqlCommand(query, c);
                    adapter.InsertCommand = commande;
                    adapter.InsertCommand.ExecuteNonQuery();
                    string query2 = "update Compte set solde=" + nouv_solde + " where Id=" + this.id;
                    SqlCommand command2 = new SqlCommand(query2, c);
                    adapter.UpdateCommand = command2;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("operation finie");
                }
                else if(type=="transfert"&&existe==1&&test==1)
                {
                    float nouv_solde = soldeCompte - (float)montant;
                    this.adrBox.Text = nouv_solde.ToString();
                    string query = "INSERT INTO Operation (Id,idCompte,montant,type) VALUES(" + ++compt + "," + this.id + "," + montant + "," + '\'' + type.ToString() + '\'' + ")";
                    SqlCommand commande = new SqlCommand(query, c);
                    adapter.InsertCommand = commande;
                    adapter.InsertCommand.ExecuteNonQuery();
                    string query2 = "update Compte set solde=" + nouv_solde + " where Id=" + this.id;
                    SqlCommand command2 = new SqlCommand(query2, c);
                    adapter.UpdateCommand = command2;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    float nouv_solde_compte2 = compte2_old_solde + (float)montant;
                    string query3 = "update Compte set solde=" + nouv_solde_compte2 + " where numCompte=" + Int32.Parse(this.textBoxTransfert.Text);
                    SqlCommand command3 = new SqlCommand(query3, c);
                    adapter.UpdateCommand = command3;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("operation finie");
                }
                for(int i = 0; i < this.comptes.Count(); i++)
                {
                    this.c2.ajouter_compte(this.comptes[i]);
                }
                
            }
        }

        private void radiotrn_CheckedChanged(object sender, EventArgs e)
        {
            this.label7Transfert.Show();
            this.labelTransfert.Show();
            this.textBoxTransfert.Show();
        }

        

        private void radioret_CheckedChanged(object sender, EventArgs e)
        {
            this.label7Transfert.Hide();
            this.labelTransfert.Hide();
            this.textBoxTransfert.Hide();
        }

        private void radiodep_CheckedChanged_1(object sender, EventArgs e)
        {
            this.label7Transfert.Hide();
            this.labelTransfert.Hide();
            this.textBoxTransfert.Hide();
        }
    }
}
