using System;
namespace Projet_POO_MAMA_AZZI
{
    public class Club
    {
        public string lieuDuClub;
        public string NomDuClub { get; set; }
        public Club()
        {
        }

        public Club(string nom, string lieu)
        {
            this.NomDuClub = nom;
            this.LieuDuClub = lieu;
        }

        public string LieuDuClub
        {
            get { return this.lieuDuClub; }
            set { this.lieuDuClub = value; }
        } 
    }  
}
