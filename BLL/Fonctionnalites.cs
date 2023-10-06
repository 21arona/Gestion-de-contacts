using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Fonctionnalites
    {

        public static void AjouterContacts(Contacts contacts)
        {
            ConnexionData.AjouterContact(contacts);
        }

        public static void ModifierContacts(Contacts contacts)
        {

        }

        public static void SupprimerContacts(string nom)
        {
            ConnexionData.SupprimerContact(nom);
        }

        public static void AfficherTousLesContacts(Contacts contacts)
        {
            ConnexionData.AfficherLesContacts(contacts);

        }

        public static void RechercherContacts(string nom)
        {
            ConnexionData.RechercherContact(nom);
        }


        public static void TrierContacts(Contacts contacts)
        {

        }

    }

}

