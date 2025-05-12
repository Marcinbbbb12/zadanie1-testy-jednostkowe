using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12
{
    public class Calculator
    {
        public double dodaj(double a, double b) => a + b;
        public double odejmij(double a, double b) => a - b; 
        public double pomnoz(double a, double b) => a * b;
        public double podziel(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
        public double Modulo(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a % b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
