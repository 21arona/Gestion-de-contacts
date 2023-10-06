using System;
using System.Collections.Generic;
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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //AjouterVM.Ajouter();

           // Connexion.Connexion1();
            this.Visibility = Visibility.Hidden;

            Ajouter ajouter = new Ajouter();
            ajouter.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //AjouterVM.Ajouter();

            // Connexion.Connexion1();
            this.Visibility = Visibility.Hidden;

            Modifier modifier = new Modifier();
            modifier.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //AjouterVM.Ajouter();

            // Connexion.Connexion1();
            this.Visibility = Visibility.Hidden;

            Supprimer supprimer = new Supprimer();
            supprimer.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //AjouterVM.Ajouter();

            // Connexion.Connexion1();
            this.Visibility = Visibility.Hidden;

            Afficher afficher = new Afficher();
            afficher.Visibility = Visibility.Visible;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //AjouterVM.Ajouter();

            // Connexion.Connexion1();
            this.Visibility = Visibility.Hidden;

            Rechercher rechercher = new Rechercher();
            rechercher.Visibility = Visibility.Visible;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //AjouterVM.Ajouter();

            // Connexion.Connexion1();
            this.Visibility = Visibility.Hidden;

            Trier trier = new Trier();
            trier.Visibility = Visibility.Visible;
        }
    }
}
