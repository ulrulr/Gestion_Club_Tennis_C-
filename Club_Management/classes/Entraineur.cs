using System;
namespace Projet_POO_MAMA_AZZI
{
    public class Entraineur : Membre //Un entraineur est aussi un membre du club
    {
        private string statut;
        private int nbreDeCours;

        public Entraineur()
        { }

        public Entraineur(string sexe, string nom, string prenom, string ville, int age, string numeroTel, int classement, bool cotisation, bool montantGestion, string statut, int cours) : base(sexe, nom, prenom, ville, age, numeroTel, classement, cotisation, montantGestion)
        {
            this.statut = statut;
            this.nbreDeCours = cours;
        }

        public string Statut
        {
            get { return this.statut; }
            set { this.statut = value; }
        }

        public int NbreDeCours
        {
            get { return this.nbreDeCours; }
            set { this.nbreDeCours = value; }
        }

        public Entraineur InscriptionEntraineur()//Inscription d'un entraineur
        {
            Entraineur e = null;
            Console.WriteLine("sexe ? (F(femme) ou H(homme)");//On demande à la secretaire d'entrer le sexe du membre

            string sexe = "";
            do
            {
                sexe = Console.ReadLine();
               

            } while ((sexe == "G") || (sexe == "F"));//On utilise do while afin d'etre sur qu'une donnée exacte sera donnée

            Console.WriteLine("salarie ou independant");//On demande à la secretaire d'entrer le sexe du membre

            string stat = "";
            do
            {
                stat = Console.ReadLine();
                

            } while ((stat == "salarie") || (stat == "independant"));//On utilise do while afin d'etre sur qu'une donnée exacte sera donnée
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

            Console.WriteLine("Classement ?");
            int classe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cotisation ? (oui ou non");
            string s = "";
            do
            {
                s = Console.ReadLine();
               
            } while ((s == "oui") || (s == "non"));
            bool b = false;//le booleen permet de savoir si les frais ont été réglés ou non, car s'il ne les a pas payé il ne peut pas jouer
            if (s == "oui")
            {
                b = true;
            }

            int n = 0;
            Console.WriteLine("Nombre de cours");
            n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("frais de competition et gestion reglé ? (oui ou non)");
            string a = " ";
            do
            {
                sexe = Console.ReadLine();
                Console.WriteLine("oui ou non");

            } while ((a == "oui") || (a == "non"));
            bool k = false;//le booleen permet de savoir si les frais ont été réglés ou non, car s'il ne les a pas payé il ne peut pas participer à la compétition
            if (a == "oui")
            {
                k = true;
            }

            e = new Entraineur(sexe, nom, prenom, ville, age, num, classe, b, k,stat,n);//Creation du nouveau membre

            return e;
        }

        public override string ToString()
        {
            return base.ToString() + "Statut : "+ this.statut;
        }
    }
}
