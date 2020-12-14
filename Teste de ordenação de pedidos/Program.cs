using System;

namespace Teste_de_ordenação_de_pedidos
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

                //carrinho.Adiciona(new Produto("Liquidificador", (decimal)250.0));
                //carrinho.Adiciona(new Produto("Geladeira", (decimal)450.0));
                //carrinho.Adiciona(new Produto("Jogo de pratos", (decimal)70.0));

                var exit = false;

                while (exit == false)
                {
                    Console.WriteLine("Digite o nome do produto ou digite EXIT para sair");
                    var nome = Console.ReadLine();
                    if (nome == "EXIT")
                    {
                        exit = true;
                        break;
                    }

                    Console.WriteLine("Digite o preco do produto");
                    var preco = decimal.Parse(Console.ReadLine());

                    carrinho.Adiciona(new Produto(nome, preco));

                }

                MaiorEMenor algoritmo = new MaiorEMenor();
                algoritmo.Encontra(carrinho);

                Console.WriteLine("O menor produto: " + algoritmo.Menor.Nome);
                Console.WriteLine("O maior produto: " + algoritmo.Maior.Nome);
                Console.ReadLine();
            }
            catch (FormatException msg)
            {
                Console.WriteLine(msg.Message);
                Console.ReadLine();
            }

        }
    }
}
