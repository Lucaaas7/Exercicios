using System;

namespace ListaExercicios
{
    class Exercicio08
    {
        public static void executar7(){

            double salarioFixo, comissao, vendas, salarioFinal, totalCom, valor;
            int numCarros;

            Console.Write("Salário fixo: ");
            double.TryParse(Console.ReadLine(), out salarioFixo);

            Console.Write("Valor por carro vendido: ");
            double.TryParse(Console.ReadLine(), out comissao);

            Console.Write("Valor total de vendas: ");
            double.TryParse(Console.ReadLine(), out vendas);

            Console.Write("Número total de carros: ");
            int.TryParse(Console.ReadLine(), out numCarros);

            totalCom = comissao * numCarros;
            valor = 0.05 * vendas;

            salarioFinal = valor + totalCom + salarioFixo;
            Console.WriteLine("Salário final: " + salarioFinal);
        }


    }
}