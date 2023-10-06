using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Contacts
    {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Adresse { get; set; }
            public string City { get; set; }
            public string Email { get; set; }
            public string CodePostal { get; set; }
            public string Tel { get; set; }
            public string DateNaissance { get; set; }
            public string NomUtilisateur { get; set; }

            public Contacts(int id, string nom, string prenom, string adresse, string city, string email, string codePostal, string tel, string dateNaissance, string nomUtilisateur)
            {
                this.Id = id;
                this.Nom = nom;
                this.Prenom = prenom;
                this.Adresse = adresse;
                this.City = city;
                this.Email = email;
                this.CodePostal = codePostal;
                this.Tel = tel;
                this.DateNaissance = dateNaissance;
                this.NomUtilisateur = nomUtilisateur;
            }

            public override string ToString()
            {
                return $"{this.Id} - {this.Nom} - {this.Prenom} - {this.Adresse} - {this.City} - {this.Email} - {this.CodePostal} - {this.Tel} - {this.DateNaissance} - {this.NomUtilisateur}";
            }
        
    }
}
