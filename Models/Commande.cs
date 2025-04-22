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
        int Id;
        static int nextId;
        string VilleDepart;
        string VilleArrivee;
        DateTime Date;
        decimal Prix;
        StatutCommande Statut = StatutCommande.EnAttente;

        
        Client? Client;
        Salarie? Chauffeur;
        Vehicule? Vehicule;
        #endregion
        
        #region Constructeurs
        public Commande(string villeDepart, string villeArrivee, DateTime date,decimal prix)
        {
            this.Id = nextId;
            nextId++;
            this.VilleDepart = villeDepart;
            this.VilleArrivee = villeArrivee;
            this.Date = date;
            this.Prix = prix;
        }
        #endregion

        #region Getters et Setters
        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public string GetVilleDepart()
        {
            return VilleDepart;
        }
        public void SetVilleDepart(string villeDepart)
        {
            VilleDepart = villeDepart;
        }
        public string GetVilleArrivee()
        {
            return VilleArrivee;
        }
        public void SetVilleArrivee(string villeArrivee)
        {
            VilleArrivee = villeArrivee;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public decimal GetPrix()
        {
            return Prix;
        }
        public void SetPrix(decimal prix)
        {
            Prix = prix;
        }
        public StatutCommande GetStatut()
        {
            return Statut;
        }
        public void SetStatut(StatutCommande statut)
        {
            Statut = statut;
        }
        public Client? GetClient()
        {
            return Client;
        }
        public void SetClient(Client? client)
        {
            Client = client;
        }
        public Salarie? GetChauffeur()
        {
            return Chauffeur;
        }
        public void SetChauffeur(Salarie? chauffeur)
        {
            Chauffeur = chauffeur;
        }
        public Vehicule? GetVehicule()
        {
            return Vehicule;
        }
        public void SetVehicule(Vehicule? vehicule)
        {
            Vehicule = vehicule;
        }
        #endregion

        #region Méthodes
        public bool EstValide()
        {
            return Client != null && Chauffeur != null && Vehicule != null;
        }
        public string AfficherInfos()
        {
            return $"Commande {Id} : {VilleDepart} -> {VilleArrivee} le {Date.ToShortDateString()} \nPrix: {Prix:C} \nStatut: {Statut}";
        }
        public void ChangerStatut(StatutCommande nouveauStatut)
        {
            if (Statut == StatutCommande.Annulee)
                throw new InvalidOperationException("Impossible de modifier une commande annulée");
            
            if (Statut == StatutCommande.Payee && nouveauStatut != StatutCommande.Payee)
                throw new InvalidOperationException("Impossible de modifier une commande déjà payée");
            
            Statut = nouveauStatut;
        }
        #endregion
    }
}