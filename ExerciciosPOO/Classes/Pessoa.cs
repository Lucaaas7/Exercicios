using System;

namespace ExerciciosPOO
{
    class Pessoa
    {
        private string nome;
        private int ano, mes, dia;
        // private string dataNascimento;
        private double altura;

        // public DateTime(DateTime dataNascimento){
        //     this.dataNascimento = dataNascimento;
        // }

        public Pessoa(string nome, int dia, int mes, int ano, double altura){
            this.nome = nome;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
            this.altura = altura;
        }
        
        public string getNome(){
            return nome;
        }
        public void setNome(string nome){
            this.nome = nome;
        }

        public double getAltura(){
            return altura;
        }
        public void setAltura(double altura){
            this.altura = altura;
        }

        public int getDia(){
            return dia;
        }
        public void setDia(int dia){
            this.dia = dia;
        }

        public int getMes(){
            return mes;
        }
        public void setMes(int mes){
            this.mes = mes;
        }

        public int getAno(){
            return ano;
        }
        public void setAno(int ano){
            this.ano = ano;
        }
        // public DateTime getDataNascimento(){
        //     return dataNascimento;
        // }
        // public void setNome(DateTime dataNascimento){
        //     this.dataNascimento = dataNascimento;
        // }

        public string imprimirTudo(){
            return "Nome: " + nome + " Data de Nascimento: " + dia + "/" + mes + "/" + ano + " Altura: " + altura;
        }

        public double calcularIdade(int dia, int mes, int ano){
            int idadeCalculada;
            if(DateTime.Today.Month < mes) {
                if(DateTime.Today.DayOfYear < dia) {
                    idadeCalculada = (DateTime.Today.Year - ano) - 1;
                }
                else {
                    idadeCalculada = DateTime.Today.Year - ano;
                }
            }
            else {
                idadeCalculada = DateTime.Today.Year - ano;
            }

            return idadeCalculada;
        }
    }
}