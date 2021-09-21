using System;

namespace ListaExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de exercicios");
            int opcao = 0;

            while(opcao != 99){

                Console.Write(" Digite o número do exercicio (99 para sair): ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        Exercicio01.executar();
                        break;
                    case 2:
                        Exercicio02.executar1();
                        break;
                    case 3:
                        Exercicio03.exercutar2();
                        break;
                    case 99:
                        Console.WriteLine("Saindo do programa");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
            }
        }
    }
}
