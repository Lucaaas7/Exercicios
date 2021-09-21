using System;

namespace ListaExercicios
{
    class Exercicio01
    {
        public static void executar(){
            int a = 10, b = 20, aux;

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("a = " + a + "b = " + b);
        }
    }
}
