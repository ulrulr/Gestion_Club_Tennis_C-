using System;
using System.Collections.Generic;
using System.Linq;

namespace Projet_POO_MAMA_AZZI
{
    public class Competition : Club
    {
        public int Prix { get; set; }
        private int NbreDeMatch { get; set; }
        private int AgeAutorise { get; set; }
        private DateTime DateDeRencontre { get; set; }
        private List<EquipeSimple> ListeEquipeSimple { get; set; }
        private List<EquipeDouble> ListeEquipeDouble { get; set; }



        public Competition()
        {

        }

        public Competition(int Prix, int nbreDeMatch, DateTime dateDeRencontre, int ageAutorise, List<EquipeSimple> ListeEquipeSimple, List<EquipeDouble> ListeEquipeDouble)//Creation d'une competition avec tous les caractéristiques
        {
            this.Prix = Prix;
            this.NbreDeMatch = nbreDeMatch;
            this.DateDeRencontre = dateDeRencontre;
            this.AgeAutorise = ageAutorise;
            this.ListeEquipeDouble = ListeEquipeDouble;
            this.ListeEquipeSimple = ListeEquipeSimple;

        }

        public void InfoEquipesCompetiton()//Cette Methode permet de donner les informations sur les membres qui participent aux competitions
        {

            //On commence par afficher les membres des equipes simples
            Console.WriteLine("Equipes simples participantes");
            int i = 1;//Compteurs pour afficher le numero de l'equipe
            List<Membre> l1 = new List<Membre>();//On cree une liste de membre 
            
            foreach(EquipeSimple a in this.ListeEquipeSimple)//Dans toutes les equipes simple presente dans la competion, on prend chaque joueur un par un qu'on va mettre dans la liste de membre
            {
                l1.Add(a.Joueur);
            }

            foreach(Membre b in l1)//Une fois les joueurs placés dans la liste de membre, à l'aide de l'attribut on affiche le nom de chaque joueurs
            {
                Console.WriteLine("Equipe "+i+" : "+ b.Nom);
                i++;
            }

            //On affiche les membres des equipes doubles
            Console.WriteLine("Equipes doubles participantes");
            int j = 1;//Compteurs pour afficher le numero de l'equipe
            List<Membre> l2 = new List<Membre>();

            foreach (EquipeDouble a in this.ListeEquipeDouble)
            {
                l2.Add(a.Joueur1);
                l2.Add(a.Joueur2);
            }

            for(int k=0;i<=((l2.Capacity)/2)-1 ;k++)//On adapte les bornes aux index de la boucle
            {
                Console.WriteLine("Equipe "+j + l2.ElementAt(2*k) + " : " + l2.ElementAt(2*k+1));//Une equipe represente 2 membres placés à la suite dans la liste, on a donc adapté les indices de facon à ne pas avoir deux fois le meme membre dans plusieurs équipes
                
                j++;//On passe à l'equipe suivante
            }


        }

        public Membre InscriptionMembre()
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


        public Competition AjoutCompetition()//Cette methode permet la creation d'une competition
        {
            //On demande à l'utilsateur d'entrer toutes les informations pour les différents attributs
            Console.WriteLine("Afficher le prix");
            Prix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Afficher le nombre de matchs");
            NbreDeMatch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Afficher Age Autorisé");
            AgeAutorise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Afficher la date de rencontre");
            DateDeRencontre = DateTime.Parse(Console.ReadLine());


            int NbreEquipeSimple;
            NbreEquipeSimple = Convert.ToInt32(Console.ReadLine());//Pour savoir le nombre d'équipe simples qui participeront à la compétition

            int NbreEquipeDouble;
            NbreEquipeDouble = Convert.ToInt32(Console.ReadLine());//Pour savoir le nombre d'équipe doubles qui participeront à la compétition

            List<EquipeSimple> nouv1 = new List<EquipeSimple>(NbreEquipeSimple);//On cree une liste d'equipe simple avec le bon nombre d'équipe
            List<EquipeDouble> nouv2 = new List<EquipeDouble>(NbreEquipeDouble);// On cree une liste d'equipe double avec le bon nombre d'équipe

            for (int i = 0; i < NbreEquipeSimple; i++)//la boucle va parcourir la liste d'equipe simple afin d'y inscrire chaque membre
            {
                Console.WriteLine("Inserer membre");
                Membre joueur1 = InscriptionMembre();
               
                EquipeSimple eq = new EquipeSimple(joueur1, 0, 0, 0);//on cree donc l'equipe simple ( 1 joueur), avec 0 victoires et 0 defaites car il n'a pas encore joué
                nouv1.Add(eq);
            }

            for (int j = 0; j < NbreEquipeDouble; j++)//on reitere ce qui a été fait plus haut avec les équipes doubles
            {
                Console.WriteLine("Inserer premier Membre");
                Membre joueur1bis = InscriptionMembre();

                Console.WriteLine("Inserer deuxieme Membre");
                Membre joueur2bis = InscriptionMembre();
                

                EquipeDouble eq1 = new EquipeDouble(joueur1bis, joueur2bis, 0, 0, 0);//De meme, on initialise tout à 0 car le tournoi n'a pas encore eu lieu
                nouv2.Add(eq1);

            }

            Competition nouveau = new Competition(Prix, NbreDeMatch, DateDeRencontre, AgeAutorise, nouv1, nouv2);//Enfin on crée la compétition
            return nouveau;

        }


        static void AfficheMatchScoreEqSimple(EquipeSimple e1, EquipeSimple e2)//Cette methode affiche le score d'un match d'equipe simple
        {
            Membre j1 = e1.Joueur;
            Membre j2 = e2.Joueur;
            Random aleatoire = new Random();//On imprte cette fonction qui nous permettra d'obtenir des entiers de facon aléatoire
            int score1 = aleatoire.Next(7);//au tennis le score va de 1 à 6, donc on va donner de facon  aleatoire un score pour chaque équipe
            int score2 = aleatoire.Next(7);

            Console.WriteLine(j1.Nom +" : " + score1 +" "+ "n\"" + j2.Nom + " : " + score2);
            if(score1 > score2)//Si l'equipe 1 gagne
            {
                
                e1.VictoireS++;//On augmente le nombre de victoire de l'equipe 1 d'un point
                e2.DefaiteS++;//On augmente le nombre de defaite de l'equipe 2 d'un point
            }
            else if(score1 == score2)//Si il y a egalite
            {
                e1.NulS++;//On augmente le nombre de match nul de l'equipe 1 d'un point
                e2.NulS++;//On augmente le nombre de match nul de l'equipe 2 d'un point

            }
            else//Si l'equipe 2 gagne
            {
                e2.VictoireS++;//On augmente le nombre de defaite de l'equipe 1 d'un point
                e1.DefaiteS++;//On augmente le nombre de victoire de l'equipe 2 d'un point
            }
        }

        static void AfficheMatchScoreEqDouble(EquipeDouble e1, EquipeDouble e2)//Cette methode affiche le score d'un match d'equipe double, c'est la meme que la precedente mais pour des equipe double en parametre
        {
            Random aleatoire = new Random();
            int score1 = aleatoire.Next(7);
            int score2 = aleatoire.Next(7);

            Console.WriteLine("Equipe 1 : " + score1 + "n\"" + " Equipe 2 : " + score2);

            if (score1 > score2)
            {
                e1.VictoireD++;
                e1.DefaiteD++;

            }
            else if (score1 == score2)
            {
                e1.NulD++;
                e2.NulD++;

            }
            else
            {
                e2.VictoireD++;
                e2.DefaiteD++;
            }
        }
    }
}
