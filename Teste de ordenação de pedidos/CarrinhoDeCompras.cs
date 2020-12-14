using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste_de_ordenação_de_pedidos
{

    public class CarrinhoDeCompras
    {
        public List<Produto> lista = new List<Produto>();
 
        public void Adiciona(Produto produto)
        {
            lista.Add(produto);
        }

    }

    public class MaiorEMenor  
    {
        public Produto Menor { get; set; }
        public Produto Maior { get; set; }

        public void Encontra(CarrinhoDeCompras carrinho)
        {
            try
            {
                //Ordernação alternativa via LINQ

                //var ordenado = carrinho.lista.OrderBy(_ => _.Preco);
                //Menor = ordenado.First();
                //Maior = ordenado.Last();


                decimal maiorValor = 0;
                var menorValor = carrinho.lista[0].Preco;

                for (int i = 0; i < carrinho.lista.Count; i++)
                {
                    if (carrinho.lista[i].Preco <= menorValor)
                    {
                        Menor = carrinho.lista[i];
                        menorValor = carrinho.lista[i].Preco;
                    }

                    if (carrinho.lista[i].Preco > maiorValor)
                    {
                        Maior = carrinho.lista[i];
                        maiorValor = carrinho.lista[i].Preco;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
          
        }

    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
