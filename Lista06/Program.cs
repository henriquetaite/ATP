using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o número da questão que deseja executar (1-10):");
        int questao = int.Parse(Console.ReadLine());

        switch (questao)
        {
            case 1:
                Questao01 questao01 = new Questao01();
                questao01.Rodar();
                break;
            case 2:
                Questao02 questao02 = new Questao02();
                questao02.Rodar();
                break;
            case 3:
                Questao03 questao03 = new Questao03();
                questao03.Rodar();
                break;
            case 4:
                Questao04 questao04 = new Questao04();
                questao04.Rodar();
                break;
            case 5:
                Questao05 questao05 = new Questao05();
                questao05.Rodar();
                break;
            case 6:
                Questao06 questao06 = new Questao06();
                questao06.Rodar();
                break;
            case 7:
                Questao07 questao07 = new Questao07();
                questao07.Rodar();
                break;
            case 8:
                Questao08 questao08 = new Questao08();
                questao08.Rodar();
                break;
            case 9:
                Questao09 questao09 = new Questao09();
                questao09.Rodar();
                break;
            case 10:
                Questao10 questao10 = new Questao10();
                questao10.Rodar();
                break;
            default:
                Console.WriteLine("Questão inválida.");
                break;
        }
    }
}
