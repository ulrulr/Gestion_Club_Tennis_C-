using System;

namespace Projet_POO_MAMA_AZZI
{
    abstract public class Personne : Club,IComparable //La classe personne est abstraite car on se met dans le contexte du réel. On utlise aussi l'interface Icomparable car on en aura besoin dans la classe membre
    {
        private string sexe;
        private string nom;
        private string prenom;
        private string ville;
        private int age;
        private string numeroTel;


        public Personne()
        {
            this.sexe = "";
            this.nom = "";
            this.prenom = "";
            this.ville = "";
            this.age = 0;
            this.numeroTel = "";

        }

        public Personne(string sexe, string nom, string prenom, string ville, int age, string numeroTel)
        {
            this.sexe = sexe;
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
            this.age = age;
            this.numeroTel = numeroTel;
        }

        public string Sexe
        {
            get { return this.sexe; }
            set { this.sexe = value; }
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public string Ville
        {
            get { return this.ville; }
            set { this.ville = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string NumeroTel
        {
            get { return this.numeroTel; }
            set { this.numeroTel = value; }
        }

        public int CompareTo(object obj)//on va utliser l'interface IComparable pour faire des comparaisons, dans la classe fille (Membre)
        {
            return nom.CompareTo(obj);
        }

        public override string ToString()
        {
            return "Nom : " + this.nom + "/n" + "Prenom : " + this.prenom + "/n" + "Sexe :" + this.sexe + "/n" + "Adresse : " + this.ville + "/n" + "Age : " + this.age + " ans";
        }



    }
}