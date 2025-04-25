using Mod = TransConnect.Models;
using Gra = TransConnect.Models.Graphe;


Gra.Noeud n1 = new Gra.Noeud("A");
Gra.Noeud n2 = new Gra.Noeud("B");
Gra.Noeud n3 = new Gra.Noeud("C");
Gra.Noeud n4 = new Gra.Noeud("D");


Gra.Lien l1 = new Gra.Lien(n1, n2);
Gra.Lien l2 = new Gra.Lien(n2, n3);
Gra.Lien l3 = new Gra.Lien(n1, n3);

Gra.Lien l4 = new Gra.Lien(n1, n4,null,true);
Gra.Lien l5 = new Gra.Lien(n4, n1,null,false);
Gra.Lien l6 = new Gra.Lien(n4, n2,10);

n1.AddLien(l1,1);
n1.AddLien(l3,1);
n1.AddLien(l4,1);
n1.AddLien(l5,2);

n2.AddLien(l1,2);
n2.AddLien(l2,1);
n2.AddLien(l6,2);
