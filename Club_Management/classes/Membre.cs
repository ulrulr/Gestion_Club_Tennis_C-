using System;
using System.Collections.Generic;
using System.Collections;

namespace Projet_POO_MAMA_AZZI
{
    public class Membre : Personne
    {
       
        private int classement;
        private bool cotisation;
        private bool montantGestion;
      

        public Membre()
        {
            this.cotisation = false; //on les initialise a false car on part du principe que le membre n'a encore rien payé
            this.montantGestion = false;//on les initialise a false car on part du principe que le membre n'a encore rien payé


        }

        public Membre(string sexe, string nom, string prenom, string ville, int age, string numeroTel, int classement, bool cotisation, bool montantGestion) : base(sexe, nom, prenom, ville, age, numeroTel)
        {//le booleen nous donne une indication sur les frais de cotisation du membre, si il est true alors le membre a payé, si il est false, il n'a pas payé sa cotisation. De meme pour le booleen montantGestion qui indique si le joueur a paye ou non ses compétitions
            
            this.classement = classement;
            this.cotisation = cotisation; 
            this.montantGestion = montantGestion;
            
        }

       
        public int Classement
        {
            get { return classement; }
            set { this.classement = value; }
        }

        public bool Cotisation
        {
            get { return this.cotisation; }
            set { this.cotisation = value; }
        }

        public bool MontantGestion
        {
            get { return this.montantGestion; }
            set { this.montantGestion = value; }
        }


        public string Paiement(Club c) //Methode qui permet de faire payer la cotisation au joueur selon son profil
        {
            int p = 0;
            string s = "";
            if (this.Ville == c.LieuDuClub)//On verifie si l'adresse du joueur est la meme que celle du club, pour adapter les frais de cotisations
            {
                if(this.Age < 18)//On vérifie si le joueur est mineur ou pas
                {
                    p = 130;
                    s = this.Nom + " paye " + p + " € de cotisations";
                }
                
                else
                {
                    p = 200;
                    s = this.Nom + " paye " + p + " € de cotisations";
                }

            }
            else//Le joueur n'habite pas dans la meme ville que le club, ainsi il devrait payer une cotisation plus chère
            {
                if(this.Age < 18)
                {
                    p = 180;
                    s = this.Nom + " paye " + p + " € de cotisations";

                }
                else
                {
                    p = 280;
                    s = this.Nom + " paye " + p + " € de cotisations";
                }

            }

            this.cotisation = true;//On le met True pour indiquer que le joueur a payé la cotisation 

            return s;
        }

        public string VerifCotisation()//On verifie si le membre a payé sa cotisation, cela permet de voir s'il peut jouer ou non
        {
            
            string s = "";
            if (this.cotisation == true)//Si le booleen vaut true, cela signifie que le joueur a déja payé sa cotisation
            {
                s = this.Nom + " a bien paye sa cotisation ";
            }
            else//Le booleen vaut False, donc le joueur n'a encore rien payé
            {
                s = this.Nom + " n'a pas paye sa cotisation ";
            }

            return s;               
        }

        public string PaiementMontantGestion(List<Competition> liste)//En entrée c'est la liste de compétitions pour un membre, cette methode permet de calculer les frais totaux en competition et en gestion du membre
        {
            int prix_tot = 0;
            string s = "";

            foreach(Competition c in liste)
            {
                prix_tot = prix_tot + c.Prix;//on additionne le cout de toutes les competions ou le joueur va participer
            }
            prix_tot = prix_tot + 20;//On ajoute aussi les frais de gestions qui s'elevent à 20€

            s = "Le cout total des frais de competions et de gestion s'eleve à " + prix_tot + " pour " + this.Nom;

            this.montantGestion = true;//On le met True pour indiquer que le joueur a payé les frais de competitions et gestions

            return s;
        }

        public string VerifMontantGestion()//On verifie si le membre a payé sa cotisation, cela permet de voir s'il peut participer aux competitions
        {

            string s = "";
            if (this.montantGestion == true)
            {
                s = this.Nom + " a bien paye les frais de competitions et gestions ";
            }
            else
            {
                s = this.Nom + " n'a pas paye les frais de competitions et gestions ";
            }

            return s;
        }

