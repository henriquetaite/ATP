using System;
public class Questao10 {
    public void Rodar() {

// Declarar e preencher a matriz M(10,10)
        int[,] matrizM = new int[10, 10];
        PreencherMatriz(matrizM);

// Imprimir a matriz original
        Console.WriteLine("Matriz Original:");
        ImprimirMatriz(matrizM);

// Trocar a linha 2 com a linha 8
        TrocarLinhas(matrizM, 2, 8);
        Console.WriteLine("\nMatriz após trocar a linha 2 com a linha 8:");
        ImprimirMatriz(matrizM);

// Trocar a coluna 4 com a coluna 10
        TrocarColunas(matrizM, 4, 9);
        Console.WriteLine("\nMatriz após trocar a coluna 4 com a coluna 10:");
        ImprimirMatriz(matrizM);

// Trocar a diagonal principal com a diagonal secundária
        TrocarDiagonais(matrizM);
        Console.WriteLine("\nMatriz após trocar a diagonal principal com a diagonal secundária:");
        ImprimirMatriz(matrizM);

// Trocar a linha 5 com a coluna 10
        TrocarLinhaComColuna(matrizM, 5, 9);
        Console.WriteLine("\nMatriz após trocar a linha 5 com a coluna 10:");
        ImprimirMatriz(matrizM);
    }

// Procedimento para preencher uma matriz 10x10 com valores aleatórios
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

// Procedimento para trocar duas linhas de uma matriz
    public static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
    {
        for (int i = 0; i < matriz.GetLength(1); i++)
        {
            int temp = matriz[linha1, i];
            matriz[linha1, i] = matriz[linha2, i];
            matriz[linha2, i] = temp;
        }
    }

// Procedimento para trocar duas colunas de uma matriz
    public static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[i, coluna1];
            matriz[i, coluna1] = matriz[i, coluna2];
            matriz[i, coluna2] = temp;
        }
    }

// Procedimento para trocar a diagonal principal com a diagonal secundária
    public static void TrocarDiagonais(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, n - 1 - i];
            matriz[i, n - 1 - i] = temp;
        }
    }

// Procedimento para trocar uma linha com uma coluna de uma matriz
    public static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[linha, i];
            matriz[linha, i] = matriz[i, coluna];
            matriz[i, coluna] = temp;
        }
    }
}
