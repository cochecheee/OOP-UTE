using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_ComplexNumber
{
    internal class ComplexNumber
    {
        public ComplexNumber() { }
        public ComplexNumber(int value) { }
        private int real;
        private int imaginary;

        public int Real { get => real; set => real = value; }
        public int Imaginary { get => imaginary; set => imaginary = value; }
        public ComplexNumber(int a, int b)
        {
            Real = a; Imaginary = b;
        }
        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
        }
        public static ComplexNumber Add(ComplexNumber x, ComplexNumber y)
        {
            return x + y;
        }
        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber((x.Real*y.Real - x.Imaginary*y.Imaginary), (x.Real*y.Imaginary+y.Real*x.Imaginary));
        }
        public override string ToString()
        {
            return Real + " + " + Imaginary + "i";
        }
    }
}
