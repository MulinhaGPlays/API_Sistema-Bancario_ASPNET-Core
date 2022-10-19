using APIBanco.Models.Enums;
using APIBanco.Utils;

namespace APIBanco.Models
{
    public class Conta : FuncoesConta
    {
        public int Id { get; set; }

        public int NumeroConta { get; set; }

        public int NumeroAgencia { get; set; }

        public double Saldo { get; set; }

        public Cliente Cliente { get; set; }

        public ETipoSituacao Situacao { get; }
    }
}
