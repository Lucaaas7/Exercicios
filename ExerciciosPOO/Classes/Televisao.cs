using System;

// Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e
// trocar os canais da televisão. O controle de volume permite:
// • aumentar ou diminuir a potência do volume de som em uma unidade de cada vez;
// • aumentar e diminuir o número do canal em uma unidade
// • trocar para um canal indicado;
// • consultar o valor do volume de som e o canal selecionado

namespace ExerciciosPOO
{
    class Televisao
    {
        int tamanhoVolume, tamanhoCanais, unidades;

        public Televisao(int unidades){
            this.tamanhoVolume = 0;
            this.tamanhoCanais = 0;
            this.unidades = unidades;
        }

        public int getTamanhoVolume(){
            return tamanhoVolume;
        }
        public void setTamanhoVolume(int tamanhoVolume){
            this.tamanhoVolume = tamanhoVolume;
        }

        public int getTamanhoCanais(){
            return tamanhoCanais;
        }
        public void setTamanhoCanais(int tamanhoCanais){
            this.tamanhoCanais = tamanhoCanais;
        }

        public int getUnidades(){
            return unidades;
        }
        public void setUnidades(int unidades){
            this.unidades = unidades;
        }


        public void         


    }
}