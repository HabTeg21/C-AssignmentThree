using System;

namespace Exercise1
{
    abstract class Shape1
    {
        protected float R, L, B;
        public abstract float Area();
        public abstract float Circumference();
    }
    class Rectangle : Shape1
    {

        public override float Area()
        {
            Console.Write("Enter Length : ");
            L = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Breadth : ");
            B = (float)Convert.ToDecimal(Console.ReadLine());
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }

    }

    class Circle : Shape1
    {
        public override float Area()
        {
            Console.Write("Enter Radius : ");
            R = (float)Convert.ToDecimal(Console.ReadLine());
            return (float)(Math.PI * Math.Pow(R, 2));
        }

        public override float Circumference()
        {
            return (float)(2 * Math.PI * R);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape1 R = new Rectangle();
           // R.Area();
           // R.Circumference();
            Calculate(R);
            Console.WriteLine();
            Shape1 C = new Circle();
            Calculate(C);
        }
        public static void Calculate(Shape1 S)
        {
            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());

        }
    }
}
