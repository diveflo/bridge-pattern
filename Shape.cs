namespace bridge
{
    // "Abstraction"
    public class Shape
    {
        protected IColor myColor;

        public Shape(IColor color)
        {
            myColor = color;
        }

        public virtual string Draw()
        {
            return "Shape/" + myColor.Draw();
        }
    }

    // "Refined Abstraction"
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) {}

        public override string Draw()
        {
            return "Circle/" + myColor.Draw();
        }
    }

    // "Refined Abstraction"
    public class Square : Shape
    {
        public Square(IColor color) : base(color) {}

        public override string Draw()
        {
            return "Square/" + myColor.Draw();
        }
    }
}