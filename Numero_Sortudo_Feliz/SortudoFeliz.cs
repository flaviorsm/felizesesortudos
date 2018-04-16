using System;

namespace Numero_Sortudo_Feliz
{
    public class SortudoFeliz
    {
        public string VerificarNumero(int numero)
        {
            string resultado = "{0} - {1} e {2}.";
            return string.Format(resultado, numero.ToString(), Sortudo.VerificaSeNumeroSortudo(numero), Feliz.VerificaSeNumeroFeliz(numero));
        }
    }
}
