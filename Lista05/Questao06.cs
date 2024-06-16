using System;
public class Questao06 {
    public void Rodar() {

// Declarar e preencher o vetor com temperaturas de outubro
        double[] temperaturas = new double[31];
        PreencherTemperaturas(temperaturas);

// Calcular e imprimir a menor e a maior temperatura
        double menorTemp = CalcularMenorTemperatura(temperaturas);
        double maiorTemp = CalcularMaiorTemperatura(temperaturas);
        Console.WriteLine("Menor temperatura: " + menorTemp + "°C");
        Console.WriteLine("Maior temperatura: " + maiorTemp + "°C");

// Calcular e imprimir a temperatura média
        double temperaturaMedia = CalcularTemperaturaMedia(temperaturas);
        Console.WriteLine("Temperatura média: " + temperaturaMedia + "°C");

// Calcular e imprimir o número de dias com temperatura inferior à média
        int diasAbaixoMedia = ContarDiasAbaixoMedia(temperaturas, temperaturaMedia);
        Console.WriteLine("Número de dias com temperatura abaixo da média: " + diasAbaixoMedia);
    }

// Função para preencher o vetor com temperaturas aleatórias entre 15°C e 40°C
    public static void PreencherTemperaturas(double[] temperaturas)
    {
        Random rand = new Random();
        for (int i = 0; i < temperaturas.Length; i++)
        {
            temperaturas[i] = rand.Next(15, 40) + rand.NextDouble(); // Gera um número aleatório entre 15 e 40 com casas decimais
        }
    }

// Função para calcular a menor temperatura
    public static double CalcularMenorTemperatura(double[] temperaturas)
    {
        double menorTemp = temperaturas[0];
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < menorTemp)
            {
                menorTemp = temperaturas[i];
            }
        }
        return menorTemp;
    }

// Função para calcular a maior temperatura
    public static double CalcularMaiorTemperatura(double[] temperaturas)
    {
        double maiorTemp = temperaturas[0];
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > maiorTemp)
            {
                maiorTemp = temperaturas[i];
            }
        }
        return maiorTemp;
    }

// Função para calcular a temperatura média
    public static double CalcularTemperaturaMedia(double[] temperaturas)
    {
        double soma = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            soma += temperaturas[i];
        }
        return soma / temperaturas.Length;
    }

// Função para contar o número de dias com temperatura abaixo da média
    public static int ContarDiasAbaixoMedia(double[] temperaturas, double temperaturaMedia)
    {
        int contagem = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < temperaturaMedia)
            {
                contagem++;
            }
        }
        return contagem;
    }
}