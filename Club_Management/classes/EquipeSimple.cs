using System;
using System.Collections.Generic;

namespace Projet_POO_MAMA_AZZI
{
    public class EquipeSimple 
    {
        public Membre Joueur { get; set; }
        public int VictoireS { get; set; }
        public int DefaiteS { get; set; }
        public int NulS { get; set; }

        public EquipeSimple()
        { }

        public EquipeSimple(Membre j, int victoire, int defaite, int nul)//Permet de choisir le membre que l'on veut pour une equipe simple
        {
            this.Joueur = j;
            this.VictoireS = victoire;
            this.DefaiteS = defaite;
            this.NulS = nul;
        }

        public List<Membre> CreationEquipeSimple()//Creation de l'equipe simple à travers une liste possedant un seul element, sous cette forme les attributs sont simples d'accès
        {

            Membre j1 = this.Joueur;
            List<Membre> l = new List<Membre>(1);
            l.Add(this.Joueur);

            return l;
        }

        public string AfficheEquipeSimple()//Permet d'afficher les informations d'un joueur
        {
            Membre j1 = this.Joueur;

            return j1.Nom + " " + " Nombre victoire : " + this.VictoireS + " Nombre Defaite : " + this.DefaiteS + " Nombre Match Nul : " + this.NulS;
        }
        

        

        
    }
}
