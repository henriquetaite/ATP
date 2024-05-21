using System;
public class Questao03 {
    public static void Rodar() {

 int N = 0; //Variável para armazenar o número de alunos

//Solicitando e registrando a quantidade de alunos
    Console.WriteLine ("Digite a quantidade de alunos");
    N = int.Parse (Console.ReadLine());

//Criando comando for para registrar 3 notas para cada aluno
    for (int i = 0; i < N; i++) { //i < N porque começa do 0 e é int, aí vai contar 1 a menos que N no final

//Declarando variáveis
    double x = 0, y = 0, z = 0; //Variáveis para armazenar as notas
    char opcao; //Variável para armazenar a opção de média desejada pelo usuário

//Solicitando e registrando as notas
        Console.WriteLine ($"Aluno {i + 1}:");
        Console.WriteLine ("Digite 3 notas");
        x = double.Parse (Console.ReadLine());
        y = double.Parse (Console.ReadLine());
        z = double.Parse (Console.ReadLine());

//Solicitando o tipo de média que o usuário deseja
        Console.WriteLine ("Digite 'A' para média aritmética e 'P' para média ponderada");
        opcao = char.Parse (Console.ReadLine());

//Criando condicional para fazer um procedimento para cada situação
            if (opcao == 'A') {
                CalcularMediaAritmetica (x, y, z);
            }
            else if (opcao == 'P') {
                CalcularMediaPonderada (x, y, z);
            }
            else {
                Console.WriteLine ("Opção inválida! Digite 'A' ou 'P' ");
                opcao = char.Parse (Console.ReadLine());
            }
        } 
    }
//Criando procedimento da média aritmética
        static void CalcularMediaAritmetica (double x, double y, double z) {
            double media = (x + y + z) / 3;
            Console.WriteLine ("A média aritmética é {0}:", media); 
        }
//Criando procedimento da média ponderada
        static void CalcularMediaPonderada (double x, double y, double z) {
            double media = (x * 5 + y * 3 + z * 2) / (5 + 3 + 2);
            Console.WriteLine ("A média ponderada é {0}:", media);
        }
}