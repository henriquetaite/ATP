using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número da questão que deseja executar (1-10):");
        int questao = int.Parse(Console.ReadLine());

        switch (questao)
        {
            case 1:
                questao01.Questao();
                break;
            case 2:
                questao02.Questao();
                break;
            case 3:
                questao03.Questao();
                break;
            case 4:
                questao04.Questao();
                break;
            case 5:
                questao05.Questao();
                break;
            case 6:
                questao06.Questao();
                break;
            case 7:
                questao07.Questao();
                break;
            case 8:
                questao08.Questao();
                break;
            case 9:
                questao09.Questao();
                break;
            case 10:
                questao10.Questao();
                break;
            default:
                Console.WriteLine("Questão inválida.");
                break;
        }
    }
}