using System;

namespace ListaExercicios
{
    class Exercicio03
    {
        public static void executar2(){

            int b;
            int altura, calculo;

            Console.Write("Digite base: ");
            int.TryParse(Console.ReadLine(), out b);

            Console.Write("Digite altura: ");
            int.TryParse(Console.ReadLine(), out altura);

            calculo = b * altura;

            Console.WriteLine("Calculo de retângulo: " + calculo);
        }
    }
}