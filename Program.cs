using System;

namespace Task2Epam
{
    abstract class Figure
    {
        public abstract void Draw();
        public readonly double X=3;
        public readonly double Y=3;
        public void figura(double x, double y)
        {
            x = this.X;
            y = this.Y;
        }
        
    }
  
    class Rectangle : Figure
    {
   
        public override void Draw()
        {
            Console.WriteLine("Class name: Rectangle");
        }
    }
    class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Class name: Square");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle one = new Rectangle();
            one.Draw();
            Square two = new Square();
            two.Draw();
            Console.WriteLine("Hello World!");
        }
    }
}
