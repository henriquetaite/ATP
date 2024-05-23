using System;
public class Questao02
{
    public void Rodar() {

//Declarando variáveis
        double salario = 0, total = 0;
        int filhos = 0, pessoas = 0;

//Criando condição flag com do while para encerrar quando o Zero for digitado
            do {
                Console.WriteLine ("Digite seu salário mensal, ou digite zero para encerrar");
                salario = double.Parse (Console.ReadLine());

//Criando condicionais para ativar procedimento ou fazer as impressões e os registros necessários
                    if (salario < 0) {
                    Console.WriteLine ("Salário inválido!");
                    }                    
//Solicitando e registrando número de filhos
                    else if (salario > 0) {
                        Console.WriteLine ("Quantos filhos você tem?");
                        filhos = int.Parse (Console.ReadLine());
                        total += salario;
                        pessoas++;
                    }
                    else {
                        CalcularMediaSalarial (total, pessoas);
                    }
                }
            while (salario != 0);
        }
//Criando procedimento para calcular e informar a média salarial após encerramento das leituras
            static void CalcularMediaSalarial (double total, int pessoas)  {
                double media = total / pessoas;
                Console.WriteLine ("O salário médio da população é {0}", media);
    }
}
