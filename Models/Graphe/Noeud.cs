using System;
using System.Collections.Generic;


namespace TransConnect.Models.Graphe
{
    /*
    public class Noeud
    {
        #region Propriétés
        string nom;
        List<Lien> liens = new List<Lien>();
        #endregion

        #region Constructeurs
        public Noeud(string nom)
        {
            this.nom = nom;
        }
        public Noeud(string nom, List<Lien> liens)
        {
            this.nom = nom;
            this.liens = liens;
        }
        #endregion

        #region Getters et Setters
        public string GetNom()
        {
            return nom;
        }
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        public List<Lien> GetLiens()
        {
            return liens;
        }
        public void SetLiens(List<Lien> liens)
        {
            this.liens = liens;
        }
        public void AddLien(Lien lien,int pos)
        {
            if (!liens.Contains(lien))
            {
                liens.Add(lien);
                if (pos == 1)
                    lien.SetNoeud1(this);
                else if (pos == 2)
                    lien.SetNoeud2(this);
                else
                    throw new ArgumentException("Position invalide. Utilisez 1 ou 2.");
            }
        }
        public void SupLien(Lien lien,int pos)
        {
            if (liens.Contains(lien))
            {
                liens.Remove(lien);
                if (pos == 1)
                    lien.SetNoeud1(new Noeud(""));
                else if (pos == 2)
                    lien.SetNoeud2(new Noeud(""));
                else
                    throw new ArgumentException("Position invalide. Utilisez 1 ou 2.");
            }
        }

        #endregion

        #region Méthodes
        public string AfficherInfos()
        {
            string infos = $"Noeud : {nom}.\nLiens : {liens.Count}.\n";
            foreach (var lien in liens)
            {
                infos += lien.AfficherInfos() + "\n";
            }
            return infos;
        }
        #endregion
    }
    */
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
        public Object GetEntite()
        {
            return entite;
        }
        public void SetEntite(Object entite)
        {
            this.entite = entite;
        }
        public List<Lien> GetLiens()
        {
            return liens;
        }
        public void SetLiens(List<Lien> liens)
        {
            this.liens = liens;
        }
        public void AddLien(Lien lien, int pos)
        {
            if (!liens.Contains(lien))
            {
                liens.Add(lien);
                if (pos == 1)
                    lien.SetNoeud1(this);
                else if (pos == 2)
                    lien.SetNoeud2(this);
                else
                    throw new ArgumentException("Position invalide. Utilisez 1 ou 2.");
            }
        }
        public void SupLien(Lien lien, int pos)
        {
            if (liens.Contains(lien))
            {
                liens.Remove(lien);
                if (pos == 1)
                    lien.SetNoeud1(new Noeud(""));
                else if (pos == 2)
                    lien.SetNoeud2(new Noeud(""));
                else
                    throw new ArgumentException("Position invalide. Utilisez 1 ou 2.");
            }
        }
        #endregion
    }
}
