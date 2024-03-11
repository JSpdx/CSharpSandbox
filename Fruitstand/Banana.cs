namespace Sandbox
{
    public class Banana : Fruit, IPeelable{
            private bool _hasPeel;
            bool IPeelable.HasPeel{
                get => _hasPeel;
                set => _hasPeel = value;
            }
            string name = "banana";
        }
    
}