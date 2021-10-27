namespace bridge
{
    public abstract class Shape
    {
        public abstract string Draw();
    }

    public class Cirlce : Shape
    {
        public override string Draw()
        {
            return "Circle";
        }
    }

    public class Square : Shape
    {
        public override string Draw()
        {
            return "Square";
        }
    }
}
