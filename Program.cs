using Mod = TransConnect.Models;


Mod.Client client = new Mod.Client("123456789", "Dupont", "Jean", new DateTime(1985, 5, 15), "1 rue de la Paix", "asd@das.fr", "0123456789");

Mod.Commande commande1 = new Mod.Commande("Paris", "Lyon", DateTime.Now, 1000);
Mod.Commande commande2 = new Mod.Commande("Marseille", "Nice", DateTime.Now.AddDays(1), 1500);

client.AddCommande(commande1);
client.AddCommande(commande2);

Console.WriteLine(client.AfficherHistorique());