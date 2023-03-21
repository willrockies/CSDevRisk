using System;
using Domain.Interfaces;
using Domain.Entities;
using System.Runtime.CompilerServices;

MainProgram();
void MainProgram()
{
    List<ITrade> portfolio;
    List<string> tradeCategories;

    
    DateTime refenceDate = DateTime.Now;
    
    Trade trade1 = new(2000000, "Private", DateTime.Parse("25/09/2025"));
    Trade trade2 =  new(400000, "Public", DateTime.Parse("07/01/2020" ));
    Trade trade3 = new (5000000, "Public", DateTime.Parse("01/02/2024"));
    Trade trade4 = new (3000000, "Public", DateTime.Parse("26/10/2023"));

    portfolio = new List<ITrade> { trade1, trade2, trade3, trade4 };

    tradeCategories = new Category(portfolio).GetCategories();

    // Output console
    Console.WriteLine("Input:\n");
    Console.WriteLine(refenceDate.ToString("MM/dd/yyyyy"));
    Console.WriteLine(portfolio.Count);
    foreach (ITrade trade in portfolio)
    {
        Console.WriteLine(trade);
    }
        
    
    Console.WriteLine("\nSample Output:\n");
    foreach (var risk in tradeCategories)
    {
        Console.WriteLine(risk);
    }
    
    Console.Write("\n\nPress any key to continue...");
    Console.ReadKey();
}
