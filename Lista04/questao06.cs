using System;
public class Questao06
{
    public static void Rodar()
    {
//Declarando variáveis
        int x;
        bool ehPositivo;
        string opcao;

//Criando método do while para ler N números e acionar o procedimento para cada um
        do {
//Solicitando e registrando o número inteiro do usuário
                Console.WriteLine ("Digite um número inteiro");
                x = int.Parse (Console.ReadLine());

//Criando método while para não ler o número zero
                while (x == 0) {
                        Console.WriteLine ("Digite um número diferente de zero");
                        x = int.Parse (Console.ReadLine());
                }

//Acionando procedimento para identificar se é positivo ou negativo
                ehPositivo = VerificarNumero (x);

//Imprimindo respostas a partir de condições
                if (ehPositivo) {
                        Console.WriteLine ("O número que você digitou é: positivo");
                }
                else {
                        Console.WriteLine ("O número que você digitou é: negativo");
                }

//Perguntando se deseja digitar mais números
                Console.WriteLine ("Deseja digitar mais um número? Digite S para Sim e outra tecla para Não");
                opcao = Console.ReadLine ();
        }
        while (opcao == "s" || opcao == "S");
}
//Criando função para receber o número e definir se é positivo ou negativo
        public static bool VerificarNumero (int x) {

//Criando return para mostrar se é positivo ou não
        return x > 0;
    }
}