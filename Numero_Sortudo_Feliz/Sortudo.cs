using System;
using System.Collections;

namespace Numero_Sortudo_Feliz
{
    public class Sortudo
    {
        public static String VerificaSeNumeroSortudo(int numero)
        {
            if (numero == 1)
                return "Número Sortudo";

            ArrayList lista = new ArrayList();
            for (int i = 1; i <= numero; i++)
            {
                if(i % 2 != 0)
                    lista.Add(i);
            }
            for (int p3 = 1; p3 <= lista.Count; p3++)
            {
                if (p3 % 3 == 0)
                    lista.RemoveAt(p3 - 1);
            }
            for (int p7 = 1; p7 <= lista.Count; p7++)
            {
                if (p7 % 7 == 0)
                    lista.RemoveAt(p7 - 1);
            }

            if(lista.IndexOf(numero) > -1)
                return "Número Sortudo";

            return "Número Não-Sortudo";
        }
    }
}
