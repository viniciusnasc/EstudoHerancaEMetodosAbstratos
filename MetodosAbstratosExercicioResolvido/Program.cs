using MetodosAbstratosExercicioResolvido.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetodosAbstratosExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Rectangle or Circle (r/c)?");
                char sh = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (sh == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
