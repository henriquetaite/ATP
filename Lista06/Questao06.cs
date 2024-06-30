using System;
using System.IO;

public class Questao06 {
    public void Rodar() {
        Console.WriteLine("Digite um número:");
        if (!int.TryParse(Console.ReadLine(), out int numero)) {
            Console.WriteLine("Número inválido. Encerrando o programa.");
            return;
        }

// Obtém os divisores e calcula a soma
        int somaDivisores = CalcularDivisores(numero);

// Imprime os divisores na tela
        Console.WriteLine($"Divisores de {numero}: ");
        ImprimirDivisores(numero);

// Salva a soma dos divisores no arquivo criado especificamente para a questão 06
        SalvarSomaDivisores(numero, somaDivisores, @ "Arquivo para questão 06");
        Console.WriteLine($"Soma total dos divisores salva no arquivo 'Arquivo para questão 06'.");
    }

// Criando função que calcula os divisores e retorna a soma demandada
    public static int CalcularDivisores(int numero) {
        int soma = 0;
        for (int i = 1; i <= numero; i++) {
            if (numero % i == 0) {
                soma += i;
            }
        }
        return soma;
    }

// Criando função que imprime os divisores na tela
    public static void ImprimirDivisores(int numero) {
        for (int i = 1; i <= numero; i++) {
            if (numero % i == 0) {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine(); // Pula uma linha após imprimir os divisores
    }

// Criando função para salvar a soma dos divisores em um arquivo texto
    public static void SalvarSomaDivisores(int numero, int soma) {
        try {
            using (StreamWriter writer = new StreamWriter("soma_divisores.txt")) {
                writer.WriteLine($"Número: {numero}");
                writer.WriteLine($"Soma dos divisores: {soma}");
            }
        }
        catch (Exception) {
            Console.WriteLine($"Erro ao salvar o arquivo! Verifique e tente novamente.");
        }
    }
}
