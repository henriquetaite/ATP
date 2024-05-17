using System;
public class Questao04
{
    public static void Rodar()
    {
//Declarando variáveis para armazenar os lados do possível triângulo
        double x, y, z;
        string opcao;

//Solicitando valores ao usuário e registrando
            Console.WriteLine ("Digite 3 números para formar os lados de um triângulo");
            x = double.Parse (Console.ReadLine());
            y = double.Parse (Console.ReadLine());
            z = double.Parse (Console.ReadLine());

//Acionando o procedimento de verificação do tipo de triângulo
            VerificarTriangulo (x , y, z);

            Console.WriteLine ("Quer testar mais uma formação? Digite s para SIM e qualquer outra tecla para NÃO");
            opcao = Console.ReadLine();

//Criando método while para usuário registrar mais uma tentativa de triângulo, caso queira
            while (opcao == "s") {

//Solicitando valores ao usuário e registrando
            Console.WriteLine ("Digite 3 números para formar os lados de um triângulo");
            x = double.Parse (Console.ReadLine());
            y = double.Parse (Console.ReadLine());
            z = double.Parse (Console.ReadLine());

//Acionando o procedimento de verificação do tipo de triângulo
                VerificarTriangulo (x , y, z);
            }
        }
//Criando procedimento de verificação do triângulo e impressão do seu tipo
        static void VerificarTriangulo (double x, double y, double z) {

//Criando comando condicional para executar o procedimento, caso seja um triângulo
            if ((x + y) >= z && (x + z) >= y && (y + z) >= x) {

//Criando um if dentro do outro para imprimir o tipo de triângulo
                if (x == y && x == z) {
                    Console.WriteLine ("É um triângulo do tipo equilátero");
                }
                else if (x == y || x == z || y == z) {
                    Console.WriteLine ("É um triângulo do tipo isósceles");
                }
                else if (x != y && x != z && y != z) {
                    Console.WriteLine ("É um triângulo do tipo escaleno");
                }
            }
            else if ((x + y) < z || (x + z) < y || (y + z) < x) {
                Console.WriteLine ("Estes valores não formam um triângulo");
            }
        }
    }