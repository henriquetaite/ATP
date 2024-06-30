using System;
using System.IO;
using System.Linq;

public class Questao10 {
// Definindo caminho fixo para o arquivo
    private string caminhoArquivo = @"C:\Users\USUÁRIO\Documents\ATP\Lista06\Arquivo para questão 10.txt";
    public void Rodar() {
// Fazendo leitura dos números do arquivo
        double[] numeros = LerNumerosDoArquivo();

// Verificando se o arquivo contém números válidos
        if (numeros.Length == 0) {
            Console.WriteLine("Arquivo não contém números válidos ou está vazio! Verifique e tente novamente.");
            return;
        }

// Calculando o valor máximo, mínimo e a média dos números
        double valorMaximo = numeros.Max();
        double valorMinimo = numeros.Min();
        double media = numeros.Average();

// Imprimindo os resultados na tela
        Console.WriteLine($"Valor máximo: {valorMaximo}");
        Console.WriteLine($"Valor mínimo: {valorMinimo}");
        Console.WriteLine($"Média: {media}");
    }

// Criando função para ler os números do arquivo e retorná-los em vetor
    private double[] LerNumerosDoArquivo() {
        try {
// Verificando se o arquivo existe
            if (!File.Exists(caminhoArquivo)) {
                Console.WriteLine($"Arquivo '{caminhoArquivo}' não encontrado. Verifique e tente novamente.");
                return new double[0]; // Retorna um array vazio se o arquivo não existir
            }
// Fazendo leitura de todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(caminhoArquivo);

// Criando o vetor para armazenar os números
            double[] numeros = new double[linhas.Length];

// Percorrendo cada linha do arquivo
            for (int i = 0; i < linhas.Length; i++) {

// Tentando converter a linha para um número em ponto flutuante
                if (double.TryParse(linhas[i], out double numero)) {
                    numeros[i] = numero;
                }
            }
// Retornando apenas os números diferentes de zero
            return numeros.Where(num => num != 0).ToArray();
        } catch (Exception) {
            Console.WriteLine($"Erro ao ler o arquivo! Verifique e tente novamente.");
            return new double[0];
        }
    }
}
