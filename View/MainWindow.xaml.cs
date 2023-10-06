using DAL;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool isLogin = ConnexionData.Login(txtBoxNomUtil.Text, txtBoxMdp.Password);
            if (txtBoxNomUtil.Text == string.Empty || txtBoxMdp.Password == string.Empty)
            {
                MessageBox.Show(" Veuillez remplir les cases vides ");
               
            }
           else if (isLogin)
            {
                //Connexion.Connexion1();
                this.Visibility = Visibility.Hidden;

                Menu menu = new Menu();
                menu.Visibility = Visibility.Visible;

            }

            else
            {
                MessageBox.Show("Mot de passe ou nom d'utilisateur incorect ");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBoxNomUtil.Text = string.Empty;
            txtBoxMdp.Password = string.Empty;
        }
    }
}
