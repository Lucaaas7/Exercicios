using System;

namespace ListaExercicios
{
    class Exercicio10
    {
        public static void executar9(){
            double fah, cel;

            Console.Write("Digite a temperatura de Fahrenheit: ");
            double.TryParse(Console.ReadLine(), out fah);

            cel = ((fah - 32) / 9) * 5;

            Console.WriteLine("Transformando em temperatura de Celsius: " + cel);
        }
    }
}