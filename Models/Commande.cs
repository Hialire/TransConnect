using System;
using System.Collections.Generic;

namespace TransConnect.Models
{

    public enum StatutCommande
    {
        EnAttente,
        EnCours,
        Livree,
        Payee,
        Annulee
    }

    public class Commande
    {
        #region Propriétés
        int id;
        static int nextId;
        string villeDepart;
        string villeArrivee;
        DateTime date;
        decimal prix;
        StatutCommande statut = StatutCommande.EnAttente;

        
        Client? client;
        Salarie? chauffeur;
        Vehicule? vehicule;
        #endregion
        
        #region Constructeurs
        public Commande(string villeDepart, string villeArrivee, DateTime date,decimal prix)
        {
            this.id = nextId;
            nextId++;
            this.villeDepart = villeDepart;
            this.villeArrivee = villeArrivee;
            this.date = date;
            this.prix = prix;
        }
        #endregion

        #region Getters et Setters
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string GetVilleDepart()
        {
            return villeDepart;
        }
        public void SetVilleDepart(string villeDepart)
        {
            this.villeDepart = villeDepart;
        }
        public string GetVilleArrivee()
        {
            return villeArrivee;
        }
        public void SetVilleArrivee(string villeArrivee)
        {
            this.villeArrivee = villeArrivee;
        }
        public DateTime GetDate()
        {
            return date;
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }
        public decimal GetPrix()
        {
            return prix;
        }
        public void SetPrix(decimal prix)
        {
            this.prix = prix;
        }
        public StatutCommande GetStatut()
        {
            return statut;
        }
        public void SetStatut(StatutCommande statut)
        {
            this.statut = statut;
        }
        public Client? GetClient()
        {
            return client;
        }
        public void SetClient(Client? client)
        {
            this.client = client;
        }
        public Salarie? GetChauffeur()
        {
            return chauffeur;
        }
        public void SetChauffeur(Salarie? chauffeur)
        {
            this.chauffeur = chauffeur;
        }
        public Vehicule? GetVehicule()
        {
            return vehicule;
        }
        public void SetVehicule(Vehicule? vehicule)
        {
            this.vehicule = vehicule;
        }
        #endregion

        #region Méthodes
        public bool EstValide()
        {
            return client != null && chauffeur != null && vehicule != null;
        }
        public string AfficherInfos()
        {
            return $"Commande {id} : {villeDepart} -> {villeArrivee} le {date.ToShortDateString()} \nPrix: {prix:C} \nStatut: {statut}";
        }
        public void ChangerStatut(StatutCommande nouveauStatut)
        {
            if (statut == StatutCommande.Annulee)
                throw new InvalidOperationException("Impossible de modifier une commande annulée");
            
            if (statut == StatutCommande.Payee && nouveauStatut != StatutCommande.Payee)
                throw new InvalidOperationException("Impossible de modifier une commande déjà payée");
            
            statut = nouveauStatut;
        }
        #endregion
    }
}