namespace Sandbox
{
    public class Banana : Fruit, IPeelable{
            bool _hasPeel;
            bool IPeelable.HasPeel{
                get => _hasPeel;
                set => _hasPeel = value;
            }
            string name = "banana";
            
        }
    
}