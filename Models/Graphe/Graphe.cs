using System;
using System.Collections.Generic;

namespace TransConnect.Models.Graphe
{
    public class Graphe 
    {
        #region Propriétés
        Noeud racine;
        List<Noeud> noeuds = new List<Noeud>();
        #endregion

        #region Constructeurs
        public Graphe(Noeud racine)
        {
            this.racine = racine;
            noeuds.Add(racine);
        }
        public Graphe(Noeud racine, List<Noeud> noeuds)
        {
            this.racine = racine;
            this.noeuds = noeuds;
        }
        #endregion

        #region Getters et Setters
        public Noeud Racine
        {
            get { return racine; }
            set { racine = value; }
        }
        public List<Noeud> Noeuds
        {
            get { return noeuds; }
            set { noeuds = value; }
        }
        #endregion

        #region Méthodes
        public void AjouterNoeud(Noeud noeud)
        {
            noeuds.Add(noeud);
        }
        public void SupprimerNoeud(Noeud noeud)
        {
            noeuds.Remove(noeud);
        }

        public void AfficherGraphe()
        {
            Console.WriteLine("Graphe : ");
            foreach (Noeud noeud in noeuds)
            {
                Console.WriteLine(noeud.ToString());
            }
        }
        #endregion

    }
}