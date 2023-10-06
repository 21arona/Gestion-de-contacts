using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for Afficher.xaml
    /// </summary>
    public partial class Afficher : Window
    {
        public Afficher()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connexion = new SqlConnection(ConnexionData.connectionString))
            {
                connexion.Open();
                string requete = "select * from contacts";
                SqlCommand cmd = new SqlCommand(requete, connexion);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable("contacts");
                dp.Fill(tb);
                dg.ItemsSource = tb.DefaultView;
                dp.Update(tb);
                connexion.Close();

            }
        }
    }
}
