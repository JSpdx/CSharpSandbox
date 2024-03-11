namespace Sandbox
{
    class FruitStand() {

    }

    public class Fruit {
        public string name;
    };

    public interface IPeelable{
        bool HasPeel{get; set;}
    }

    public class FruitPeeler(IPeelable fruit){
        public void Peel(){
            fruit.HasPeel = false;
        }
    }
};
