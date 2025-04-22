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
        string Immatriculation;
        TypeVehicule Type;
        string Modele;
        int Capacite;
        bool EstDisponible = true;
        string? SpecificiteVehicule;
        decimal TarifKilometrique;
        #endregion
        
        #region Constructeurs
        public Vehicule(string immatriculation, TypeVehicule type, string modele, int capacite, decimal tarifKilometrique)
        {
            Immatriculation = immatriculation;
            Type = type;
            Modele = modele;
            Capacite = capacite;
            TarifKilometrique = tarifKilometrique;
        }
        #endregion

        #region Getters et Setters
        public string GetImmatriculation()
        {
            return Immatriculation;
        }
        public void SetImmatriculation(string immatriculation)
        {
            Immatriculation = immatriculation;
        }
        public TypeVehicule GetTypeV()
        {
            return Type;
        }
        public void SetTypeV(TypeVehicule type)
        {
            Type = type;
        }
        public string GetModele()
        {
            return Modele;
        }
        public void SetModele(string modele)
        {
            Modele = modele;
        }
        public int GetCapacite()
        {
            return Capacite;
        }
        public void SetCapacite(int capacite)
        {
            Capacite = capacite;
        }
        public bool GetEstDisponible()
        {
            return EstDisponible;
        }
        public void SetEstDisponible(bool estDisponible)
        {
            EstDisponible = estDisponible;
        }
        public decimal GetTarifKilometrique()
        {
            return TarifKilometrique;
        }
        public void SetTarifKilometrique(decimal tarifKilometrique)
        {
            TarifKilometrique = tarifKilometrique;
        }
        public string? GetSpecificiteVehicule()
        {
            return SpecificiteVehicule;
        }
        public void SetSpecificiteVehicule(string? specificiteVehicule)
        {
            SpecificiteVehicule = specificiteVehicule;
        }
        #endregion

        #region Méthodes
        public string ObtenirDescription()
        {
            string description = $"{Type} {Modele} - {Immatriculation}";
            switch (Type)
            {
                case TypeVehicule.Voiture:
                    description += $" - {Capacite} passagers";
                    break;
                case TypeVehicule.Camionnette:
                    description += $" - Usage: {SpecificiteVehicule}";
                    break;
                case TypeVehicule.CamionCiterne:
                    description += $" - Matière transportée: {SpecificiteVehicule}";
                    break;
                case TypeVehicule.CamionBenne:
                    description += $" - Type: {SpecificiteVehicule}";
                    break;
                case TypeVehicule.CamionFrigorifique:
                    description += $" - Température: {SpecificiteVehicule}";
                    break;
            }
            return description;
        }
        #endregion
    }
}