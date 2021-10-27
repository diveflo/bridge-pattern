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

            Shape redCircle = new RedCirlce();
            client.Render(redCircle);

            Shape redSquare = new RedSquare();
            client.Render(redSquare);

            Shape blueCircle = new BlueCircle();
            client.Render(blueCircle);

            Shape blueSquare = new BlueSquare();
            client.Render(blueSquare);
        }
    }
}
