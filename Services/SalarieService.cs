using System;
using TransConnect.Models;
namespace Transconnect.Services
{
    public class SalarieService : Salarie
    {
        public SalarieService(string numeroSS, string nom, string prenom, DateTime dateNaissance, string adressePostale, string adresseEmail, string telephone, DateTime dateEntree, string poste, decimal salaire)
            : base(numeroSS, nom, prenom, dateNaissance, adressePostale, adresseEmail, telephone, dateEntree, poste, salaire)
        {
        }
        
        public void Licenciement(Personne personne)
        {
            ///a faire une fois que l'on aura la liste des personnes
        }
    }
}