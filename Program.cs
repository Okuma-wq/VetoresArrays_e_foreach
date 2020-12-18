using System;

namespace Vetores__arrays__e_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = {"maçã", "batata", "cenoura"};
            double[] precos = {1.1, 2.3, 4.5};
            int[] idades = {16, 17, 17};

            Console.WriteLine("Qual o tamanho da lista que deseja criar?");
            int tamanho = int.Parse(Console.ReadLine());

            string[] nomesAlunos = new string[tamanho];

            for (var i = 0; i < nomesAlunos.Length; i++)
            {
                Console.Write("Digite um nome: ");
                nomesAlunos[i] = Console.ReadLine();
            }

            for (var i = 0; i < nomesAlunos.Length; i++)
            {
                Console.Write("Nome: ");
                Console.WriteLine(nomesAlunos[i]);
            }

            // Console.WriteLine(produtos[1]);

            // Console.WriteLine("Trocar batatas por qual item?");

            // produtos[1] = Console.ReadLine();

            // Console.WriteLine(produtos[1]);

            // Console.WriteLine(produtos.Length);

            // for (var i = 0; i < produtos.Length; i++)
            // {
            //     Console.WriteLine(i);
            //     Console.WriteLine(produtos[i]);
            // }
        }
    }
}
