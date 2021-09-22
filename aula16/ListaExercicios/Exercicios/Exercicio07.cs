using System;  

namespace ListaExercicios
{   
    class Exercicio07
    {
        public static void executar6(){

            double perDist = 0.28, perImp = 0.45, custoFab, custoCar = 0, valorDist, valorImp, total;

            Console.Write("Qual é o custo da fábrica?");
            double.TryParse(Console.ReadLine(), out custoFab);

            valorDist = (1 + perDist) * custoFab;
            Console.WriteLine("Valor de Distribuidor: " + valorDist);

            valorImp = (1+ perImp) * custoFab;
            Console.WriteLine("Valor de Distribuidor: " + valorImp);

            total = valorDist + valorImp + custoFab;
            Console.WriteLine("Valor total do custo de Fábrica: " + total);

           

        }
    }    
}