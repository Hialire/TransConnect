using System;
using System.Collections.Generic;
using TransConnect.Models.Graphe;
// Créer un graphe avec sa structure
Noeud paris = new Noeud("Paris");
Noeud lyon = new Noeud("Lyon");
Noeud marseille = new Noeud("Marseille");
Noeud bordeaux = new Noeud("Bordeaux");

// Créer le graphe avec Paris comme racine
Graphe grapheVilles = new Graphe(paris);

// Ajouter les autres noeuds
grapheVilles.AjouterNoeud(lyon);
grapheVilles.AjouterNoeud(marseille);
grapheVilles.AjouterNoeud(bordeaux);

// Créer les liens entre les villes
Lien parisLyon = new Lien(paris, lyon, 465.0);
paris.AjouterLien(parisLyon);
lyon.AjouterLien(parisLyon);

Lien parisMarseille = new Lien(paris, marseille, 775.0);
paris.AjouterLien(parisMarseille);
marseille.AjouterLien(parisMarseille);

Lien parisBordeaux = new Lien(paris, bordeaux, 583.0);
paris.AjouterLien(parisBordeaux);
bordeaux.AjouterLien(parisBordeaux);

Lien lyonMarseille = new Lien(lyon, marseille, 315.0);
lyon.AjouterLien(lyonMarseille);
marseille.AjouterLien(lyonMarseille);

grapheVilles.AfficherGraphe();
Console.Write("test");

