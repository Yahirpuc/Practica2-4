using System;

namespace WinFormsApp1
{
    internal class NumeroFactorial
    {
        private int numero;
        private int resultado;

        public NumeroFactorial(int n)
        {
            this.numero = n;
            this.resultado = CalcularFactorial(n);
        }

        public int CalcularFactorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * CalcularFactorial(n - 1);
        }

        public int ObtenerResultadoFactorial()
        {
            return resultado;
        }
    }
}