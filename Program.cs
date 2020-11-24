using System;

namespace Procurando_nome
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i}º numero");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Digite o nome que você quer procurar");
            string procurar = Console.ReadLine();
            string Achou = "n";
            foreach(string nome in nomes)
            {
                if(procurar == nome){
                    Console.WriteLine("ACHEI");
                    Achou = "s";
                }
            }
            if(Achou == "n"){
                Console.WriteLine("NÃO ACHEI");
            }
        }
    }
}
