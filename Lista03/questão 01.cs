using System;

class Program {
  public static void Main (string[] args) {

    int num, contnegativos = 0, contzeros = 0, contpositivos = 0;
    string opcao;

    do {
        Console.WriteLine ("Informe um número: ");
        num = int.Parse (Console.ReadLine());

        if (num < 0)
          contnegativos++;
        else if (num == 0)
          contzeros++;
        else 
          contpositivos++;

        Console.WriteLine ("Deseja informar outro número (s/n)? ");
        opcao = Console.ReadLine();
    } while (opcao == "s");

    Console.WriteLine ("Negativos informados: " + contnegativos);
    Console.WriteLine ("Zeros informados: " + contzeros);
    Console.WriteLine ("Positivos informados: " + contpositivos);
  }
}