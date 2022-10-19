using APIBanco.Models;
using APIBanco.Models.Enums;

namespace APIBanco.Utils
{
    public class FuncoesConta
    {
        public void abrirConta (Cliente cliente) { cliente.Situacao = ETipoSituacao.ATIVO; }
        public void fecharConta (Cliente cliente) { cliente.Situacao = ETipoSituacao.CANCELADO; }
        public void depositar (double valor, Cliente cliente) { }
        public void debitar (double valor, Cliente cliente) { }
        public void atualizar (double valor, Cliente cliente) { }
        public double getSaldoAgencia (List<Cliente> cliente) { return 0; }
        public bool verificarSPC (Cliente cliente) { return true; }
    }
}
