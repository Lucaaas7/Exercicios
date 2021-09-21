using System;

namespace ListaExercicios
{
    class Exercicio05
    {
        public static void executar4(){

            int total, brancos, nulos, validos;
            double calcular, aux;

            Console.Write("Qual é o número total de eleitores? ");
            int.TryParse(Console.ReadLine(), out total);

            Console.Write("Qual é o número de eleitores que votaram no branco? ");
            int.TryParse(Console.ReadLine(), out brancos);

            Console.Write("Qual é o número de eleitores que votaram no nulo? ");
            int.TryParse(Console.ReadLine(), out nulos);

            Console.Write("Qual é o número de eleitores válidos? ");
            int.TryParse(Console.ReadLine(), out validos);

            calcular = 1 * brancos; 
            aux = (calcular / total)*100; 

            Console.WriteLine("Porcentagem dos brancos: " + aux); //vou verificar agora

            calcular = 1 * nulos;
            aux = (calcular / total)*100;

            Console.WriteLine("Porcentagem dos nulos: " + aux);

            calcular = 1 * validos;
            aux = (calcular / total)*100;

            Console.WriteLine("Porcentagem dos válidos: " + aux);

        }
    }
}