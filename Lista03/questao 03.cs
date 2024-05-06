using System;

class Program {
  public static void Main (string[] args) {

//Declarando variáveis: tn (divisíveis por 3 e 9 ao mesmo tempo), d (divisíveis por 2), cinc (divisíveis por 5) e x (números informados)
    int tn = 0, d = 0, cinc = 0, x;

//Criando função for para definir o intervalo de 10 números
    for (int c = 1; c <= 10; c++) {

//Solicitando 10 números ao usuário e registrando-os na variável x
      Console.WriteLine ("Por favor, digite 10 números aleatórios.");
      x = int.Parse (Console.ReadLine());

//Criando função if para imprimir se o número atende as condições do enunciado ou não
        if (x % 3 == 0 && x % 9 == 0)
          tn++;

        if (x % 2 == 0) 
          d++;

        if (x % 5 == 0)
          cinc++;      
//Não foi usado "else if" acima pois um número pode ser divisível por 2 e por 5 ao mesmo tempo
      
        else
          Console.WriteLine ("Número não é divisível pelos valores");
      }
    
//Imprimindo resultados
          Console.WriteLine ("A quantidade de números divisíveis por 3 e 9 é: {0}", tn);
          Console.WriteLine ("A quantidade de números divisíveis por 2 é: {0}", d);
          Console.WriteLine ("A quantidade de números divisíveis por 5 é: {0}", cinc);
      }
    }
