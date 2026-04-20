using System;

namespace Kalkulator
{
    class Calculator
    {
        // kalkulator przechowuje aktualną operację
        private Operation currentOperation;

        public void SetOperation(Operation op)
        {
            currentOperation = op;
        }

        // obliczenia są delegowane do obiektu operacji
        public double Calculate(double a, double b)
        {
            if (currentOperation == null)
            {
                throw new Exception("Nie wybrano żadnej operacji.");
            }
            return currentOperation.Execute(a, b);
        }
    }
}