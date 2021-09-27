using System;

// Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e
// trocar os canais da televisão. O controle de volume permite:
// • aumentar ou diminuir a potência do volume de som em uma unidade de cada vez;
// • aumentar e diminuir o número do canal em uma unidade
// • trocar para um canal indicado;
// • consultar o valor do volume de som e o canal selecionado

namespace ExerciciosPOO
{
    class ControleRemoto : Televisao
    {
        int controlarVolume, controlarCanal;

        public ControleRemoto(){
            super(tamanhoVolume, tamanhoCanais, unidades);
            this.controlarVolume = 0;
            this.controlarCanal = 0;
        }

        public int getControlarVolume(){
            return controlarVolume;
        }
        public void setControlarVolume(int controlarVolume){
            this.controlarVolume = controlarVolume;
        }

        public int getControlarCanal(){
            return controlarCanal;
        }
        public void setControlarCanal(int controlarCanal){
            this.controlarCanal = controlarCanal;
        }

        public void controlarVolumes(int tamanhoVolume, int opcao){
            
            switch (opcao)
            {
                case 1:
                    tamanhoVolume += tamanhoVolume;
                    Console.WriteLine("Aumentando volume máximo: " + tamanhoVolume);
                break;

                case 2:
                    tamanhoVolume -= tamanhoVolume;
                    Console.WriteLine("Diminuindo volume máximo: " + tamanhoVolume);
                break;
                
                default:
                    Console.WriteLine("Desculpe, mas você está fora de si");
                break;
            }

        }
    }
}