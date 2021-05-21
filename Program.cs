using System;

namespace wello
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int dia, mes, ano, idade;
            
            //Console.clear();
            Console.WriteLine("nome");
            nome = Console.ReadLine();
            Console.WriteLine("ola " + nome);

            Console.WriteLine("dia");
            dia = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("mes");
            mes = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("ano");
            ano = Convert.ToInt16(Console.ReadLine());
            idade = 2021 - ano;
            Console.WriteLine("ola " + nome + " voce tem " + idade + " anos");

            if (true);
            {
               if (idade >= 18);
            }

            {
              Console.WriteLine(nome + " voce é maoir de idade");
              //idade = Console.ReadLine();
            }

            else if (false);
            {
              Console.WriteLine(nome + " voce é menor de idade");  
            }
               //idade = Console.ReadLine();
        }
    }
}
