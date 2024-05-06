using System;

class Program {
  public static void Main (string[] args) {

//Declarando variáveis: sal (salário), filhos (número de filhos de cada habitante), ts (soma de todos os salários), tf (soma de todos os filhos), ms (média salarial), mf (média de filhos por habitante), maiorS (maior salário de todos), menorC (porcentagem de quem tem salário menor que R$ 100) e pop (total de pessoas que respondeu)
    double sal = 0, filhos = 0, ts = 0, tf = 0, ms = 0, mf = 0, maiorS = 0, menorC = 0, pop = 0;

//Criando função do-while para fazer os cálculos enquanto um salário negativo não é registrado
    do {
//Solicitando e registrando os dados para realização das análises e cálculos
      Console.WriteLine ("Qual o seu salário?");
      sal = double.Parse (Console.ReadLine());

//Condição para não perguntar e nem registrar o número de filhos, caso o salário informado seja negativo
      if (sal >= 0) {
        Console.WriteLine ("Quantos filhos você tem?");
        filhos = int.Parse (Console.ReadLine());
        
        ts += sal;
        tf += filhos;
        
        if (sal <= 100)
          menorC++;
        
        if (sal > maiorS)
          maiorS = sal;
  
        if (sal >= 0)
          pop++;
  
  //Realizando os cálculos para ter os resultados solicitados pela prefeitura
        ms = ts / pop;
        mf = tf / pop;
      }
    } while (sal >= 0);

//Imprimindo resultados para a prefeitura
    Console.WriteLine ("A média salarial da população é de: {0}", ms);
    Console.WriteLine ("A média de filhos de cada habitante é de: {0}", mf);
    Console.WriteLine ("O maior salário da população é de: {0}", maiorS);
    Console.WriteLine ("A porcentagem de pessoas que ganham até R$ 100,00 é de:{0}%", (menorC/pop * 100));
  }
}