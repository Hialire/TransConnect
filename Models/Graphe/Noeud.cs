using System;
using System.Collections.Generic;


namespace TransConnect.Models.Graphe
{

    public class Noeud 
    {
        #region Propriétés
        Object entite;
        List<Lien> liens = new List<Lien>();
        #endregion

        #region Constructeurs
        public Noeud(Object entite)
        {
            this.entite = entite;
        }
        public Noeud(Object entite, List<Lien> liens)
        {
            this.entite = entite;
            this.liens = liens;
        }
        #endregion

        #region Getters et Setters
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
        #endregion
    }
}
