using System;

namespace Aula17Dojo

    //
    // 
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP bilhete = new IngressoVIP();
            bilhete.Valor = 25f;
            bilhete.ValorAdicional = 23.7f;
            bilhete.ImprimirValor();
            bilhete.MostrarValorVip();
            System.Console.WriteLine($"A diferença entre os dois valores é igual a R$ {bilhete.ValorAdicional}");
        }
    }
}
