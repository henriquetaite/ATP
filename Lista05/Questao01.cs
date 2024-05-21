using System;
public class Questao01 {
    public static void Rodar() {

//Declarando vetor N com 20 posições
        double [] N = new double [20];

//Gerando números aleatórios para preencher o vetor
        Random randNum = new Random();

//Definindo o tamanho do vetor com suas posições
        for (int i = 0; i < 20; i++) {

//Usando função .Next para preencher cada posição do vetor com um número aleatório
            N[i] = randNum.NextDouble();
        }
    }
}