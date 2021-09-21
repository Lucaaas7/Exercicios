using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime dataNascimento;
           int idade;

           Console.Write("Digite uma data de nascimento: ");
           if(DateTime.TryParse(Console.ReadLine(), out dataNascimento)){
               
               idade = DateTime.Today.Year - dataNascimento.Year;
               if(DateTime.Today.DayOfYear < dataNascimento.DayOfYear){
                   idade--;
               }
               Console.WriteLine("Idade: " + idade);
           }
           else{
               Console.WriteLine("Formato de data inválido");
           }

           
        }
    }
}
