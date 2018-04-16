using System;

namespace Numero_Sortudo_Feliz
{
    public class Feliz
    {
        public static string VerificaSeNumeroFeliz(int numero)
        {
            string[] strNum = numero.ToString().Split();
            double total = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < strNum.Length; j++)
                {
                    total += Quadrado(Convert.ToInt16(strNum[j]));
                }
                if(total == 1)
                    return "Feliz";
            }

            return "Não-Feliz";
        }

        private static double Quadrado(int numero)
        {
            return Math.Pow(numero, 2);
        }
    }
}
