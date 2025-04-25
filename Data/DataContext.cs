using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using TransConnect.Models.Graphe;
namespace Transconnect.Data
{
    public class GrapheBuilder
    {
        public static List<Noeud> ConstruireGraphe(string Noeuds, string Chemins)
        {
            Dictionary<int, Noeud> noeudsDict = new Dictionary<int, Noeud>();

            // Lire les noeuds
            var lignesNoeuds = File.ReadAllLines(Noeuds);
            for (int i = 1; i < lignesNoeuds.Length; i++) // On ignore l'en-tête
            {
                var ligne = lignesNoeuds[i].Split(',');
                int id = int.Parse(ligne[0]);
                string entite = ligne[1];

                Noeud noeud = new Noeud(entite); // l'id est généré automatiquement
                noeudsDict[id] = noeud;
            }

            // Lire les liens
            var lignesLiens = File.ReadAllLines(Chemins);
            for (int i = 1; i < lignesLiens.Length; i++)
            {
                var ligne = lignesLiens[i].Split(',');

                int id1 = int.Parse(ligne[0]);
                int id2 = int.Parse(ligne[1]);
                double? valeur = string.IsNullOrWhiteSpace(ligne[2]) ? null : double.Parse(ligne[2], CultureInfo.InvariantCulture);
                bool? oriente = string.IsNullOrWhiteSpace(ligne[3]) ? null : bool.Parse(ligne[3]);

                if (noeudsDict.ContainsKey(id1) && noeudsDict.ContainsKey(id2))
                {
                    var lien = new Lien(noeudsDict[id1], noeudsDict[id2], valeur, oriente);
                    noeudsDict[id1].AjouterLien(lien);
                    if (oriente != true) // si non orienté ou orienté dans l'autre sens, ajouter aussi dans l'autre noeud
                        noeudsDict[id2].AjouterLien(lien);
                }
            }

            return new List<Noeud>(noeudsDict.Values);
        }
    }
}

