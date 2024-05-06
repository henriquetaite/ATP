using System;

class Program {
  public static void Main (string[] args) {

//Declarando as variáveis: 
    int cand1 = 0, cand2 = 0, cand3 = 0, cand4 = 0, nulo = 0, branco = 0, voto = 0;

//Criando comando do-while para o eleitor não votar em número inválido
      do {
        Console.WriteLine ("Digite o código correspondente ao seu voto");
        voto = int.Parse (Console.ReadLine());

//Condição para calcular o resto somente se o voto for válido
        if (voto > 6 || voto < 0) {
          Console.WriteLine ("Código inválido! Digite um número entre 1 e 6");
          voto = int.Parse (Console.ReadLine());
        }
        if (voto <= 6 && voto >= 1) {
          if (voto == 1)
            cand1++;
          else if (voto == 2)
            cand2++;
          else if (voto == 3)
            cand3++;
          else if (voto == 4)
            cand4++;
          else if (voto == 5)
            nulo++;
          else if (voto == 6)
            branco++;
        }
//Encerrando a votação, caso seja inserido um voto = 0
        if (voto == 0) {
          Console.WriteLine ("A quantidade de votos do candidato 1 é: {0}", cand1);
          Console.WriteLine ("A quantidade de votos do candidato 2 é: {0}", cand2);
          Console.WriteLine ("A quantidade de votos do candidato 3 é: {0}", cand3);
          Console.WriteLine ("A quantidade de votos do candidato 4 é: {0}", cand4);
          Console.WriteLine ("A quantidade de votos nulos é: {0}", nulo);
          Console.WriteLine ("A quantidade de votos em branco é: {0}", branco);
        }
      
      } while (voto != 0);

    }
  }