namespace ATV6_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcgeral;

            Console.WriteLine("**MENU DE ATIVIDADES** \n 1- EXERCÍCIO 1 \n 2 -EXERCÍCIO 2 \n 3 -EXERCÍCIO 3 \n 4 - EXERCÍCIO 4 \n 5 - EXERCÍCIO 5 \n 6 - EXERCÍCIO 6 \n 7 - EXERCÍCIO 7");
            Console.WriteLine("\nESCREVA O NÚMERO DA OPÇÃO EQUIVALENTE A ATIVIDADE DESEJADA: ");
            opcgeral = int.Parse(Console.ReadLine());

            switch (opcgeral)
            {
                case 1:

                    Console.WriteLine("EXERCÍCIO 1 ");

                    int i = 1, m;

                    Console.WriteLine("digite um número inteiro aleatório: ");
                    m = int.Parse(Console.ReadLine());

                    while (i <= m)
                    {
                        Console.WriteLine("{0}", i);
                        i++;
                    }
                    break;

                case 2:
                    Console.WriteLine("ATIVIDADE 2");
                   
                    int i1 = 0 , n;

                    Console.WriteLine("Escreva um número inteiro aleatório: ");
                    n = int.Parse(Console.ReadLine());

                    while (i1 <= n)
                    {
                        if (i1 % 2 == 0) ;
                        {
                            Console.WriteLine(i1);
                        }
                        i1++;
                    }

                    break;



                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    }
}
