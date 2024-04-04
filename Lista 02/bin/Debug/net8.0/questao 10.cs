using System;
class Program questao 10.cs {
    public static void Main () {
        questao 10.cs

//Declarando variáveis
double A = 0, B = 0;

//Solicitando que o usuário digite 2 números para comparação
Console.WriteLine("Digite 2 números aleatórios");

//Fazendo a leitura e registro dos números
A = double.Parse (Console.ReadLine());
B = double.Parse (Console.ReadLine());

//Criando condições e definindo comandos para cada uma delas 
    if (A > B) {
    Console.WriteLine ("O maior número informado é: {0}", A);
    }
    else if (A < B) {
    Console.WriteLine ("O maior número informado é: {0}", B);
    }
    else {
    Console.WriteLine ("Os números possuem valores iguais");
    }
}
}   