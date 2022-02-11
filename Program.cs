using System;

namespace ExemploOperadorLogicoAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultado;
            bool x;
            bool y;

            x = 3 > 2;// x é true, pois tres é maior que dois
            y = 4==4;// y é true, pois quatro é igual a quatro

            resultado = x && y;//resultado é true, pois x = true é igual a y = true. 

            /*
            x = 7 != 5;// x é true, pois sete é diferente de cinco
            y = 6 == 7;// y é false, seis não é igual a sete

            resultado = x && y;//resultado é false, pois x = true é igual a y = false.
            */ 

            Console.WriteLine(resultado);
        }
    }
}
