using System;
public class Questao08
{
    public void Rodar()
    {
// Declarar e preencher a matriz 4x4
        int[,] matriz = new int[4, 4];
        PreencherMatriz(matriz);

// Imprimir a matriz
        Console.WriteLine("Matriz 4x4:");
        ImprimirMatriz(matriz);

// Calcular e imprimir a soma dos elementos abaixo da diagonal principal
        int somaAbaixoDiagonalPrincipal = SomaAbaixoDiagonalPrincipal(matriz);
        Console.WriteLine("Soma dos elementos abaixo da diagonal principal: " + somaAbaixoDiagonalPrincipal);

// Imprimir os elementos da diagonal principal
        Console.WriteLine("Elementos da diagonal principal:");
        ImprimirDiagonalPrincipal(matriz);
    }

// Procedimento para preencher a matriz 4x4 com valores aleatórios
    public static void PreencherMatriz(int[,] matriz)
    {
        Random rand = new Random();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = rand.Next(1, 101); // Preenchendo a matriz com números aleatórios de 1 a 100
            }
        }
    }

// Procedimento para imprimir a matriz
    public static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

// Função para calcular a soma dos elementos abaixo da diagonal principal
    public static int SomaAbaixoDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 1; i < 4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }

// Procedimento para imprimir os elementos da diagonal principal
    public static void ImprimirDiagonalPrincipal(int[,] matriz)
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }
    }
}