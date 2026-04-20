using System;

namespace Kalkulator
{
    abstract class Operation
    {
        // każda klasa pochodna musi mieć swoją wersję Execute
        public abstract double Execute(double a, double b);
    }

    class Add : Operation
    {
        public override double Execute(double a, double b)
        {
            return a + b;
        }
    }

    class Subtract : Operation
    {
        public override double Execute(double a, double b)
        {
            return a - b;
        }
    }

    class Multiply : Operation
    {
        public override double Execute(double a, double b)
        {
            return a * b;
        }
    }

    class Divide : Operation
    {
        public override double Execute(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez zero!");
            }
            return a / b;
        }
    }
}