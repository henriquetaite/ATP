using System;
public class Questao02 {
    public static void Rodar() {

//Declarando e inicializando vetor que será usado em 2 procedimentos diferentes
        double [] vetorNotas = new double [10];

//Acionando procedimento que preenche o vetor
        PreencherNotas (vetorNotas);

//Acionando procedimento que faz os cálculos solicitados
        CalcularNotas (vetorNotas);
    }
//Criando procedimento que vai preencher o vetor com as Notas
        public static void PreencherNotas (double [] vetorNotas) {

//Solicitando que o usuário preencha o vetor com as 10 notas
            Console.WriteLine ("Digite as notas dos 10 alunos");

//Criando comando for para armazenar as notas no vetor
            for (int i = 0; i < 10; i++) {
                Console.Write ("Digite a nota {0}:", i + 1);
                vetorNotas [i] = double.Parse (Console.ReadLine());
            }
        }
//Criando procedimento que vai fazer os cálculos e contagem solicitados (acima = quantidade de alunos acima da média)
        public static void CalcularNotas (double [] vetorNotas) {

//Declarando variáveis necessárias para cálculos
            double soma = 0, media = 0;
            int acima = 0;

//Fazendo comando for para contar os alunos acima da média
            for (int i = 0; i < 10; i++) {
                soma += vetorNotas [i];
            }
//Calculando a média
            media = (soma / 10);

//Criando comando for para fazer demais cálculos
            for (int i = 0; i < 10; i++) {

//Criando comando if para contar um aluno, se ele estiver acima da média
                if (vetorNotas [i] > media) {
                    acima++;
                }
            }
//Imprimindo resultados solicitados
            Console.WriteLine ("A média da turma é " + media + " e {0} alunos estão acima dela", acima);
        }
    }