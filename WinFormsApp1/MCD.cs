using System;

namespace WinFormsApp1
{
    internal class MCD
    {
       
        public static int CalcularMCD(int primerNumero, int segundoNumero)
        {
         
            if (segundoNumero == 0)
            {
                return primerNumero;
            }
            return CalcularMCD(segundoNumero, primerNumero % segundoNumero);
        }
    }
}
