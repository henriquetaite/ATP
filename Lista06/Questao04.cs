using System;
using System.IO;

public class Questao04
{
    public void Rodar() {
// Definindo o caminho do arquivo
        string caminhoArquivo = @"C:\Users\USUÁRIO\Documents\ATP\Lista06\Arquivo para questão 04.txt";
        
// Chama o método para contar caracteres 'a'
        ContarCaracteresA(caminhoArquivo);
    }

    public static void ContarCaracteresA(string caminhoArquivo) {
        try {

// Lê o conteúdo do arquivo de texto
            string conteudo = File.ReadAllText(caminhoArquivo);

// Conta a quantidade de caracteres 'a'
            int quantidadeA = 0;
            foreach (char c in conteudo) {
                if (char.ToLower(c) == 'a') {
                    quantidadeA++;
                }
            }

// Imprime a quantidade na tela
            Console.WriteLine($"Quantidade de caracteres 'a': {quantidadeA}");
        }
        catch (Exception ex) {
// Exibe mensagem de erro caso não seja possível ler o arquivo
            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
        }
    }
}
