using System;

namespace ExerciciosPOO
{
    class Elevador
    {
        int andarAtual, totalAndares, capacidadeElevador, qtdePessoas, andarSubir, andarDescer, gravar;
        const int terreo = 0;

        public Elevador(){
            this.andarSubir = 0;
            this.totalAndares = 0;
            this.capacidadeElevador = 0;
            this.qtdePessoas = 0;
            this.andarDescer = 0;
        }

        public int getAndarSubir(){
            return andarSubir;
        }
        public void setAndarSubir(int andarSubir){
            this.andarSubir = andarSubir;
        }

        public int getAndarDescer(){
            return andarDescer;
        }
        public void setAndarDescer(int andarDescer){
            this.andarDescer = andarDescer;
        }

        public int getTotalAndares(){
            return totalAndares;
        }
        public void setTotalAndares(int totalAndares){
            this.totalAndares = totalAndares;
        }

        public int getCapacidadeElevador(){
            return capacidadeElevador;
        }
        public void setCapacidadeElevador(int capacidadeElevador){
            this.capacidadeElevador = capacidadeElevador;
        }

        public int getQtdePessoas(){
            return qtdePessoas; //com retorno
        }
        public void setQtdePessoas(int qtdePessoas){
            this.qtdePessoas = qtdePessoas; //sem retorno
        }

        public void inicializa(int capacidadeElevador, int totalAndares){
            this.capacidadeElevador = capacidadeElevador;
            this.totalAndares = totalAndares;
            andarAtual = terreo; //duvida ainda
            Console.WriteLine("Capacidade máxima: " + capacidadeElevador);
            Console.WriteLine("Total de andares: " + totalAndares);
        }

        public void entra(int qtdePessoas){ //quero usar debug nesse metodo
        
            if(this.qtdePessoas + qtdePessoas <= capacidadeElevador){ //essa duvida no if
                this.qtdePessoas += qtdePessoas;
                Console.WriteLine("Quantidade de pessoas inseridas no elevador: " + this.qtdePessoas); //correto?
            }
            else{
                Console.WriteLine("Não foi possível inserir mais uma pessoa devido a capacidade limitdada");
            }
        }

        public void sai(int qtdePessoas){
            if(this.qtdePessoas != 0){
                this.qtdePessoas -= qtdePessoas;
                Console.WriteLine("Removendo uma pessoa: " + this.qtdePessoas);
            }
            else{
                Console.WriteLine("Não tem ninguém no elevador.");
            }

        }

        public void sobe(int andarSubir){
            
            if(andarAtual != totalAndares){
                andarAtual = andarSubir;
                Console.WriteLine("Subindo andar: " + andarAtual);
            }
            else{
                Console.WriteLine("Está no último elevador");
            }
        }
        
        public void desce(int andarDescer){
            if(andarDescer != terreo){
                andarAtual = andarDescer;
                Console.WriteLine("Descendo andar: " + andarAtual);
            }
            else{
                Console.WriteLine("Está no terreo");
            }
        }

    }
}