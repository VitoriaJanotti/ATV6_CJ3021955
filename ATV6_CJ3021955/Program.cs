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

                    Console.WriteLine("EXERCÍCIO 2");
                        
                    int num, i = 0;
 
                    Console.WriteLine("digite um num inteiro");
                    num = int.Parse(Console.ReadLine());
 
 
                    while (i <= num)
                    {
                        if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                        i++;
                    }
                    break;
                    
                case 3:
                    Console.WriteLine("EXERCÍCIO 3");

                        int i, num = 1000;
 
                    Console.WriteLine("digite um numero inteiro");
                    i= int.Parse(Console.ReadLine());
 
                    while ( i <= num)
                    {
                        if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                        i++;
                    }
                    break;

                case 4:
                    Console.WriteLine ("EXERCÍCIO 4");

                    break;

                case 5:
                    Console.Write.Line ("EXERCÍCIO 5");

                    break;

                case 6:
                    Console.Write.Line ("EXERCÍCIO 6");

                    break;

                case 7: 
                    Console.Write.Line ("EXERCÍCIO 7")

                    break;
                    
                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    }
}
