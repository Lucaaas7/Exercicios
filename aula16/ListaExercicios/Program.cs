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
                        Exercicio03.executar2();
                        break;
                    case 4:
                        Exercicio04.executar3();
                        break;
                    case 5:
                        Exercicio05.executar4();
                        break;
                    case 6:
                        Exercicio06.executar5();
                        break;
                    case 7:
                        Exercicio07.executar6();
                        break;
                    case 8:
                        Exercicio08.executar7();
                        break;
                    case 9:
                        Exercicio09.executar8();
                        break;
                    case 10:
                        Exercicio10.executar9();
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
