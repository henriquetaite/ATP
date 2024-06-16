using System;
public class Questao05 {
    public void Rodar() {
//Declarando variáveis para receber números das tentativas
        int x = 0;
//Declarando vetor sorteado
        int [] vetorS = new int [3];
    
//Acionando função
            vetorS = SorteioVetorS (vetorS);

//Acionando procedimento
            PerguntandoUsuário (x);

//Criando foreach para pesquisar os números do vetor e comparar com os do usuário
            foreach (int item in vetorS) {
                if (x == item) {
                    Console.WriteLine ("Você acertou um número!");
                }
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
    public void PerguntandoUsuário (int x) {
        Console.WriteLine ("Digite 1 número entre 10 e 50");
        x = int.Parse (Console.ReadLine());
    }
}