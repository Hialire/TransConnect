using System;
using System.Collections.Generic;

namespace TransConnect.Models 
{
    public class Salarie : Personne
    {
        #region Propriétés
        DateTime DateEntree { get; set; }
        string Poste { get; set; }
        decimal Salaire { get; set; }
        List<Salarie> Subordonnes { get; set;} = new List<Salarie>();
        #endregion
        
        #region Constructeurs
        public Salarie(string numeroSS, string nom, string prenom, DateTime dateNaissance, string adressePostale, string adresseMail, string telephone, DateTime dateEntree, string poste, decimal salaire) 
        : base(numeroSS, nom, prenom, dateNaissance, adressePostale, adresseMail, telephone)
        {
            this.DateEntree = dateEntree;
            this.Poste = poste;
            this.Salaire = salaire;
        }
        #endregion
        
        #region Getters et Setters
        public DateTime GetDateEntree()
        {
            return DateEntree;
        }
        public void SetDateEntree(DateTime dateEntree)
        {
            DateEntree = dateEntree;
        }
        public string GetPoste()
        {
            return Poste;
        }
        public void SetPoste(string poste)
        {
            Poste = poste;
        }
        public decimal GetSalaire()
        {
            return Salaire;
        }
        public void SetSalaire(decimal salaire)
        {
            Salaire = salaire;
        }
        public List<Salarie> GetSubordonnes()
        {
            return Subordonnes;
        }
        public void SetSubordonnes(List<Salarie> subordonnes)
        {
            Subordonnes = subordonnes;
        }
        public void AddSubordonnes(Salarie subordonnee)
        {
            Subordonnes.Add(subordonnee);
        }
        public void SupSubordonnes(Salarie subordonnee)
        {
            Subordonnes.Remove(subordonnee);
        }
        #endregion

        #region Méthodes
        public override string AfficherInfos()
        {
            return $"{base.AfficherInfos()} \n- Poste: {Poste} \n- Salaire: {Salaire:C} \n- Date d'entrée: {DateEntree.ToShortDateString()}";
        }

        public string AfficherHierarchie()
        {
            string infos = $"{base.Nom} {base.Prenom} : {Poste}";
            if (Subordonnes.Count > 0)
            {
                foreach (var sub in Subordonnes)
                {
                    if (sub != null)
                    {
                        string subHierarchie = sub.AfficherHierarchie();
                        subHierarchie = subHierarchie.Replace("\n", "\n\t");
                        infos += $"\n\t{subHierarchie}";
                    }
                }
            }
            return infos;
        }
        #endregion
    }

}