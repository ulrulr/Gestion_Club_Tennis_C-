using System;
namespace Projet_POO_MAMA_AZZI
{
    public class Personnel : Personne
    {
        private string fonction { get; set; }

        public Personnel()
        { }

        public Personnel(string sexe, string nom, string prenom, string ville, int age, string numeroTel, string lieuDeNaissance, string fonction) : base(sexe, nom, prenom, ville, age, numeroTel)
        {
            this.fonction = fonction;
        }



    }
}
