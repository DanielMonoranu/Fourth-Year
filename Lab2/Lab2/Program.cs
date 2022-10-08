// See https://aka.ms/new-console-template for more information
using CSharp.Choices;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics.CodeAnalysis;
using static Lab2.Comanda;

internal class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        IQuantity qty;
        qty = new Kg(12.5f);
        //qty.match(when kg: q =q.kg
        //                          )
        var result= qty.Match(whenKg: q => q.kg,
                   whenUnit:q=> q.unit);

        Console.WriteLine(qty);
        Console.WriteLine(result);

    }
}