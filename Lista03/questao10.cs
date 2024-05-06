using System;

class Program {
  public static void Main (string[] args) {

//Declarando as variáveis: compra (preço de compra), venda (preço de venda), tc (valor total de compra), tv (valor total de venda), lucrop (lucro percentual de cada venda), lucrot (lucro total final), lp (mercadorias que deram lucro menor que 10%), lm (mercadorias que deram lucro entre 10 e 20%) e lg (mercadorias que deram lucro maior que 20%) 
  double compra = 0, venda = 0, tc = 0, tv = 0, lucrop = 0, lucrot = 0, lp = 0, lm = 0, lg = 0;

//Criando a função while para fazer os registros e cálculos somente enquanto o valor de compra informado for positivo
    do {
//Solicitando ao empresário o preço de compra e de venda da mercadoria
      Console.WriteLine ("Informe o valor de compra da mercadoria?");
      compra = double.Parse (Console.ReadLine());

      if (compra > 0) {
      
      Console.WriteLine ("Qual o valor de venda da mercadoria?");
      venda = double.Parse (Console.ReadLine());

//Atualizando o valor de compra total e venda total com cada quantidade que é inserida
      tc += compra;
      tv += venda;
      lucrop = (venda - compra) / compra * 100; 
      lucrot = tv - tc;

//Condicional para dividir o lucro das mercadorias nos seus respectivos grupos
      if (lucrop < 10) 
          lp++;
  
        else if (lucrop >= 10 && lucrop <= 20)
          lm++;
          
        else 
          lg++;
      }
    } while (compra > 0);
//Imprimindo resultados de cada grupo de lucro
    Console.WriteLine ("A quantidade de mercadorias que geram menos de 10% de lucro é: {0}", lp);
    Console.WriteLine ("A quantidade de mercadorias que geram entre 10% e 20% de lucro é: {0}", lm);
    Console.WriteLine ("A quantidade de mercadorias que geram mais de 20% de lucro é: {0}", lg);

//Imprimindo total gasto em compra, total gasto em venda e lucro final obtido
    Console.WriteLine ("O total gasto em compras foi de: R$ {0}", tc);
    Console.WriteLine ("O total ganho em vendas foi de: R$ {0}", tv);
    Console.WriteLine ("O lucro total final foi de: R$ {0}", lucrot);    
  }
}