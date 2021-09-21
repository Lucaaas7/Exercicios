using System;

namespace ListaExercicios
{
    class Exercicio04
    {
        public static void executar3(){

            DateTime idade;
            int verificar = 0;
            int transformar, converter, totalDias, meses, total, ano;

            Console.Write("Digite a tua idade: ");
            if(DateTime.TryParse(Console.ReadLine(), out idade)){

                if(DateTime.Today.DayOfYear < idade.DayOfYear)
                {
                    verificar = DateTime.Today.Year - idade.Year - 1;
                } else
                {
                    verificar = DateTime.Today.Year - idade.Year;
                }

                Console.WriteLine("Teste: " + verificar); //até aqui ok
                
                ano = verificar* 365; // ok
                meses = (DateTime.Today.Month - idade.Month) * 30;
                totalDias = DateTime.Today.Day- idade.Day;
                total = ano + meses + totalDias; 
               
                Console.WriteLine("Teste 1: " + total);
            }
        }
    }
}     
