using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoDaLiscao
{
    class Program
    {
        static void Main(string[] args)
        {

            int cadastrar;

            List<string> nomes = new List<string> {"aaa","bb" };
            int posicao;
            string nome;
            string novo_nome;

            while (true)
            {

                Console.WriteLine("Olá bem-vindo ao sistema Cunha game");
                Console.WriteLine("Selecione uma das opções:");

                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Buscar");
                cadastrar = int.Parse(Console.ReadLine());

                if (cadastrar > 5 )
                {
                    Console.WriteLine("Erro");
                }


                if (cadastrar == 1)
                {
                    Console.WriteLine("Agora adicione um novo nome:");
                    nome = Console.ReadLine();
                    nomes.Add(nome);
                    Console.WriteLine("Usuário cadastrado com sucesso!");


                }
               


                if (cadastrar == 2)
                {
                    Console.WriteLine("Vamos buscar uma posição:");
                    Console.WriteLine("insira a posição que você deseja verificar:");
                    posicao = int.Parse(Console.ReadLine());
                    Console.WriteLine($"O nome é {nomes[posicao]}");

                 }
                if ( cadastrar == 3)
                {
                    Console.WriteLine("Digite uma posição para deletar:");
                    posicao = int.Parse(Console.ReadLine());

                    nomes.RemoveAt(posicao);
                }
                if (cadastrar == 4)
                {

                    Console.WriteLine("Digite um nome já existente na lista que você quer alterar");
                    nome = Console.ReadLine();
                    Console.WriteLine("Agora digite um novo nome:");
                    novo_nome = Console.ReadLine();
                    posicao = nomes.IndexOf(nome);
                    nomes[posicao] = novo_nome;


                }
            }







        }
    }
}
