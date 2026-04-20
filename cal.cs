using System;

namespace Kalkulator
{
    class Calculator
    {
        
        private Operation currentOperation;

        public void SetOperation(Operation op)
        {
            currentOperation = op;
        }

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
