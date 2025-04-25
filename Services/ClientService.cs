using System;
using System.Data;
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

        DataTable dfClient = new DataTable();
        dfClient.Columns.Add("Numéro de Sécurité Sociale", typeof(string));
        dfClient.Columns.Add("Nom", typeof(string));
        dfClient.Columns.Add("Prénom", typeof(string));
        dfClient.Columns.Add("Date de Naissance", typeof(DateTime));
        dfClient.Columns.Add("Adresse Postale", typeof(string));
        dfClient.Columns.Add("Adresse Email", typeof(string));
        dfClient.Columns.Add("Téléphone", typeof(string));
        dfClient.Columns.Add("Montant Achats Cumulés", typeof(decimal));

        foreach(Client c in ClientList)
        {
            dfClient.Rows.Add(c.NumeroSS, c.Nom, c.Prenom, c.DateNaissance, c.AdressePostale, c.AdresseEmail, c.Telephone);
        }
        DataView vue = dfClient.DefaultView;
        vue.Sort = "Nom";
        DataTable dfClientTrie = vue.ToTable();

    }
}