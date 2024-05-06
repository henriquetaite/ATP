using System;

class Program {
  public static void Main (string[] args) {

//Declarando as variáveis: x (número digitado) e fatorial (fatorial do número digitado)
  int x, fatorial = 1;

//Solicitando ao usuário que digite um número natural
  Console.WriteLine ("Digite um número natural");
    x = int.Parse (Console.ReadLine()); 
//Criando comando para caso o número seja negativo, o usuário informar um número válido para seguir com o programa 
      if (x < 0) {
        Console.WriteLine ("Número inválido! Digite outro, por favor.");
      }

//Criando comandos para situações em que o número inteiro digitado é diferente de um número negativo    
    else {  
//Definindo a contagem do intervalo que o número natural deve ser multiplicado e os resultados somados
      for (int c = 1; c <= x; c++) {
        fatorial *= c;
      }
//Imprimindo fatorial do número digitado
      Console.WriteLine ("O fatorial do número que você digitou é: {0}", fatorial);
    }
  }
}