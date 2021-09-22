using System;

namespace ListaExercicios
{
    
    class Exercicio06
    {

        public static void executar5(){

            double salario, reajuste, novoSalario;

            Console.Write("Qual é o teu salário? ");
            double.TryParse(Console.ReadLine(), out salario);

            Console.Write("Qual é o reajuste salarial? ");
            double.TryParse(Console.ReadLine(), out reajuste);

            novoSalario = salario * (1 + (reajuste/100));
            Console.WriteLine("Novo salário: " + novoSalario);
        }
    }
}