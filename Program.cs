// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using Microsoft.VisualBasic;
using Sandbox;

FruitPeeler peeler = new FruitPeeler();
FruitStand myStand = new FruitStand(peeler);
Banana banana1= new Banana();
Console.WriteLine(banana1.name);
myStand.PeelFruit(banana1);
// Console.WriteLine(banana1.HasPeel());


