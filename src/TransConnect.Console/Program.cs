// src/TransConnect.Console/Program.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TransConnect.Application.Services;
using TransConnect.Infrastructure.Data;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        // Configuration de la base de données
        var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<TransConnectDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            
        // Enregistrement des services
        services.AddTransient<IClientService, ClientService>();
        services.AddTransient<ISalarieService, SalarieService>();
        // Autres services...
    })
    .Build();

// Code principal de l'application
Console.WriteLine("=======================================");
Console.WriteLine("    TRANSCONNECT - SYSTÈME DE GESTION  ");
Console.WriteLine("=======================================");

// Menu principal
while (true)
{
    Console.WriteLine("\nMenu Principal:");
    Console.WriteLine("1. Gestion des Salariés");
    Console.WriteLine("2. Gestion des Clients");
    Console.WriteLine("3. Gestion des Véhicules");
    Console.WriteLine("4. Gestion des Commandes");
    Console.WriteLine("5. Visualisation de l'Organigramme");
    Console.WriteLine("6. Calcul d'Itinéraire Optimal");
    Console.WriteLine("0. Quitter");
    
    Console.Write("\nVotre choix: ");
    var choix = Console.ReadLine();
    
    switch (choix)
    {
        case "0":
            return;
        case "1":
            // Appel du service correspondant
            break;
        // Autres options...
        default:
            Console.WriteLine("Option non valide.");
            break;
    }
}