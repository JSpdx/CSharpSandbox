namespace Fruitstand
{
    class FruitStand() {
        
    }

    public class Banana : IFruit{
        private bool hasPeel = true;
        string IFruit.name { get { return "banana"; } }

        public void peel()
        {
            hasPeel = false;
        }
    }

    public interface IFruit {
        public string name {get;}
        void peel();
    };



    
};
