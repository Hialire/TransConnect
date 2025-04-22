using System;
using System.Collections.Generic;

namespace TransConnect.Models
{
    public class Client : Personne
    {
        #region Propriétés
        List<Commande> Commandes { get;set; } = new List<Commande>();
        #endregion
        
        #region Constructeurs
        public Client(string numeroSS, string nom, string prenom, DateTime dateNaissance,string adressePostale, string adresseMail, string telephone)
        : base(numeroSS, nom, prenom, dateNaissance, adressePostale, adresseMail, telephone)
        {
            
        }
        #endregion
        
        #region Getters et Setters
        public List<Commande> GetCommandes()
        {
            return Commandes;
        }
        public void SetCommandes(List<Commande> commandes)
        {
            Commandes = commandes;
        }
        public void AddCommande(Commande commande)
        {
            if (!Commandes.Contains(commande))
            {
                Commandes.Add(commande);
                commande.SetClient(this);
            }
        }

        public void SupCommande(Commande commande)
        {
            if (Commandes.Contains(commande))
            {
                Commandes.Remove(commande);
                commande.SetClient(null);
            }
        }
        #endregion

        #region Méthodes
        public bool EstBonClient()
        {
            return MontantTotalAchats > 10000;
        }

        public decimal MontantTotalAchats
        {
            get
            {
                decimal total = 0;
                foreach (var commande in Commandes)
                {
                    total += commande.GetPrix();
                }
                return total;
            }
        }

        public List<Commande> ObtenirHistorique()
        {
            var historique = new List<Commande>(Commandes);
            historique.Sort((a, b) => a.GetDate().CompareTo(b.GetDate()));
            return historique;
        }

        public override string AfficherInfos()
        {
            return $"{base.AfficherInfos()} - Nb commandes: {Commandes.Count} - Total: {MontantTotalAchats}€";
        }

        public string AfficherHistorique()
        {
            string infos = $"{base.Nom} {base.Prenom} : Historique des commandes";
            foreach (var commande in Commandes)
            {
                infos += $"\n\t{commande.AfficherInfos()}";
            }
            return infos;
        }
        #endregion
    }
}