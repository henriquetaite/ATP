using System;
public class Questao04 {
    public void Rodar() {
 // Declarando e inicializando os vetores X e Y
        int[] vetorX = new int[10];
        int[] vetorY = new int[10];
        
// Preenchendo os vetores X e Y
        PreencherVetor(vetorX, "X");
        PreencherVetor(vetorY, "Y");

// Gerando o novo vetor Z com elementos intercalados de X e Y
        int[] vetorZ = IntercalarVetores(vetorX, vetorY);

// Exibindo os vetores
        Console.WriteLine("Vetor X:");
        ExibirVetor(vetorX);

        Console.WriteLine("Vetor Y:");
        ExibirVetor(vetorY);

        Console.WriteLine("Vetor Z (intercalado):");
        ExibirVetor(vetorZ);
    }

// Procedimento para preencher um vetor com 10 elementos
    public static void PreencherVetor(int[] vetor, string nome)
    {
        Random randNum = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = randNum.Next(1, 101); // Preenche com números aleatórios de 1 a 100
        }
    }

// Procedimento para exibir o conteúdo de um vetor
    public static void ExibirVetor(int[] vetor)
    {
        foreach (int item in vetor)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

// Procedimento para intercalar dois vetores em um novo vetor
    public static int[] IntercalarVetores(int[] vetorX, int[] vetorY)
    {
        int[] vetorZ = new int[vetorX.Length + vetorY.Length];
        int j = 0, k = 0;
        for (int i = 0; i < vetorZ.Length; i++)
        {
            if (i % 2 == 0)
            {
                vetorZ[i] = vetorX[j++];
            }
            else
            {
                vetorZ[i] = vetorY[k++];
            }
        }
        return vetorZ;
    }
}