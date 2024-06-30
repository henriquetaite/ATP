using System;
public class Questao01 {
    public void Rodar() {

// Solicitando frase ao usuário
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        int contadorEspacos = 0;

// Percorrendo cada caracter para contar os espaços em branco
        foreach (char c in frase) {
            if (c == ' ') {
                contadorEspacos++;
            }
        }
        Console.WriteLine("Número de espaços em branco na frase: " + contadorEspacos);
    }
}