        public void ModifVille()//Cette methode permet de modifier l'adresse d'un membre
        {
            string s = "";
            Console.WriteLine("Nouvelle ville de résidence ?");
            s = Console.ReadLine();
            this.Ville = s;

        }

        public void ModifTel()//Cette methode permet de modifier le numero de telephone d'un membre
        {
            string s = "";
            Console.WriteLine("Veuillez entrer votre nouveau n° de telephone");
            s = Console.ReadLine();
            this.NumeroTel = s;

        }

        public void AfficheMembreClassement(List<Membre> liste)//Cette methode permet d'afficher les membres avec leurs classements
        {
            foreach(Membre n in liste)
            {
                Console.WriteLine("Nom : " + n.Nom + " Classement : " + n.classement);
            }

        }

        public void AfficheMembreAlpha(List<Membre> liste)//Cette methode permet d'afficher les membres dans l'ordre alphabetique
        {

            List<string> tab = new List<string>(liste.Capacity);//On cree une liste de caractere possedant la meme taille que la liste de membre
            foreach (Membre n in liste)
            {
                tab.Add(n.Nom); //On remplit la liste de caractere vide avec  les noms de chaque membre
            }

            tab.Sort();//On trie la liste de nom par ordre alphabetique, cette methode est utilisabl grace à l'interface IComparable que l'on a mis avec la classe Personne

            foreach(string n in tab)
            {
                Console.WriteLine(n);//enfin, on affiche les noms de chaque membre par ordre alphabetique
            }

        }

        public void AfficheMembreSexe(List<Membre> liste)//On affiche les membres selon leurs sexes
        {
            foreach (Membre n in liste)
            {
                Console.WriteLine("Nom : " + n.Nom + " Sexe : " + n.Sexe);
               
            }

        }

        public void AfficheMembreParticipation(List<Membre> liste)//On affiche les membres selon particiations aux competitions ou loisir
        {
            foreach (Membre n in liste)
            {
                if (n.MontantGestion == true)//On considere qu'un memebre ayant regle les frais de competition et de gestion participent aux competitions et ceux qui ne l'ont pas payé sont automatiquement mis en loisir
                {
                    Console.WriteLine("Nom : " + n.Nom + " Participation : Competition");
                }
                else//Le membre qui ne regle pas ses cotisations est affecté automatiquement au jeu Loisir
                {
                    Console.WriteLine("Nom : " + n.Nom + " Participation : Loisir");
                }

            }

        }

        public void RelanceAdhesion(List<Membre> liste)//Ce programme permet de savoir si les membres ont réglés leurs cotisations ou non
        {
            foreach (Membre n in liste)
            {
                if (n.cotisation == true)
                {
                    Console.WriteLine("Nom : " + n.Nom + " Cotisation : OUI");
                }
                else
                {
                    Console.WriteLine("Nom : " + n.Nom + " Participation : NON");
                }

            }
        }

        public Membre InscriptionMembre()//Inscription d'un membre
        {
            Membre nouv = null;
            Console.WriteLine("sexe ? (F(femme) ou H(homme)");//On demande à la secretaire d'entrer le sexe du membre

            string sexe = "";
            do
            {
                sexe = Console.ReadLine();
                

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



            Console.WriteLine("frais de competition et gestion reglé ? (oui ou non)");
            string a = " ";
            do
            {
                sexe = Console.ReadLine();
                

            } while ((a == "oui") || (a == "non"));
            bool k = false;//le booleen permet de savoir si les frais ont été réglés ou non, car s'il ne les a pas payé il ne peut pas participer à la compétition
            if (a == "oui")
            {
                k = true;
            }

            
           

            nouv = new Membre(sexe, nom, prenom, ville, age, num, classe, b, k);//Creation du nouveau membre

            return nouv;


        }

        public override string ToString()
        {
            return base.ToString() ;
        }

        
    }
}
