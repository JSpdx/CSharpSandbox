// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using Microsoft.VisualBasic;

namespace Name
{
    
}
class FruitStand() {
    
}

public class Banana() : Fruit{
    public string name = "banana";
}

public interface Fruit {
    public string name {get; set;}
};

FruitStand myStand = new FruitStand()