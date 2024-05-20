using System;
public class Questao09
{
    public static void Rodar()
    {
//Declarando variáveis: total (total de alunos) e soma (soma das notas entre 6 e 10)
        double nota = 0, media = 0, soma = 0;
        int total = 0;

//Criando comando do while para registrar várias notas
       do {

//Solicitando notas ao usuário
            Console.WriteLine ("Digite as notas dos alunos ou um número fora do intervalo 0 a 10 para parar");
            nota = double.Parse (Console.ReadLine());

//Criando comando if para ler e calcular somente notas entre 6 e 10
        if (nota >= 6 && nota <= 10) {
            soma += nota;
            total++;
        }
//Criando condicional para acionar a função quando um valor fora do intervalo for digitado
            if (nota < 0 || nota > 10) {
                media = CalcularMedia (nota, media, total, soma);
                Console.WriteLine ("A média dos alunos que obtiveram notas entre 6 e 10 é: {0}", media);
            }
       }
        while (nota >= 0 && nota <= 10);
    }
//Criando função para calcular média das notas maiores que 6
    public static double CalcularMedia (double nota, double media, int total, double soma) {

//Fazendo cálculo da média
        media = soma / total;

//Fazendo comando return para retornar o valor da média 
        return media;
    }
}