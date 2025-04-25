using System;

namespace TransConnect.Models
{
    public enum TypeVehicule
    {
        Voiture,
        Camionnette,
        CamionCiterne,
        CamionBenne,
        CamionFrigorifique
    }

    public class Vehicule
    {
        #region Propriétés
        string immatriculation;
        TypeVehicule type;
        string modele;
        int capacite;
        bool estDisponible = true;
        string? specificiteVehicule;
        decimal tarifKilometrique;
        #endregion
        
        #region Constructeurs
        public Vehicule(string immatriculation, TypeVehicule type, string modele, int capacite, decimal tarifKilometrique)
        {
            this.immatriculation = immatriculation;
            this.type = type;
            this.modele = modele;
            this.capacite = capacite;
            this.tarifKilometrique = tarifKilometrique;
        }
        #endregion

        #region Getters et Setters
        public string GetImmatriculation()
        {
            return immatriculation;
        }
        public void SetImmatriculation(string immatriculation)
        {
            this.immatriculation = immatriculation;
        }
        public TypeVehicule GetTypeV()
        {
            return type;
        }
        public void SetTypeV(TypeVehicule type)
        {
            this.type = type;
        }
        public string GetModele()
        {
            return modele;
        }
        public void SetModele(string modele)
        {
            this.modele = modele;
        }
        public int GetCapacite()
        {
            return capacite;
        }
        public void SetCapacite(int capacite)
        {
            this.capacite = capacite;
        }
        public bool GetEstDisponible()
        {
            return estDisponible;
        }
        public void SetEstDisponible(bool estDisponible)
        {
            this.estDisponible = estDisponible;
        }
        public decimal GetTarifKilometrique()
        {
            return tarifKilometrique;
        }
        public void SetTarifKilometrique(decimal tarifKilometrique)
        {
            this.tarifKilometrique = tarifKilometrique;
        }
        public string? GetSpecificiteVehicule()
        {
            return specificiteVehicule;
        }
        public void SetSpecificiteVehicule(string? specificiteVehicule)
        {
            this.specificiteVehicule = specificiteVehicule;
        }
        #endregion

        #region Méthodes
        public string ObtenirDescription()
        {
            string description = $"{type} {modele} - {immatriculation}";
            switch (type)
            {
                case TypeVehicule.Voiture:
                    description += $" - {capacite} passagers";
                    break;
                case TypeVehicule.Camionnette:
                    description += $" - Usage: {specificiteVehicule}";
                    break;
                case TypeVehicule.CamionCiterne:
                    description += $" - Matière transportée: {specificiteVehicule}";
                    break;
                case TypeVehicule.CamionBenne:
                    description += $" - Type: {specificiteVehicule}";
                    break;
                case TypeVehicule.CamionFrigorifique:
                    description += $" - Température: {specificiteVehicule}";
                    break;
            }
            return description;
        }
        #endregion
    }
}