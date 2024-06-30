using System;
using System.IO;

public class Questao09 {
// Definindo caminho fixo para o arquivo
    private string caminhoArquivo = @"C:\Users\USUÁRIO\Documents\ATP\Lista06\Arquivo para questão 09.txt";

// Criando orocedimento que gera menu para que o usuário execute a opção que desejar
    public void Rodar() {
        while (true) {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Inserir dados de alunos");
            Console.WriteLine("2. Ler dados de alunos");
            Console.WriteLine("3. Sair");
            string opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    InserirDadosAlunos();
                    break;
                case "2":
                    LerDadosAlunos();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

// Solicitando dados ao usuário e fazendo os registros
    private void InserirDadosAlunos() {
        using (StreamWriter writer = new StreamWriter(caminhoArquivo, true)) {
            while (true) {
                Console.WriteLine("Digite a matrícula do aluno (ou deixe em branco para sair):");
                string matricula = Console.ReadLine();
                if (string.IsNullOrEmpty(matricula)) {
                    break;
                }

                Console.WriteLine("Digite o telefone do aluno:");
                string telefone = Console.ReadLine();

                writer.WriteLine($"Matrícula: {matricula}, Telefone: {telefone}");
            }
        }
    }

// Criando procedimento para ler dados dos alunos
    private void LerDadosAlunos() {
        if (File.Exists(caminhoArquivo)) {
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            foreach (string linha in linhas) {
                Console.WriteLine(linha);
            }
        } else {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}
