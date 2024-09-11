using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;

namespace WinFormsApp1
{
    internal class SerieFibonacci //Formula: F(n)=F(n−1)+F(n−2)
                                  //cada numero es la suma de los dos anteriores.
    {
        public List<int> Serie { get; set; }

        public SerieFibonacci(int numeroTerminos)
        {
            Serie = new List<int>(); // Creamos la lista
            for (int i = 0; i < numeroTerminos; i++)
            {
                Serie.Add(CalcularFibonacci(i));  //Este sera la llamada recursiva
            }
        }

        private int CalcularFibonacci(int n)
        {

            //Ponemos los dos primero numeros de la serie
        
            if (n == 0) return 0;
            if (n == 1) return 1;

            //Se llama asi misma
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }
    }
}
