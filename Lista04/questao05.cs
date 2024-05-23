using System;
public class Questao05
{
    public void Rodar()
    {
//Declarando variáveis
        int a = 0, b = 0, mdc = 0;

//Solicitando números ao usuário
        Console.WriteLine ("Digite 2 números para saber o MDC");
        a = int.Parse (Console.ReadLine());
        b = int.Parse (Console.ReadLine());

//Acionando a função para retornar o MDC
        mdc = CalcularMdc (a, b);

//Exibiindo o resultado MDC
        Console.WriteLine ("O MDC dos números que você digitou é: {0}", mdc);
    }

//Criando função para retornar o mdc
        public static int CalcularMdc (int a, int b) {

//Criando método do while para fazer as operações até chegar ao MDC
        do {
            if (a > b) {
                a = a - b;
                b = a;
            }
            else if (a < b) {
                b = b - a;
                a = b;
            }
        }
        while (a != b);

//Igualando mdc a sua variável correta
        int mdc = a;

//Informando o MDC no return da função
        return mdc;
    }
}