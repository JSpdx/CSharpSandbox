namespace Sandbox
{
    public class Banana : Fruit, IPeelable{
            private bool _hasPeel = true;
            bool IPeelable.HasPeel{
                get => _hasPeel;
                set => _hasPeel = value;
            }
            new string name = "banana";
        }
}