using System;
public class Questao03
{
    public void Rodar()
     {
//Declarando variáveis para receber os 3 números digitados
        int x, y, z, N = 0;
        
//Solicitando e registrando o número de conjuntos
        Console.WriteLine("Digite o número de conjuntos que irá usar");
        N = int.Parse (Console.ReadLine());
        
//Criando comando for para os números serem armazenados em cada um dos N conjuntos 
            for (int i = 0; i < N; i++) {

//Solicitando e registrando o número de conjuntos
                Console.WriteLine("Digite o primeiro número do conjunto");
                x = int.Parse (Console.ReadLine());
                
                Console.WriteLine("Digite o segundo número do conjunto");
                y = int.Parse (Console.ReadLine());
                
                Console.WriteLine("Digite o terceiro número do conjunto");
                z = int.Parse (Console.ReadLine());
                
//Acionando procedimento
                ImprimirCrescente (x, y, z);
            }
        }
        
//Criando procedimento
        static void ImprimirCrescente (int x, int y, int z) {
            if (x > y && x > z && y > z) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", z, y, x);
            }
            else if (y > x && y > z && x > z) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", z, x, y);
            }
            else if (y > x && y > z && z > x) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", x, z, y);
            }
            else if (z > x && z > y && y > x) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", x, y, z);
            }
            else if (z > x && z > y && x > y) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", y, x, z);
            }
            else if (x > z && x > y && z > y) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", y, z, x);
            }
            else if (x == z && x > y) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", y, z, x);
            }
            else if (x == z && x < y) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", z, x, y);
            }
            else if (y == z && x < y) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", x, y, z);
            }
            else if (y == z && x > y) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", z, y, x);
            }
            else if (y == x && x > z) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", z, y, x);
            }
            else if (y == x && x < z) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", y, x, z);
            }
            else if (y == x && x == z) {
                Console.WriteLine ("A ordem crescente dos três números que você digitou é: {0}, {1}, {2}", y, x, z);
            }
        }
    }
