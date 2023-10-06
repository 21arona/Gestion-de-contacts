using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnexionData
    {

        public const string connectionString = @"Data Source=751FJW2\SQLEXPRESS;" +
           "Initial Catalog=bdContacts;" +
           "Integrated Security=true;" +
           "Connect Timeout=5";

        public static void Connexion1()
        {

            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
            }
            //se deconnecte ici
        }

        public static int NombreDeConnexions = 0;

        public static void compteurConnexions()
        {
            while (NombreDeConnexions < 1000)
            {
                Connexion1();
                NombreDeConnexions++;

            }
        }

        public static void AjouterContact(Contacts contacts)
        {
            Connexion1();
            int id = contacts.Id;
            string nom = contacts.Nom;
            string prenom = contacts.Prenom;
            string telephone = contacts.Tel;
            string codePostal = contacts.CodePostal;
            string dateNaissance = contacts.DateNaissance;
            string ville = contacts.City;
            string mail = contacts.Email;
            string adresse = contacts.Adresse;
            string nomUtilisateur = contacts.NomUtilisateur;

            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();

                using (SqlCommand commande = connexion.CreateCommand())
                {
                    commande.CommandText = @"insert into contacts(Id,Nom,Prenom,Adresse,City,Email,CodePostal,Telephone,DateNaissance,NomUtilisateur)";
                    commande.Parameters.AddWithValue("@Id", id);
                    commande.Parameters.AddWithValue("@Nom", nom);
                    commande.Parameters.AddWithValue("@Prenom", prenom);
                    commande.Parameters.AddWithValue("@Adresse", adresse);
                    commande.Parameters.AddWithValue("@City", ville);
                    commande.Parameters.AddWithValue("@Email", mail);
                    commande.Parameters.AddWithValue("@CodePostal", codePostal);
                    commande.Parameters.AddWithValue("@Tel", telephone);
                    commande.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                    commande.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                    commande.ExecuteNonQuery();

                }

            }
        }

        public static void ModifierContact(Contacts contacts)
        {

        }
        public static bool SupprimerContact(string nom)
        {
            Connexion1();
            bool suppContact = false;
            try
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    using (SqlCommand commande = connexion.CreateCommand())
                    {
                        commande.CommandText = @"delete from contacts WHERE nom = @Nom";
                        commande.Parameters.Add(new SqlParameter("@Nom", nom));
                        commande.ExecuteNonQuery();
                    }
                }
                suppContact = true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return suppContact;
        }

        public static void AfficherLesContacts(Contacts contacts)
        {
            Connexion1();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                using (SqlCommand commande = connexion.CreateCommand())
                {
                    string requete = "select * from contacts";
                    SqlCommand cmd = new SqlCommand(requete, connexion);
                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataTable tb = new DataTable("contacts");
                    dp.Fill(tb);
                    //dg.ItemsSource = tb.DefaultView;
                    dp.Update(tb);
                    connexion.Close();
                }
            }

        }


        public static List<Contacts> RechercherContact(string nom)
        {
            List<Contacts> contacts = new List<Contacts>();
            Connexion1();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                using (SqlCommand commande = connexion.CreateCommand())
                {
                    commande.CommandText = @"SELECT * FROM contacts WHERE nom =@Nom ";
                    commande.Parameters.Add(new SqlParameter("@Nom", nom));
                }
            }
            return contacts;
        }

        public static bool Login(string nomUtilisateur, string motDePasse)
        {
            bool isLogin = false;
            Connexion1();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                connexion.Open();
                using (SqlCommand commande = connexion.CreateCommand())
                {
                    commande.CommandText = @"SELECT from utilisateurs WHERE nomUtilisateur= @NomUtilisateur AND motDepasse = @MotDePasse";
                    commande.Parameters.Add(new SqlParameter("@NomUtilisateur", nomUtilisateur));
                    commande.Parameters.Add(new SqlParameter("@MotDePasse", motDePasse));
                    isLogin = true;
                }
            }
            return isLogin;
        }

    }
}
