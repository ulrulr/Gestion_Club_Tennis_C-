using System;
using System.Collections.Generic;

namespace Projet_POO_MAMA_AZZI
{
    public class EquipeDouble
    {
        public Membre Joueur1 { get; set; }
        public Membre Joueur2 { get; set; }
        public int VictoireD { get; set; }
        public int DefaiteD { get; set; }
        public int NulD { get; set; }


        public EquipeDouble()
        { }

        public EquipeDouble(Membre j1, Membre j2, int victoire, int defaite, int nul)
        {
            this.Joueur1 = j1;
            this.Joueur2 = j2;
            this.VictoireD = victoire;
            this.DefaiteD = defaite;
            this.NulD = nul;

        }

        public List<Membre> CreationEquipeDouble()
        {
            List<Membre> l = new List<Membre>(2);
            l.Add(this.Joueur1);
            l.Add(this.Joueur2);

            return l;
        }

        public string AfficheEquipeDouble()
        {
            Membre j1 = this.Joueur1;
            Membre j2 = this.Joueur2;

            return j1.Nom + ", " +j2.Nom + " Nombre victoire : " + this.VictoireD + " Nombre Defaite : " + this.DefaiteD + " Nombre Match Nul : " + this.NulD;
        }
    }
}
