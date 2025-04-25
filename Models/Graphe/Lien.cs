using System;
using System.Collections.Generic;

namespace TransConnect.Models.Graphe
{
    public class Lien
    {
        #region Propriétés
        Noeud Noeud1 { get; set; }
        Noeud Noeud2 { get; set; }
        //Pour arbre distance
        double? Valeur;
        //Null pas d'orientation, true 1-->2, false 2-->1
        bool? Oriente;
        #endregion

        #region Constructeurs
        public Lien(Noeud noeud1, Noeud noeud2)
        {
            this.Noeud1 = noeud1;
            this.Noeud2 = noeud2;
        }
        public Lien(Noeud noeud1, Noeud noeud2, double? valeur = null, bool? oriente = null)
        {
            this.Noeud1 = noeud1;
            this.Noeud2 = noeud2;
            this.Valeur = valeur;
            this.Oriente = oriente;
        }
        #endregion

        #region Getters et Setters
        public Noeud GetNoeud1()
        {
            return Noeud1;
        }
        public void SetNoeud1(Noeud noeud1)
        {
            Noeud1 = noeud1;
        }
        public Noeud GetNoeud2()
        {
            return Noeud2;
        }
        public void SetNoeud2(Noeud noeud2)
        {
            Noeud2 = noeud2;
        }
        public double? GetValeur()
        {
            return Valeur;
        }
        public void SetValeur(double? valeur)
        {
            Valeur = valeur;
        }
        public bool? GetOriente()
        {
            return Oriente;
        }
        public void SetOriente(bool? oriente)
        {
            Oriente = oriente;
        }
        public void SetLiens(Noeud noeud1, Noeud noeud2)
        {
            this.Noeud1 = noeud1;
            this.Noeud2 = noeud2;
        }
        #endregion

        #region Méthodes
        public string AfficherInfos()
        {
            if (Valeur != null)
            {
                return $"Lien entre {Noeud1} et {Noeud2} avec une valeur de {Valeur}.";
            }
            else if (Oriente != null)
            {
                return $"Lien entre {Noeud1} et {Noeud2} / orienté : {(Oriente != true ? $"De {Noeud1} à {Noeud2}" : $"De {Noeud2} à {Noeud1}")}.";
            }
            else
            {
                return $"Lien entre {Noeud1} et {Noeud2}.";
            }
        }
        #endregion
    }
}

