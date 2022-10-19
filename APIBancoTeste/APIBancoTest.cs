using APIBanco.Models;
using APIBanco.Models.Enums;
using APIBanco.Utils;
using Xunit;

namespace APIBancoTeste
{
    public class APIBancoTest
    {
        private readonly Cliente _cliente = new Cliente();
        private readonly Conta _conta = new Conta();
        
        public APIBancoTest()
        {
            _cliente.CPF = "00000000";
            _cliente.Name = "Filaupe";
        }

        [Fact]  
        public void AbrirContaTipoAtivo()
        { 
            //Arrage     
            var esperado = ETipoSituacao.ATIVO;
            //Act
            _conta.abrirConta(_cliente);
            //Assert
            Assert.Equal(esperado, _cliente.Situacao);
        }

        [Fact]
        public void FecharContaAtivarCliente()
        {
            //Arrage
            var esperado = ETipoSituacao.CANCELADO;
            //Act
            _conta.fecharConta(_cliente);
            //Assert
            Assert.Equal(esperado, _cliente.Situacao);
        }
    }
}