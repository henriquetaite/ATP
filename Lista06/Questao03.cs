using System;
public class Questao03 {
    public void Rodar() {

// Solicitando ao usuário que insira a string a ser codificada
        Console.WriteLine("Digite a string a ser codificada:");
        string stringOriginal = Console.ReadLine();

// Acionando função para codificar a string usando o Código de César
        string stringCodificada = CodificarCesar(stringOriginal, 3);

// Imprimindo a string original e a string codificada
        Console.WriteLine("String Original: " + stringOriginal);
        Console.WriteLine("Nova String Codificada: " + stringCodificada);
    }

// Codificando a string com o Código de César
    static string CodificarCesar(string texto, int deslocamento) {

// Convertendo a string em um array de caracteres para a manipulação ficar mais fácil
        char[] caracteres = texto.ToCharArray();

// Loop através de cada caractere na string
        for (int i = 0; i < caracteres.Length; i++) {

// Conferindo se o caractere é igual a uma letra
            if (char.IsLetter(caracteres[i])) {

// Determinando se a letra é maiúscula ou minúscula
                char baseLetra = char.IsUpper(caracteres[i]) ? 'A' : 'a';

// Fazendo o cálculo para deslocar a letra 3 "casas" à frente
                caracteres[i] = (char)(((caracteres[i] - baseLetra + deslocamento) % 26) + baseLetra);
            }
        }
// Fazendo os novos caracteres se transformarem em strings e retornarem na tela
        return new string(caracteres);
    }
}

