using System;
public class Questao04 {
    public void Rodar() {
//Declarando vetores X e Y
        int [] vetorX = new int [10];
        int [] vetorY = new int [10];

//Criando procedimento que preencher vetores X e Y
        public void PreenchendoVetores (int [] vetorX, int [] vetorY) {
            Random randNum = new Random ();
                for (int i = 0; i < 10; i++) {
                    vetorX [i] = randNum.NextInt () * 50 - 10;
                }
            Random randNum = new Random ();
                for (int i = 0; i < 10; i++) {
                    vetorY [i] = randNum.NextInt () * 50 - 10; 
                }
        }

    }
}