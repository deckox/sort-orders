using NUnit.Framework;


namespace Teste_de_ordenação_de_pedidos.Testes
{
    [TestFixture]
    public class MaiorEMenorTestes
    {
        [Test]
        public void Adicionar_Um_Unico_Produto_No_Carrinho()
        {
            var carrinho = new CarrinhoDeCompras();
            var produto = new Produto("Fogao", (decimal)250.0);
            carrinho.Adiciona(produto);

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(Equals(algoritmo.Menor.Nome, algoritmo.Maior.Nome));
        }

        [Test]
        public void Ordenar_Produtos_()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Televisao", (decimal)1000.50));
            carrinho.Adiciona(new Produto("Fritadeira", (decimal)250.75));
            carrinho.Adiciona(new Produto("Aspirador", (decimal)300.50));

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(algoritmo.Menor.Nome, Is.EqualTo("Fritadeira"));
            Assert.That(algoritmo.Maior.Nome, Is.EqualTo("Televisao"));
        }


        [Test]
        public void Ordenar_Produtos_De_Ordem_Crescente()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Fritadeira", (decimal)250.75));
            carrinho.Adiciona(new Produto("Aspirador", (decimal)300.50));
            carrinho.Adiciona(new Produto("Televisao", (decimal)1000.50));

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(algoritmo.Menor.Nome, Is.EqualTo("Fritadeira"));
            Assert.That(algoritmo.Maior.Nome, Is.EqualTo("Televisao"));
        }

        [Test]
        public void Ordenar_Produtos_De_Ordem_Decrescente()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Televisao", (decimal)1000.50));
            carrinho.Adiciona(new Produto("Aspirador", (decimal)300.50));
            carrinho.Adiciona(new Produto("Fritadeira", (decimal)250.75));


            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.That(algoritmo.Menor.Nome, Is.EqualTo("Fritadeira"));
            Assert.That(algoritmo.Maior.Nome, Is.EqualTo("Televisao"));
        }
    }
}
