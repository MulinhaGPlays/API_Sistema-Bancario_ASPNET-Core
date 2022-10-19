using APIBanco.Models.Enums;
using APIBanco.Models.Interfaces;

namespace APIBanco.Models
{
    public class Cliente : FuncoesCliente
    {
        public string CPF { get; set; }

        public string Name { get; set; }

        public ETipoSituacao Situacao { get; set; }
    }
}
