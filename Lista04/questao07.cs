using System;
public class Questao07
{
    public static void Rodar()
    {
//Declarando variáveis
        int media, N;

//Solicitando quantidade N de alunos
        Console.WriteLine ("Quantas médias quer registrar?");
        N = int.Parse (Console.ReadLine());

//Criando comando for para ler somente a quantidade de médias informada
        for (int i = 1; i <= N; i++) {

//Solicitando e registrando média
        Console.WriteLine ("Digite a média do aluno");
        media = int.Parse (Console.ReadLine());

//Acionando o procedimento
        ConceituandoMedia (media);
    }
}
//Criando procedimento para ler cada média
    static void ConceituandoMedia (int media) {

//Criando condicional para conceituar dentro dos critérios
        if (media <= 39 && media >= 0) {
            Console.WriteLine ("Conceito F");
        }
        else if (media >= 40 && media <= 59) {
            Console.WriteLine ("Conceito E");
        }
        else if (media >= 60 && media <= 69) {
            Console.WriteLine ("Conceito D");
        }
        else if (media >= 70 && media <= 79) {
            Console.WriteLine ("Conceito C");
        }
        else if (media >= 80 && media <= 89) {
            Console.WriteLine ("Conceito B");
        }
        else if (media >= 90) {
            Console.WriteLine ("Conceito A");
        }
    }
}
