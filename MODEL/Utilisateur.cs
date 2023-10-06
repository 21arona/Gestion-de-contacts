using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    class Utilisateur
    {
        public string Nom { get; }
        public string Prenom { get; }
        public string NomUtilisateur { get; }
        public string MotDePasse { get; }

        public Utilisateur(string nom, string prenom, string nomUtilisateur, string motDePasse)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.NomUtilisateur = nomUtilisateur;
            this.MotDePasse = motDePasse;

        }
    }
}
