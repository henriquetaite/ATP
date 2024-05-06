using System;

class Program {
  public static void Main (string[] args) {

//Declarando variáveis
    double E = 1; //Declarando como double pois envolve resultado de divisões
    int fatorial = 1, N;

//Solicitando e registrando o número N ao usuário
    Console.WriteLine ("Favor, informe um número inteiro positivo");
    N = int.Parse (Console.ReadLine());

//Condição para garantir que teremos um número válido para o cálculo proposto
    if (N < 0) {
      Console.WriteLine("Número inválido! Por favor, digite um número maior ou igual a zero");
    }

//Criando condição e comando, caso a situação não seja a descrita anteriormente
    else {
      for (int c = 1; c <= N; c++) {
        fatorial *= c;
        E += 1 / fatorial;
      }
      Console.WriteLine ("O valor de E é: {0}", E);
    }
  }
}