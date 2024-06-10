using System;
public class Questao03
{
    public void Rodar()
    {

       //Declarando e inicializando vetor X
        double [] vetorX = new double [10];

//Acionando Procedimento de preencher vetor
        PreencherVetorX (vetorX);

//Acionando Função de retornar novo vetor com valores negativos
        double [] vetorNeg = CopiarVetorNeg (vetorX);

//Acionando procedimentos de imprimir os vetores X e Neg
        ExibirVetorX (vetorX);
        ExibirVetorNeg (vetorNeg);
    }

//Criando Procedimento para preencher vetorX
    public void PreencherVetorX (double [] vetorX) {
        Random randNum = new Random ();
        for (int i = 0; i < 10; i++) {
            vetorX [i] = randNum.NextDouble () * 200 - 100;
        }
    }
//Criando função para retornar novo vetor com valores negativos
    public double [] CopiarVetorNeg (double [] vetorX) {
//Declarando variável que vai contar quantos números negativos têm
        int N = 0;
//Criando comando foreach para pesquisar dentro do vetorX e contar variáveis negativas
        foreach (double item in vetorX) {
            if (item < 0) {
                N++;
            }
        }
//Declarando novo vetor que vai receber números negativos
        double [] vetorNeg = new double [N];
//Declarando variável index para receber os valores negativos
        int index = 0;
//Criando outro foreach para adicionar os números negativos ao novo vetor
        foreach (double item in vetorX) {
            if (item < 0) {
                vetorNeg [index] = item;
                index++;
            }
        }
//Comando return para retornar vetor
            return vetorNeg;
    }

//Criando procedimento para exibir vetorX
    public void ExibirVetorX (double [] vetorX) {
        Console.WriteLine ("vetorX: ");
        foreach (double item in vetorX) {
            Console.Write (item + " ");
            }
        }
//Criando procedimento para exibir vetorNeg
    public void ExibirVetorNeg (double [] vetorNeg) {
        Console.WriteLine ("vetorNeg: ");
        foreach (double item in vetorNeg) {
            Console.Write (item + " ");
        }
    }
}