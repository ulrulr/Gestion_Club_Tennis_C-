using System;
namespace Projet_POO_MAMA_AZZI
{
    public class Salarie : Personne
    {

        private string InformationBancaire { get; set; }
        private float Salaire { get; set; }
        private DateTime DateEntree { get; set; }
        private string Poste { get; set; }
        private Club Club { get; set; }

        public Salarie()
        {
        }

        public Salarie(string sexe, string nom, string prenom, string ville, int age, string numeroTel, string information, float salaire, DateTime dateEntree, string poste) : base(sexe, nom, prenom, ville, age, numeroTel)
        {
            this.InformationBancaire = information;
            this.Salaire = salaire;
            this.DateEntree = dateEntree;
            this.Poste = poste;
            
        }

        public Salarie InscriptionSalarie()//On cree un salarie
        {
            Salarie nouv = null;
            Console.WriteLine("sexe ? (F(femme) ou H(homme)");//On demande à la secretaire d'entrer le sexe du membre

            string sexe = "";
            do
            {
                sexe = Console.ReadLine();
                Console.WriteLine("F (femme) ou H (homme)");

            } while ((sexe == "G") || (sexe == "F"));//On utilise do while afin d'etre sur qu'une donnée exacte sera donnée


            Console.WriteLine("nom ?");
            string nom = Console.ReadLine();

            Console.WriteLine("prenom ?");
            string prenom = Console.ReadLine();

            Console.WriteLine("ville ?");
            string ville = Console.ReadLine();

            Console.WriteLine("age ?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero de telephone ?");
            string num = Console.ReadLine();

            Console.WriteLine("coordonnees bancaire ?");
            string cb =Console.ReadLine();

            Console.WriteLine("Salaire");
            float salaire = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Date de naissance ?");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("poste ?");
            string poste = Console.ReadLine();

          


            nouv = new Salarie(sexe, nom, prenom, ville, age, num, cb, salaire, date, poste);

            return nouv;
        }
        public override string ToString()
        {
            return base.ToString() + " Information bancaire : " + this.InformationBancaire + " Salaire : " + this.Salaire + " Date d'entree : " + this.DateEntree + " Poste occupé : " + this.Poste +"club : "+(this.Club).NomDuClub ;
        }

    }
}
