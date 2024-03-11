namespace Sandbox
{
    class FruitStand(IFruitPeeler fruitPeeler) {
        FruitPeeler fruitPeeler = (FruitPeeler)fruitPeeler;
        public void PeelFruit(IPeelable fruit){
            fruitPeeler.Peel(fruit);
        }
    }

    public class Fruit {
        public string name;
    };

    public interface IPeelable{
        public bool HasPeel{get; set;}
    }

    public class FruitPeeler() : IFruitPeeler{
        public void Peel(IPeelable fruit){
            fruit.HasPeel = false;
        }
    }
    public interface IFruitPeeler{
        void Peel(IPeelable peelable);
    }
};
