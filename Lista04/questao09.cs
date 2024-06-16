using System;
public class Questao09
{
    public void Rodar()
    {
// Declarar e preencher as matrizes A e B
        int[,] matrizA = new int[4, 6];
        int[,] matrizB = new int[4, 6];

        PreencherMatriz(matrizA);
        PreencherMatriz(matrizB);

// Imprimir as matrizes A e B
        Console.WriteLine("Matriz A:");
        ImprimirMatriz(matrizA);
        Console.WriteLine("\nMatriz B:");
        ImprimirMatriz(matrizB);

// Calcular e imprimir a matriz S (soma de A e B)
        int[,] matrizS = SomaMatrizes(matrizA, matrizB);
        Console.WriteLine("\nMatriz S (Soma de A e B):");
        ImprimirMatriz(matrizS);

// Calcular e imprimir a matriz D (diferença de A e B)
        int[,] matrizD = DiferencaMatrizes(matrizA, matrizB);
        Console.WriteLine("\nMatriz D (Diferença de A e B):");
        ImprimirMatriz(matrizD);
    }

// Procedimento para preencher uma matriz 4x6 com valores aleatórios
    public static void PreencherMatriz(int[,] matriz)
    {
        Random rand = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rand.Next(1, 101); // Preenchendo a matriz com números aleatórios de 1 a 100
            }
        }
    }

// Procedimento para imprimir uma matriz
    public static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

// Função para calcular a soma de duas matrizes
    public static int[,] SomaMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizS = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizS[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }
        return matrizS;
    }

// Função para calcular a diferença de duas matrizes
    public static int[,] DiferencaMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizD = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizD[i, j] = matrizA[i, j] - matrizB[i, j];
            }
        }
        return matrizD;
    }
}
