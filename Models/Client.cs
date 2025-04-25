using System;
using System.Collections.Generic;

namespace TransConnect.Models
{
    public class Client : Personne
    {
        #region Propriétés
        List<Commande> commandes = new List<Commande>();
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
            return commandes;
        }
        public void SetCommandes(List<Commande> commandes)
        {
            this.commandes = commandes;
        }
        public void AddCommande(Commande commande)
        {
            if (!commandes.Contains(commande))
            {
                commandes.Add(commande);
                commande.SetClient(this);
            }
        }

        public void SupCommande(Commande commande)
        {
            if (commandes.Contains(commande))
            {
                commandes.Remove(commande);
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
                foreach (var commande in commandes)
                {
                    total += commande.GetPrix();
                }
                return total;
            }
        }

        public List<Commande> ObtenirHistorique()
        {
            var historique = new List<Commande>(commandes);
            historique.Sort((a, b) => a.GetDate().CompareTo(b.GetDate()));
            return historique;
        }

        public override string AfficherInfos()
        {
            return $"{base.AfficherInfos()} - Nb commandes: {commandes.Count} - Total: {MontantTotalAchats}€";
        }

        public string AfficherHistorique()
        {
            string infos = $"{base.nom} {base.prenom} : Historique des commandes";
            foreach (var commande in commandes)
            {
                infos += $"\n\t{commande.AfficherInfos()}";
            }
            return infos;
        }
        #endregion
    }
}