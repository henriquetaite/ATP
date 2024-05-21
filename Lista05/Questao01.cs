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

//Inicializando variável M com o valor do primeiro elemento do vetor N
                double M = N[0];
                int P = 0;

//Criando comando for para percorrer o vetor 
        for (int i = 1; i < 20; i++) { //i inicializado na posição 1 porque double M já foi declarado como na posição 0, não havendo necessidade de percorre-la novamente

//Criando comando if para atualizar a variável M
                if (N[i] < M) {
                        M = N[i];
                        P = i;
                }
        }
//Imprimindo resultados do enunciado
        Console.WriteLine ("O menor elemento de N é " + M + " e sua posição dentro do vetor é: " + P); 
    }
}