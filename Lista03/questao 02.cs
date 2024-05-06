using System;

class Program {
  public static void Main (string[] args) {

//Declarando variáveis para ler os números, contá-los e informar a porcentagem solicitada
    int num, contnum = 0, contpositivos = 0, contnegativos = 0, contzeros = 0;
    double p = 0, n = 0, z = 0;
    string opcao;

//Comando para contar números positivos, negativos ou zeros, enquanto o usuário desejar digitar mais números
    do {
      Console.WriteLine ("Por favor, informe um número");
      num = int.Parse (Console.ReadLine());
      
      if (num > 0)
        contpositivos++;
      else if (num < 0)
        contnegativos++;
      else
        contzeros++;

      Console.WriteLine ("Deseja digitar mais um número (s/n)? ");
      opcao = Console.ReadLine();
      
    } while (opcao == "s");

//Calculando total de números digitados
    contnum = contpositivos + contnegativos + contzeros;

//Fazendo os cálculos para obter as porcentagens
    p = (double) contpositivos / contnum * 100;
    n = (double) contnegativos / contnum * 100;
    z = (double) contzeros / contnum * 100;

//Imprimindo as porcentagens solicitadas
    Console.WriteLine ("A porcentagem de números positivos no total digitado é de: {0:F2}%", p);
    Console.WriteLine ("A porcentagem de números negativos no total digitado é de: {0:F2}%", n);
    Console.WriteLine ("A porcentagem de zeros no total digitado é de: {0:F2}%", z);
  }
}