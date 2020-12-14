using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Produto Menor;
        public Produto Maior;

        public void Encontra(CarrinhoDeCompras carrinho)
        {
            try
            {
                var ordenado = carrinho.lista.OrderBy(_ => _.preco);
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
        public string nome;
        public decimal preco;

        public Produto(string nome, decimal preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}
