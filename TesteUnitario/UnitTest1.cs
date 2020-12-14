using NUnit.Framework;
using Teste_de_ordenação_de_pedidos;

namespace TesteUnitario
{
    public class Tests
    {
        [TestFixture]

        public class CarrinhoDeComprasTestes
        {
            [Test]
            public void Adicionar_Produto_NaLista_ComSucesso()
            {
                var produto = new CarrinhoDeCompras();

                var clientData = new ClientData()
                {
                    CustomerId = 4,
                    CardNumber = 132456798465123,
                    CVV = 3333
                };

                var Service = new Mock<IClientRepository>();
                Service.Setup(_ => _.Save(clientData)).ReturnsAsync(true);
                clientController.ClientRepository = Service.Object;

                var apiSaveCustomerResponse = clientController.API_SaveCustomerDataOnDB(clientData);
                Assert.That(apiSaveCustomerResponse, Contains.Substring("3512"));

            }

          

        }
    }
}