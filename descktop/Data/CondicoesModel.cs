using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    public class CondicoesModel
    {
        public int idEmpresa { get; set; }
        public int idPedido { get; set; }
        public List<CondicaoParcelas> parcelas { get; set; } 
    }

    public class CondicaoParcelas
    {
        public int idParcela { get; set; }
        public string numeroParcela { get; set; }
        public decimal valorParcela { get; set; }
        public string formaPagamento { get; set; }
        public DateTime dataParcela { get; set; }
        public int pago { get; set; }
        public DateTime dataPagamento { get; set; }
    }
}
