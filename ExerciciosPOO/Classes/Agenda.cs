using System;

namespace ExerciciosPOO
{
    class Agenda
    {
        private string nome;
        private int idade;
        private double altura;

        public Agenda(string nome, int idade, double altura){
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public string getNome(){
            return nome;
        }
        public void setNome(string nome){
            this.nome = nome;
        }

        public int getIdade(){
            return idade;
        }
        public void setIdade(int idade){
            this.idade = idade;
        }

        public double getAltura(){
            return altura;
        }
        public void setAltura (double altura){
            this.altura = altura;
        }

        public void armazenaPessoa(string nome, int idade, double altura){
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Console.WriteLine("Nome: " + nome);
        }

        public void removePessoa(string nome){
            this.nome = nome;
        }

        public int buscaPessoa(string nome){
            for(int i = 0; i < 2; i++){
                if(nome[i].equals(nome)){
                    return "Posição achado: " + i;
                }
                else
                {
                    return "Nome não achado";
                }
            }
        }

        public void imprimeAgenda(){
            for(int j = 0; j < 2; j++){
                Console.WriteLine("Nome: " + nome[i] + " Idade: " + idade[i] + " Altura: " + altura[i]);
            }
        }

        public void imprimePessoa(int index){
            for(int l = 0; l < 2; l++){
                if(index == l){
                    Console.WriteLine("Nome: " + nome[i] + " Idade: " + idade[i] + " Altura: " + altura[i]);
                }
            }
        }
    }
}