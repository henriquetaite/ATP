using System;
public class Questao07
{
    public void Rodar()
    {
// Declarar e preencher a matriz 5x5
        int[,] matriz = new int[5, 5];
        PreencherMatriz(matriz);

// Imprimir a matriz
        Console.WriteLine("Matriz M:");
        ImprimirMatriz(matriz);

// Calcular e imprimir cada uma das somas solicitadas
        int somaLinha4 = SomaLinha4(matriz);
        Console.WriteLine("Soma da linha 4: " + somaLinha4);

        int somaColuna2 = SomaColuna2(matriz);
        Console.WriteLine("Soma da coluna 2: " + somaColuna2);

        int somaDiagonalPrincipal = SomaDiagonalPrincipal(matriz);
        Console.WriteLine("Soma da diagonal principal: " + somaDiagonalPrincipal);

        int somaDiagonalSecundaria = SomaDiagonalSecundaria(matriz);
        Console.WriteLine("Soma da diagonal secundária: " + somaDiagonalSecundaria);

        int somaTodosElementos = SomaTodosElementos(matriz);
        Console.WriteLine("Soma de todos os elementos da matriz: " + somaTodosElementos);
    }

// Procedimento para preencher a matriz 5x5 com valores aleatórios
    public static void PreencherMatriz(int[,] matriz)
    {
        Random rand = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = rand.Next(1, 101); // Preenchendo a matriz com números aleatórios de 1 a 100
            }
        }
    }

// Procedimento para imprimir a matriz
    public static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

// Função para calcular a soma da linha 4 (índice 3)
    public static int SomaLinha4(int[,] matriz)
    {
        int soma = 0;
        for (int j = 0; j < 5; j++)
        {
            soma += matriz[3, j];
        }
        return soma;
    }

// Função para calcular a soma da coluna 2 (índice 1)
    public static int SomaColuna2(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, 1];
        }
        return soma;
    }

// Função para calcular a soma da diagonal principal
    public static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }

// Função para calcular a soma da diagonal secundária
    public static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, 4 - i];
        }
        return soma;
    }

// Função para calcular a soma de todos os elementos da matriz
    public static int SomaTodosElementos(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }
}
