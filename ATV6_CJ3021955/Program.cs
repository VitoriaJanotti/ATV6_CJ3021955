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
                    
                    int n1, a1=1;
                    int soma = 200;
 
                    Console.WriteLine("Digite um número");
                    n1 = int.Parse(Console.ReadLine())
                    
                    while (a1 < soma)
                    {
                        if (n1 < 0)
                        {
                            Console.WriteLine("número inválido");
                        }
                        else
                        {
                            Console.WriteLine(a1);
                        }
                        a1++;
                    }
                    
                    break;

                case 5:
                    Console.Write.Line ("EXERCÍCIO 5");

                      int v, p1=0;
 
                    Console.WriteLine("Digite um número:");
                    v = int.Parse(Console.ReadLine());
 
                    
                    while (p1 <= v)
                    {
                        if (v % p1 == 0)
                        {
                            Console.WriteLine(p1);
                        }
                        p1++;
                    }

                    break;

                case 6:
                    Console.Write.Line ("EXERCÍCIO 6");

                    int j1 = 0, v2;
 
                    while (j1 < 11)
                    {
                        Console.WriteLine("Digite um valor");
                        v2 = int.Parse(Console.ReadLine());
 
                        if (v2 < v2)
                        {
                            Console.WriteLine("o número maior é = {0}", v2);
                        }
 
                        if (v2 > v2)
                        {
                            Console.WriteLine("o número menor é = {0}", v2);
                        }
 
                        j1++;
                    }
                    
                    break;

                case 7: 
                    Console.Write.Line ("EXERCÍCIO 7")

                        int t = 0, l3;
                    int r1 = 0, p3 = 0;
 
                    while (t < 10)
                    {
                        Console.WriteLine("Digite um valor");
                        l3 = int.Parse(Console.ReadLine());
 
                        if (l3 <= 0)
                            break;
 
                        if (t % 2 != 0)
                        {
                            r1 = r1 + t;
                        }
 
                        if (t % 2 == 0)
                        {
                            p3 = p3 + t;
                        }
 
                        Console.WriteLine("soma dos números ímpares = {0}", r1);
                        Console.WriteLine("soma dos números pares = {0}", p3);
 
                        t++;
                    }
                    
                    break;
                    
                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    }
}
