using System;
using TransConnect.Models;
namespace Transconnect.Services
{
    public class ClientService : Personne
    {
        private decimal montantAchatsCumulés;

        public ClientService(string numeroSS, string nom, string prenom, DateTime dateNaissance, string adressePostale, string adresseEmail, string telephone, decimal montantAchats)
            : base(numeroSS, nom, prenom, dateNaissance, adressePostale, adresseEmail, telephone)
        {
            this.montantAchatsCumulés = montantAchats;
        }
        public decimal MontantAchatsCumulés
        {
            get { return montantAchatsCumulés; }
            set { if (value >= 0) montantAchatsCumulés = value; }
        }

        
    }
}