using DAL;
using MODEL;
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
    /// Interaction logic for Ajouter.xaml
    /// </summary>
    public partial class Ajouter : Window
    { 
        public Ajouter()
        {
            InitializeComponent();
           
        }

    private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contacts contact = new Contacts(int.Parse(txtBoxId.Text), txtBoxNom.Text, txtBoxPrenom.Text, txtBoxAdresse.Text, txtBoxCity.Text, txtBoxEmail.Text, txtBoxCodePost.Text, txtBoxTel.Text, txtBoxDateNaiss.Text, txtBoxUtilisateur.Text);
            ConnexionData.AjouterContact(contact);
            MessageBox.Show(" Ajoute avec success");
        }

    private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

            Menu menu = new Menu();
            menu.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
