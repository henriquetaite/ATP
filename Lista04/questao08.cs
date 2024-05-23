using System;
public class Questao08
{
    public void Rodar()
    {
//Declarando variáveis
        int N;
        double S = 0;

//Solicitando e registrando N ao usuário
        Console.WriteLine ("Informe um valor inteiro positivo");
        N = int.Parse (Console.ReadLine());

//Acionando função
            S = CalcularFuncao (N, S);

//Imprimindo resultado de S
            Console.WriteLine ("O valor de S em função de N é: {0}", S);

//Criando comando if para invalidar valores que não sejam positivos
        if (N <= 0) {
            Console.WriteLine ("Valor inválido! Digite outro");
            N = int.Parse (Console.ReadLine());
        }
    }   
//Criando função para retornar S
        public static double CalcularFuncao (int N, double S) {

//Criando comando for para fazer cálculos até N
            for (int n = 2; n <= N; n++) {
                double numerador = Math.Pow (N,2) + 1;
                double denominador = N + 3;
                S += numerador/denominador;
            }
//Fazendo return para retornar valor final de S
                return S;
        }
    }