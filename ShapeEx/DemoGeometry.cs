using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public class DemoGeometry : MenuProgram
    {
        private List<Shape> shapes;
        public DemoGeometry()
        {
            shapes = new List<Shape>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("\n---======= Shape Program ========---");
            System.Console.WriteLine("1. Add Rectangle");
            System.Console.WriteLine("2. Add Triangle");
            System.Console.WriteLine("3. Add Cirle");
            System.Console.WriteLine("4. Add Square");
            System.Console.WriteLine("5. Add Equilateral Triangle");
            System.Console.WriteLine("6. Show all");
            System.Console.WriteLine("0. Exit!!!");
        }
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddRectangle(); break;
                case 2: AddTriangle(); break;
                case 3: AddCircle(); break;
                case 4: AddSquare(); break;
                case 5: AddEquilateralTriangle(); break;
                case 6: ShowAll(); break;
                case 0: System.Console.WriteLine("You've been out of the program"); break;
                default: System.Console.WriteLine("Invalid choice!!!"); break;
            }
        }
        private void AddRectangle()
        {
            try
            {
            System.Console.WriteLine("Enter the name of Shape: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the Width of Rectangle: ");
            int w = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Height of Rectangle: ");
            int h = Convert.ToInt32(Console.ReadLine());

            shapes.Add(new Rectangle(name, w, h));
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        private void AddTriangle()
        {
            System.Console.WriteLine("Enter the name of Shape: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the first side of the Triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the second side of the Triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the third side of the Triangle: ");
            int c = Convert.ToInt32(Console.ReadLine());

            shapes.Add(new Triangle(name, a, b, c));
        }
        private void AddCircle()
        {
            System.Console.WriteLine("Enter the name of Shape: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the Radius of the Circle: ");
            int r = Convert.ToInt32(Console.ReadLine());

            shapes.Add(new Circle(name, r));
        }
        private void AddSquare()
        {
            System.Console.WriteLine("Enter the name of Shape: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the side of the Circle: ");
            int s = Convert.ToInt32(Console.ReadLine());

            shapes.Add(new Square(name, s));
        }
        private void AddEquilateralTriangle()
        {
            System.Console.WriteLine("Enter the name of Shape: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the side of the EquilateralTriangle: ");
            int s = Convert.ToInt32(Console.ReadLine());

            shapes.Add(new EquilateralTriangle(name, s));
        }

        private void ShowAll()
        {
            foreach (Shape s in shapes) System.Console.WriteLine(s);
        }
    }
}