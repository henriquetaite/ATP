using System;
using System.IO;

public class Questao05 {
    public void Rodar() {
        // Definindo o caminho do arquivo
        string caminhoArquivo = @"C:\Users\USUÁRIO\Documents\ATP\Lista06\Arquivo para questão 05.txt";

        // Chama o método para imprimir conteúdo e quantidade de linhas
        ImprimirConteudoEQuantidadeLinhas(caminhoArquivo);
    }
    public static void ImprimirConteudoEQuantidadeLinhas(string caminhoArquivo) {
        try {
            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            // Imprime cada linha com seu número
            for (int i = 0; i < linhas.Length; i++) {
                Console.WriteLine($"Linha {i + 1}: {linhas[i]}");
            }

            // Imprime a quantidade total de linhas
            Console.WriteLine($"\nQuantidade total de linhas: {linhas.Length}");
        }
        catch (Exception) {
            // Exibe mensagem de erro caso não seja possível ler o arquivo
            Console.WriteLine($"Erro ao ler o arquivo! Verifique e tente novamente.");
        }
    }
}
