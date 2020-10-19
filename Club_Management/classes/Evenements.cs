using System;
namespace Projet_POO_MAMA_AZZI
{
    public class Evenements
    {
        public string NatureEvenement { get; set; }
        public Entraineur Entraineur1 { get; set; }
        public Entraineur Entraineur2 { get; set; }


        public Evenements()
        {
        }

        public Evenements(string n, Entraineur e1, Entraineur e2)
        {
            this.NatureEvenement = n;
            this.Entraineur1 = e1;
            this.Entraineur2 = e2;

        }

        public void PossibiliteEvenement()//On verifie si un evnement est possible à organiser
        {
            if ((this.Entraineur1 != null) && (this.Entraineur2 != null))//Condition pour faire un evenement : il faut que deux entraineurs soit present
            {
                Console.WriteLine("Evenement peut etre organisé");
            }
            else
            {
                Console.WriteLine("Evenement ne peut etre organisé");
            }
        }
    }
}
