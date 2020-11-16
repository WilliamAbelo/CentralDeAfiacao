using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    public class PedidosModel
    {
        public int idPedido { get; set; }
        public int idEmpresa { get; set; }
        public ProdutosCarrinho Produtos { get; set; }
        public ClientesModel cliente { get; set; }
        public DateTime dataVenda { get; set; }
        public CondicoesModel condicao { get; set; }
        public FreteModel frete { get; set; }
        public decimal desconto { get; set; }
        public decimal valorTotal { get; set; }
        public string observacao { get; set; }
    }
}
