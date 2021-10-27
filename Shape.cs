namespace bridge
{
    public abstract class Shape
    {
        public abstract string Draw();
    }

    public class RedCirlce : Shape
    {
        public override string Draw()
        {
            return "Circle/Red";
        }
    }

    public class RedSquare : Shape
    {
        public override string Draw()
        {
            return "Square/Red";
        }
    }

    public class BlueCircle : Shape
    {
        public override string Draw()
        {
            return "Circle/Blue";
        }
    }

    public class BlueSquare : Shape
    {
        public override string Draw()
        {
            return "Square/Blue";
        }
    }
}
