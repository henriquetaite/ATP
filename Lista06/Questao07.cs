using System;
using System.IO;

public class Questao07 {
    public void Rodar() {
        Console.WriteLine("Digite a quantidade de letras que deseja inserir:");
        if (!int.TryParse(Console.ReadLine(), out int quantidadeLetras) || quantidadeLetras <= 0) {
            Console.WriteLine("Quantidade inválida. Encerrando o programa.");
            return;
        }

// Solicitando ao usuário para inserir as letras
        string letrasInseridas = SolicitarLetras(quantidadeLetras);

// Definindo o caminho do arquivo para questão 07
        string caminhoArquivo = @"C:\Users\USUÁRIO\Documents\ATP\Lista06\Arquivo para questão 07.txt";

// Salvando as letras no arquivo
        SalvarLetrasNoArquivo(letrasInseridas, caminhoArquivo);
        Console.WriteLine($"Letras salvas no arquivo '{caminhoArquivo}'.");

// Calcula e imprime a quantidade de vogais no arquivo
        int quantidadeVogais = ContarVogaisNoArquivo(caminhoArquivo);
        Console.WriteLine($"Quantidade de vogais (a, e, i, o, u) no arquivo: {quantidadeVogais}");
    }

// Criando função para solicitar ao usuário que insira as letras
    public static string SolicitarLetras(int quantidadeLetras) {
        Console.WriteLine($"Digite as {quantidadeLetras} letras:");
        return Console.ReadLine();
    }

// Criando função para salvar as letras no arquivo texto para a questão 07
    public static void SalvarLetrasNoArquivo(string letras, string caminhoArquivo) {
        try {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo)) {
                writer.WriteLine(letras);
            }
        }
        catch (Exception) {
            Console.WriteLine($"Erro ao salvar o arquivo! Verifique e tente novamente.");
        }
    }

// Criando função para contar a quantidade de vogais salvas no arquivo para a questão 07
    public static int ContarVogaisNoArquivo(string caminhoArquivo) {
        try {
            string conteudo = File.ReadAllText(caminhoArquivo);

            int quantidadeVogais = 0;
            foreach (char c in conteudo) {
                if ("aeiouAEIOU".Contains(c)) {
                    quantidadeVogais++;
                }
            }

            return quantidadeVogais;
        }
        catch (Exception) {
            Console.WriteLine($"Erro ao contar as vogais no arquivo! Verifique e tente novamente.");
            return 0;
        }
    }
}
