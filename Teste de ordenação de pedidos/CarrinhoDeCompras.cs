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
                var ordenado = carrinho.lista.OrderBy(_ => _.Preco);
                Menor = ordenado.First();
                Maior = ordenado.Last();
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
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
