using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teste_de_ordenação_de_pedidos.Testes
{
    [TestFixture]
    public class MaiorEMenorTestes
    {
        [Test]
        public void Unico_Produto_No_Carrinho()
        {
            var carrinho = new CarrinhoDeCompras();
            var produto = new Produto("Fogao", (decimal)250.0);
            carrinho.Adiciona(produto);

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(Equals(algoritmo.Menor.nome, algoritmo.Maior.nome));
        }

        [Test]
        public void Produtos_Nao_Ordernados()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Televisao", (decimal)1000.50));
            carrinho.Adiciona(new Produto("Fritadeira", (decimal)250.75));
            carrinho.Adiciona(new Produto("Aspirador", (decimal)300.50));

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(algoritmo.Menor.nome, Is.EqualTo("Fritadeira"));
            Assert.That(algoritmo.Maior.nome, Is.EqualTo("Televisao"));
        }


        [Test]
        public void Produtos_Em_Ordem_Crescente()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Fritadeira", (decimal)250.75));
            carrinho.Adiciona(new Produto("Aspirador", (decimal)300.50));
            carrinho.Adiciona(new Produto("Televisao", (decimal)1000.50));

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(algoritmo.Menor.nome, Is.EqualTo("Fritadeira"));
            Assert.That(algoritmo.Maior.nome, Is.EqualTo("Televisao"));
        }

        [Test]
        public void Produtos_Em_Ordem_Decrescente()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Televisao", (decimal)1000.50));
            carrinho.Adiciona(new Produto("Aspirador", (decimal)300.50));
            carrinho.Adiciona(new Produto("Fritadeira", (decimal)250.75));


            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(algoritmo.Menor.nome, Is.EqualTo("Fritadeira"));
            Assert.That(algoritmo.Maior.nome, Is.EqualTo("Televisao"));
        }
    }
}
