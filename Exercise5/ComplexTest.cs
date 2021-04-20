using System;

namespace Exercise5
{
    class ComplexNumber
    {
        double V1, V2;
        public ComplexNumber(double v1, double v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public double GetReal()
        {
            return V1;
        }
        public void SetReal(double v2)
        {
            this.V1 = v2;
        }
        public double GetImaginary()
        {
            return V2;
        }
        public void SetImaginary(int v)
        {
            this.V2 = v;
        }
        public new string ToString()
        {
            return "(" + V1 + "," + V2 + ")";
        }
        public double GetMagnitude()
        {
            return Math.Sqrt((V1 * V1) + (V2 * V2));
        }

        public void Add(ComplexNumber number2)
        {
            V1 += number2.GetReal();
            V2 += number2.GetImaginary();
        }
    }
    class ComplexTest
    {
        static void Main(string[] args)
        {
          

            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine("Number is: " + number.ToString());

            number.SetImaginary(-3);
            Console.WriteLine("Number is: " + number.ToString());

            Console.Write("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());

            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.Add(number2);
            Console.Write("After adding: ");
            Console.WriteLine(number.ToString());

           

        }
    }
}
