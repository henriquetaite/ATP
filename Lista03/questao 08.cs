using System;

class Program {
  public static void Main (string[] args) {

//Declarando as variáveis: L (número definido pelo usuário como posição final da série), a e b (armazenando 0 e 1 para indicar a sequência lógica da série) e soma (novo valor após somar os 2 anteriores)
  int L = 0, soma = 0, a = 0, b = 1;

//Solicitando ao usuário o número de posições que terá a série Fibonacci
    Console.WriteLine ("Digite a quantidade de números da série Fibonacci que você deseja ver");
      L = int.Parse (Console.ReadLine());
  
  //Criando comando for para definir o intervalo de posições da série a serem impressas
    for (int c = 0; c < L; c++) {
      Console.Write (a + " ");
      soma = a + b;
      a = b;
      b = soma;
    }
  }
}