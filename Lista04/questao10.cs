using System;
public class Questao10
{
    public void Rodar()
    {
//Declarando variáveis
        int idade;
        string categoria;

//Criando método do while para ler idades até o usuário encerrar
        do {

//Solicitando idade dos nadadores
            Console.WriteLine ("Digite a idade do nadador para saber sua categoria ou N para encerrar");
            idade = int.Parse (Console.ReadLine());

//Acionando a função que vai retornar a categoria
            categoria = RetornarCategoria (idade);
            Console.WriteLine ("Nadador categoria: {0}", categoria);
        }
        while (idade >= 5);
    }
//Criando função para reotornar categoria conforme idade
    public static string RetornarCategoria (int idade) {
        if (idade >= 5 && idade <= 7) {
            return "F";
        }
        else if (idade >= 8 && idade <= 10) {
            return "E";
        }
        else if (idade >= 11 && idade <= 13) {
            return "D";
        }
        else if (idade >= 14 && idade <= 15) {
            return "C";
        }
        else if (idade >= 16 && idade <= 17) {
            return "B";
        }
        else if (idade >= 18) {
            return "A";
        }
        else {
            return "Idade fora do intervalo.";
        }
    }
}