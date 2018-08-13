/* 
  Author:   Avinash M
  Date:     08/13/2018
  Description: Finding the area of shapes.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicShapesArea.ConsoleApp
{
    class Program
    {
        private static string[] shapes = new string[] { "Triangle", "Rectangle", "Circle" };

        static void Main(string[] args)
        {
            Console.WriteLine("*** Find area of the shape ***");

            int selectedOption = -1;
            do
            {
                Menu();
                Console.Write("Please choose an option: ");
                selectedOption = Int16.Parse(Console.ReadLine());

                if (selectedOption > 0 && selectedOption <= shapes.Length)
                {
                    CalculateArea(shapes[selectedOption - 1]);
                }
            } while (selectedOption != 0);
        }

        static void Menu()
        {            
            int count = 0;
            foreach (string shape in shapes)
            {
                Console.WriteLine($"{++count}. {shape}");
            }
            Console.WriteLine("0. Exit\n");
        }

        static void CalculateArea(string shape)
        {
            switch (shape.ToLower())
            {
                case "triangle":
                    Console.Write("Enter base of the triangle: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height of the triangle: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area: {0}", 0.5 * b * h);
                    break;
                case "rectangle":
                    Console.Write("Enter length of the rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter breadth of the rectangle: ");
                    double breadth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area: {0}", length * breadth);
                    break;
                case "circle":
                    Console.Write("Enter radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area: {0}", Math.PI * Math.Pow(radius, 2));
                    break;
                default:
                    Console.WriteLine("Invalid shape");
                    break;
            }
            Console.WriteLine();
        }
    }
}
