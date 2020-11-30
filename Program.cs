using System;

namespace atv_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
            //lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
            //pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
            //entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

            Console.WriteLine("Hello World!");

            string [] nomes = new string [10];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite os nomes");
                nomes [i] = Console.ReadLine();
            }

            Console.WriteLine("Digite um nome para buscar");
            string busca = Console.ReadLine();

            for (var i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == busca)
                {
                    Console.WriteLine($"Achei! {busca}");
                }else{
                    Console.WriteLine("Não Achei!");
                }
            }

        }
    }
}
