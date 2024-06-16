using System;
public class Questao05 {
    public void Rodar() {
// Sorteando 3 números entre 10 e 50
        int[] numerosSorteados = SortearNumeros();

        Console.WriteLine("Tente adivinhar um dos números sorteados entre 10 e 50.");

        // Lendo as tentativas do usuário até que ele acerte um número sorteado
        TentarAdivinhar(numerosSorteados);

        Console.WriteLine("Você acertou um número sorteado!");
    }

    // Função que sorteia 3 números entre 10 e 50 e retorna em um vetor
    public static int[] SortearNumeros()
    {
        Random rand = new Random();
        int[] numeros = new int[3];

        for (int i = 0; i < 3; i++)
        {
            numeros[i] = rand.Next(10, 51);
        }

        Console.WriteLine("Números sorteados: ");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        return numeros;
    }

    // Procedimento que lê as tentativas do usuário até que ele acerte um número sorteado
    public static void TentarAdivinhar(int[] numerosSorteados)
    {
        bool acertou = false;

        while (!acertou)
        {
            Console.WriteLine("Digite sua tentativa:");
            int tentativa = int.Parse(Console.ReadLine());

            foreach (int num in numerosSorteados)
            {
                if (tentativa == num)
                {
                    acertou = true;
                    break;
                }
            }

            if (!acertou)
            {
                Console.WriteLine("Você não acertou. Tente novamente.");
            }
        }
    }
}