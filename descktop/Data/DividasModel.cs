using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    public class DividasModel
    {
        public int idDivida { get; set; }
        public int idEmpresa { get; set; }
        public string divida { get; set; }
        public int pago { get; set; }
        public string observacao { get; set; }
        public int tipoDivida { get; set; }
        public decimal valorTotal { get; set; }
        public DateTime dataCriacao { get; set; }
        public List<ParcelaDividasModel> parcelaDividas { get; set; }
    }

    public class ParcelaDividasModel
    {
        public int idParcelaDivida { get; set; }
        public int idEmpresa { get; set; }
        public int idDivida { get; set; }
        public string parcela { get; set; }
        public decimal valorParcela { get; set; }
        public string formaPagamento { get; set; }
        public int pago { get; set; }
        public DateTime dataParcela { get; set; }
        public DateTime dataPagamento { get; set; }
    }
}
