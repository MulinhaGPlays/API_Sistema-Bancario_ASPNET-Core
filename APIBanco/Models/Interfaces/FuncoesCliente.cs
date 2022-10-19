using APIBanco.Models.Enums;

namespace APIBanco.Models.Interfaces
{
    public class FuncoesCliente
    {
        public List<Cliente> getClientesPorSituacao(List<Cliente> clientes, ETipoSituacao tipo) => null;
        public List<Cliente> getClientesPorSituacao(List<Cliente> clientes, Categoria tipo) => null;
    }
}
