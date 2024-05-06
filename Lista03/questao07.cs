using System;

class Program {
  public static void Main (string[] args) {

//Declarando as variáveis: n (número digitado pelo usuário), S (resultado solicitado pelo enunciado) e valor (armazena parte do cálculo da expressão)
    int n; //Em int pois é solicitado um número inteiro
    double S = 1, valor = 0; //Em double pois são resultados que envolvem divisão

//Solicitando o número inteiro positivo ao usuário
    Console.WriteLine ("Digite um número inteiro maior que zero");
    n = int.Parse (Console.ReadLine());

//Condição para garantir que o usuário digite um número positivo
    if (n <= 0) {
      Console.WriteLine ("Número inválido! Digite um número maior que zero.");
      n = int.Parse (Console.ReadLine());
    }

//Criando o método while para executar o cálculo, caso receba um número inteiro positivo
        for (int c = 2; c <= n; c++) {
        valor = 1.0 / c;
        S += valor;
      }
//Imprimindo resultado solicitado pelo enunciado
      Console.WriteLine("O número {0} gera um valor de S igual a: {1}", n, S);
  }
}