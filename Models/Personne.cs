using System;

namespace TransConnect.Models
{
    public class Personne
    {
        #region Propriétés
        protected string NumeroSS;
        protected string Nom;
        protected string Prenom;
        protected DateTime DateNaissance;
        protected string AdressePostale;
        protected string AdresseMail;
        protected string Telephone;
        #endregion

        #region Constructeurs
        protected Personne(string numeroSS, string nom, string prenom, DateTime dateNaissance, string adressePostale, string adresseMail, string telephone)
        {
            this.NumeroSS = numeroSS;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.AdressePostale = adressePostale;
            this.AdresseMail = adresseMail;
            this.Telephone = telephone;
        }
        #endregion

        #region Getters et Setters
        public string GetNumeroSS()
        {
            return NumeroSS;
        }
        public void SetNumeroSS(string numeroSS)
        {
            NumeroSS = numeroSS;
        }
        public string GetNom()
        {
            return Nom;
        }
        public void SetNom(string nom)
        {
            Nom = nom;
        }
        public string GetPrenom()
        {
            return Prenom;
        }
        public void SetPrenom(string prenom)
        {
            Prenom = prenom;
        }
        public DateTime GetDateNaissance()
        {
            return DateNaissance;
        }
        public void SetDateNaissance(DateTime dateNaissance)
        {
            DateNaissance = dateNaissance;
        }
        public string GetAdressePostale()
        {
            return AdressePostale;
        }
        public void SetAdressePostale(string adressePostale)
        {
            AdressePostale = adressePostale;
        }
        public string GetAdresseMail()
        {
            return AdresseMail;
        }
        public void SetAdresseMail(string adresseMail)
        {
            AdresseMail = adresseMail;
        }
        public string GetTelephone()
        {
            return Telephone;
        }
        public void SetTelephone(string telephone)
        {
            Telephone = telephone;
        }
        #endregion

        #region Méthodes
        public virtual string AfficherInfos()
        {
            return $"\n{Prenom} {Nom} \n- Tél: {Telephone} \n- Email: {AdresseMail}";
        }
        #endregion
    }
}