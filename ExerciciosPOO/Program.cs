using System;

namespace ExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Lucas", 17, 03, 1994, 1.80);
            

            Console.WriteLine(pessoa.imprimirTudo());
            Console.WriteLine("Idade calculada: " + pessoa.calcularIdade(17, 03, 1994));
        }
    }
}
