using System;
public class Questao01 {
    public static void Rodar() {

//Declarando vetor N com 20 posições
        double [] N = new double [20];

//Gerando números aleatórios para preencher o vetor
        Random randNum = new Random();

//Preenchendo o vetor com função for
        for (int i = 0; i < 20; i++) {
            randNum.NextDouble();
        }
    }
}