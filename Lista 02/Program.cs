// See https://aka.ms/new-console-template for more information

using System;
class Program {
    public static void Main () {

//Declarando variáveis
int A = 0, B = 0, x = 0;

//Solicitando que o usuário digite 2 números para comparação
Console.WriteLine("Digite 2 números inteiros");

//Fazendo a leitura e registro dos números
A = int.Parse (Console.ReadLine());
B = int.Parse (Console.ReadLine());

//Criando condições e definindo comandos para cada uma delas 
    if ((A + B) >= 10) {
    x = (A + B + 5);
    }
    else {
    x = (A + B + 7);
    }

//Imprimindo resultado final
Console.WriteLine ("O valor do resultado final da soma é: {0}", x);
}
}   