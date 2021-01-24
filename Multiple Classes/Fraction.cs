using System;

namespace Multiple_Classes
{
    public class Fraction
    {
        public double Numerator { get; set; }
        private double _denominator;
        public Fraction(in double numerator, in double denominator)
        {
            Denominator = denominator;
            Numerator = numerator;
        }
        public double Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                    throw new ArithmeticException("Denominator must be non-zero digit!");

                _denominator = value;
            }
        }

        public static Fraction Add(Fraction first, Fraction second)
        {
            double numeratorSum = (second.Denominator * first.Numerator) + (first.Denominator * second.Numerator);
            return new Fraction(numeratorSum, first.Denominator * second.Denominator);            
        }
        public static Fraction Subtract(Fraction first, Fraction second)
        {
            double numeratorSubtract = (second.Denominator * first.Numerator) - (first.Denominator * second.Numerator);
            return new Fraction(numeratorSubtract, first.Denominator * second.Denominator);            
        }
        public static Fraction Multiply(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Numerator, first.Denominator * second.Denominator);            
        }
        public static Fraction Divide(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator, first.Denominator * second.Numerator);            
        }
        private double Gcd(double first, double second)
        {
            if (first == 0)
                return second;

            return Gcd(first % second, first);
        }
        public Fraction Reduce()
        {
            double number = 1;
            if (Denominator > Numerator)
                number = Gcd(Denominator, Numerator);
            else
                number = Gcd(Numerator, Denominator);

            Denominator /= number;
            Numerator /= number;

            return new Fraction(Numerator, Denominator);
        }

        public void Show()
        {
            Console.WriteLine($"{Numerator} / {Denominator}");
        }

    }
}
