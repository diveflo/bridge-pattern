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

            Shape circle = new Cirlce();
            client.Render(circle);

            Shape square = new Square();
            client.Render(square);
        }
    }
}
