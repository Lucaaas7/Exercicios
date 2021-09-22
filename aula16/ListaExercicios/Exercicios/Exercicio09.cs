using System;

namespace ListaExercicios
{
    class Exercicio09
    {
        public static void executar8(){
            double nota1, nota2, nota3, notaTotal;

            Console.Write("Nota 1: ");
            double.TryParse(Console.ReadLine(), out nota1);

            Console.Write("Nota 2: ");
            double.TryParse(Console.ReadLine(), out nota2);

            Console.Write("Nota 3: ");
            double.TryParse(Console.ReadLine(), out nota3);

            notaTotal = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

            Console.WriteLine("Notal final: " + notaTotal);
        }
    }
}