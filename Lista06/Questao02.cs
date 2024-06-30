using System;
public class Questao02 {
    public void Rodar() {

// Solicitando a frase ao usuário
Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        string fraseSemVogais = SemVogais(frase);

// Imprimindo frase sem vogais
        Console.WriteLine("Frase sem vogais: " + fraseSemVogais);
    }

    static string SemVogais(string frase) {
        string resposta = "";
        string vogais = "aeiouAEIOU";

        foreach (char c in frase) {
            if (!vogais.Contains(c))
            {
                resposta += c;
            }
        }
        return resposta;
    }
}