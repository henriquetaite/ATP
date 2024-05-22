using System;
public class Questao03 {
    public static void Rodar() {

//Declarando e inicializando vetore X
        double [] vetorX = new double [10];

//Acionando Procedimento de preencher vetor
        PreencherVetorX (vetorX);

//Acionando Função de retornar novo vetor com valores negativos
        ExibindoVetor (vetorX);

//Acionando Procedimento de exibir um vetor
        ExibirVetores (vetorX);
    }
//Criando Procedimento para preencher vetorX
    public static void PreencherVetorX (double [] vetorX) {
        Random randNum = new Random ();
        for (int i = 0; i < 10; i++) {
            vetorX [i] = randNum.NextDouble ();
        }
    }
//Criando função para retornar novo vetor com valores negativos
    public static double [] ExibindoVetor (double [] vetorX) {

//Declarando variável que vai contar quantos números negativos têm
        int N = 0;

//Criando comando foreach para pesquisar dentro do vetorX e contar variáveis negativas
        foreach (double item in vetorX) {
            if (item < 0) {
                N++;
            }
        }
//Declarando novo vetor que vai receber números negativos
        double [] vetorNeg = new double [N];

//Declarando variável index para receber os valores negativos
        int index = 0;

//Criando outro foreach para adicionar os números negativos ao novo vetor
        foreach (double item in vetorX) {
            if (item < 0) {
                vetorNeg [index] = item;
                index++;
            }
        }
        return vetorNeg;
    }
//Criando procedimento para exibir um vetor
    public static void ExibirVetores (double [] vetorX, double [] vetorNeg) {

//Declarando variável para opção do usuário
        string opcao;

//Perguntando ao usuário qual vetor ele quer que seja exibido
        Console.WriteLine ("Qual vetor deseja ver, X ou N?");
        opcao = Console.ReadLine();

//Criando comando if para exibir conforme o desejo do usuário
        if (opcao == "X" || opcao == "x") {
            Console.WriteLine ("vetorX");
            foreach (double item in vetorX) {
                Console.Write (item + " ");
            }
        }
        else if (opcao == "N" || opcao == "n") {
            Console.WriteLine ("vetorNeg: ");
            foreach (double item in vetorNeg) {
                Console.Write (item + " ");
            }
        }
        else {
            Console.WriteLine ("Opção inválida! Digite X ou N");
        }
    }
}