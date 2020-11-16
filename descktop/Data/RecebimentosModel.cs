using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    public class RecebimentosModel
    {
        public int idEmpresa { get; set; }
        public DateTime inicio { get; set; }
        public DateTime final { get; set; }
        public List<Parcelas> parcelas { get; set; }
    }

    public class Parcelas
    {
        public int idPedido { get; set; }
        public string cliente { get; set; }
        public decimal valor { get; set; }
        public string parcela { get; set; }
        public DateTime dataParcela { get; set; }
        public int pago { get; set; }
    }
}
