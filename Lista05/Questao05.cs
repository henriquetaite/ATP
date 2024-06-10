using System;
public class Questao05 {
    public void Rodar() {
//Declarando variáveis para receber números das tentativas
        int a, b, c;
//Declarando vetor sorteado
        int [] vetorS = new int [3];

//Criando método do-while para executar os métodos até a condição especificada
        do {
//Acionando função
            vetorS = SorteioVetorS (vetorS);
//Acionando procedimento
            PerguntandoUsuário (a, b, c);
//Criando foreach para pesquisar os números do vetor e comparar com os do usuário
            foreach (int item in vetorS) {
            }
        }
        while (a != item || b != item || c != item);
//Criando comando condicional para gerar uma mensagem ao parar o programa
        if (item == a || item == b || item == c) {
            Console.WriteLine ("Você acertou um número!");
        }
    }
//Criando função de sorteio
    public int [] SorteioVetorS (int [] vetorS) {
        Random randNum = new Random ();
        for (int i = 0; i < 3; i++) {
            vetorS [i] = randNum.Next (10, 51);
        }
            return vetorS;
    }
//Criando procedimento de tentativa
    public void PerguntandoUsuário (int a, int b, int c) {
        Console.WriteLine ("Digite 3 números de 10 a 50");
        a = int.Parse (Console.ReadLine());
        b = int.Parse (Console.ReadLine());
        c = int.Parse (Console.ReadLine());
    }
}