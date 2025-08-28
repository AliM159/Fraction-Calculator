using System;

namespace FractionCalculator
{
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }

        // ---- Constructors ----
        public Fraction(int top = 0, int bottom = 1)
        {
            if (bottom == 0)
                throw new Exception("Denominator cannot be zero");
            if (top == 0 && bottom == 0)
                throw new Exception("Cannot perform operation with numerator and denominator as zero");

            // Keep denominator positive
            if (bottom < 0)
            {
                top = -top;
                bottom = -bottom;
            }

            // Reduce to lowest terms
            int g = Gcd(Math.Abs(top), Math.Abs(bottom));
            if (g == 0) g = 1; // just in case

            Top = top / g;
            Bottom = bottom / g;
        }

        public Fraction(string top = "0", string bottom = "1")
        {
            int parsedTop, parsedBottom;

            if (!int.TryParse(top, out parsedTop))
                parsedTop = 0;
            if (!int.TryParse(bottom, out parsedBottom))
                parsedBottom = 1;

            if (parsedBottom == 0)
                throw new Exception("Denominator cannot be zero");
            if (parsedTop == 0 && parsedBottom == 0)
                throw new Exception("Cannot perform operation with numerator and denominator as zero");

            if (parsedBottom < 0)
            {
                parsedTop = -parsedTop;
                parsedBottom = -parsedBottom;
            }

            int g = Gcd(Math.Abs(parsedTop), Math.Abs(parsedBottom));
            if (g == 0) g = 1;

            Top = parsedTop / g;
            Bottom = parsedBottom / g;
        }

        // ---- Operators ----
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int n = a.Top * b.Bottom + b.Top * a.Bottom;
            int d = a.Bottom * b.Bottom;
            return new Fraction(n, d); // will reduce automatically
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int n = a.Top * b.Bottom - b.Top * a.Bottom;
            int d = a.Bottom * b.Bottom;
            return new Fraction(n, d);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int n = a.Top * b.Top;
            int d = a.Bottom * b.Bottom;
            return new Fraction(n, d);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Top == 0)
                throw new Exception("Cannot divide by a fraction with a numerator of zero.");

            int n = a.Top * b.Bottom;
            int d = a.Bottom * b.Top;
            return new Fraction(n, d);
        }

        // ---- Helpers ----
        private static int Gcd(int a, int b)
        {
            // Euclid's algorithm, simple version
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            if (a == 0) return 1; // avoid divide-by-zero when top==0
            return a;
        }

        public override string ToString()
        {
            return $"{Top}/{Bottom}";
        }

        public void Deconstruct(out string top, out string bottom)
        {
            top = Top.ToString();
            bottom = Bottom.ToString();
        }
    }
}
