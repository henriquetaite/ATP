using System;

class Program {
  public static void Main (string[] args) {

//Declarando as variáveis: L (número definido pelo usuário como posição final da série), a e b (armazenando 0 e 1 para indicar a sequência lógica da série) e soma (novo valor após somar os 2 anteriores)
    int L = 0, soma = 0, a = 0, b = 1;

//Solicitando ao usuário o número de posições que terá a série Fibonacci
    Console.WriteLine ("Digite um número para padronizar sua série Fibonacci");
      L = int.Parse (Console.ReadLine());

//Criando comando do-while para as somas só serem feitas antes que o número chegue no L
    while (a < L) {
      Console.Write (a + " ");
      soma += a;
      soma = a + b;
      a = b;
      b = soma;
    } 
  }
}