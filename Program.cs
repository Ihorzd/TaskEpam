using System;

namespace Task1Epam
{
    

    //Tasktwo
    class Rectangle
    {
        public double PointX1 { get; set; }
        public double PointX2 { get; set; }
        public double PointY1 { get; set; }

        public double PointY2 { get; set; }
        public Rectangle()
            {
            this.PointX1 = PointX1;
            this.PointX2 = PointX2;
            this.PointY1 = PointY1;
            this.PointY2 = PointY2;
        }
           

        public double CalculetArea()
        {
            double AB = Math.Pow(Math.Pow((PointX1 - PointX1),2) + Math.Pow((PointY2 - PointY1),2),0.5) ;
            double BC = Math.Pow(Math.Pow((PointX2 - PointX1),2) + Math.Pow((PointY1 - PointY1),2),0.5) ;
            return AB*BC;
        }
        public double CalculetPerimetr()
        {
            double AB = Math.Pow(Math.Pow((PointX1 - PointX1), 2) + Math.Pow((PointY2 - PointY1), 2), 0.5);
            double BC = Math.Pow(Math.Pow((PointX2 - PointX1), 2) + Math.Pow((PointY1 - PointY1),2), 0.5);
            return (AB + BC) * 2;
        }


    }
    class Circle
    {
        public const double pi = 3.14159265;
        public double CalculeitLenCircl(double radius)
        {
            return 2 * radius * pi;
        }
        public double CalculeitAreaCircle(double radius)
        {
            return pi*radius*radius;
        }
    }
    static class Rectanglestatic
    {
        public static double CalculeitRectangleArea(double x1, double x2, double y1, double y2)
        {
            double AB = Math.Pow(Math.Pow((x1 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
            double BC = Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y1 - y1), 2), 0.5);
            return AB * BC;
        }
        public static double CalculetRectanglePerimetr(double x1, double x2, double y1, double y2)
        {
            double AB = Math.Pow(Math.Pow((x1 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
            double BC = Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y1 - y1), 2), 0.5);
            return (AB + BC) * 2;

        }
    }
        static class Circlestatic
        {
            public const double pi = 3.14159265;
            public static double CalculeitLenCircl(double radius)
            {
                return 2 * radius * pi;
            }
            public static double  CalculeitAreaCircle(double radius)
            {
                return pi * radius * radius;
            }
        }
    class ComplexNumber
    {
        private int real;
        private int immaginary;

        public ComplexNumber(int real, int immaginary)
        {
            this.real = real;
            this.immaginary = immaginary;
        }
        public override bool Equals(object obj)
        {
            var other = obj as ComplexNumber;
            if (other == null) return false;
            return (this.real == other.real) && (this.immaginary == other.immaginary);
        }
        public static bool operator ==(ComplexNumber me, ComplexNumber other) => Equals(me, other);
        public static bool operator !=(ComplexNumber me, ComplexNumber other) => !Equals(me, other);
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real * c2.real, c1.immaginary * c2.immaginary);

        }
    }
    
        class Program
    {
        static void Main(string[] args)
        {
            double valueArea = Rectanglestatic.CalculeitRectangleArea(3, 0, 0, 3);
            double valuePerimetr = Rectanglestatic.CalculetRectanglePerimetr(3, 0, 0, 3);
            double valueCirclelen = Circlestatic.CalculeitLenCircl(1);
            double valueCircleArea = Circlestatic.CalculeitAreaCircle(5);

            var a = new ComplexNumber(3, 5);
            var b = new ComplexNumber(1, 2);
            var c = new ComplexNumber(2, 3);

            if (a == b * c)
                Console.WriteLine("(3,5)==(1,2) + (2,3)");
            if (b != a * c)
                Console.WriteLine("(1,2) != (3,5) + (2,3)");
            Rectangle one = new Rectangle();
            Console.WriteLine("Enter point x1:");
            one.PointX1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter point x2:");
            one.PointX2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter point y1:");
            one.PointY1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter point y2:");
            one.PointY2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area = " + one.CalculetArea());
            Console.WriteLine("Perimetr = " + one.CalculetPerimetr());


            Circle two = new Circle();
            Console.WriteLine("Len Circl= " + two.CalculeitLenCircl(1));
            Console.WriteLine("Area Circle= " + two.CalculeitAreaCircle(5));
            Console.WriteLine("static Area= "+valueArea);
            Console.WriteLine("static Perimetr= " + valuePerimetr);

            Console.WriteLine("static Circle Area = "+ valueCircleArea);
            Console.WriteLine("static Circle len = "+ valueCirclelen);
            Console.WriteLine("Hello World!");
        }
        //public double CalculetAreaRect(double x1, double x2, double y1, double y2)
        //{
        //    double AB = Math.Pow(Math.Pow((x1 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
        //    double BC = Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y1 - y1), 2), 0.5);
        //    return AB * BC;
        //}
        //public double CalculetPerimetrRect(double x1, double x2, double y1, double y2)
        //{
        //    double AB = Math.Pow(Math.Pow((x1 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
        //    double BC = Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y1 - y1), 2), 0.5);
        //    return (AB + BC) * 2;
        //}

    }
}

