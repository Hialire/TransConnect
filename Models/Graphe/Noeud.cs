using System;
using System.Collections.Generic;


namespace TransConnect.Models.Graphe
{

    public class Noeud 
    {
        #region Propriétés
        int id;
        static int nextId = 0;
        Object entite;
        List<Lien> liens = new List<Lien>();
        #endregion

        #region Constructeurs
        public Noeud(Object entite)
        {
            this.id = nextId++;
            this.entite = entite;
            nextId++;
        }
        public Noeud(Object entite, List<Lien> liens)
        {
            this.id = nextId++;
            this.entite = entite;
            this.liens = liens;
            nextId++;
        }
        #endregion

        #region Getters et Setters
        public int Id
        {
            get { return id; }
        }
        public Object Entite
        {
            get { return entite; }
            set { entite = value; }
        }
        public List<Lien> Liens
        {
            get { return liens; }
            set { liens = value; }
        }
        #endregion
    
        #region Méthodes
        public void AjouterLien(Lien lien)
        {
            liens.Add(lien);
        }
        public void SupprimerLien(Lien lien)
        {
            liens.Remove(lien);
        }
        public override string ToString()
        {
            if(entite.ToString() != null)
            {
                return entite.ToString();
            }
            else 
            {
                return "Noeud sans entité";
            }

        }
        #endregion
    }
}
