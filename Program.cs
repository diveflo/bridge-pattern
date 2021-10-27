using System;

namespace bridge
{
    class Consumer
    {
        public void Render(Shape shape)
        {
            Console.WriteLine(shape.Draw());
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Consumer client = new();

            Shape redCircle = new Circle(new Red());
            client.Render(redCircle);

            Shape redSquare = new Square(new Red());
            client.Render(redSquare);

            Shape blueCircle = new Circle(new Blue());
            client.Render(blueCircle);

            Shape blueSquare = new Square(new Blue());
            client.Render(blueSquare);

            Shape greenCircle = new Circle(new Green());
            client.Render(greenCircle);

            Shape greenSquare = new Square(new Green());
            client.Render(greenSquare);
        }
    }
}
