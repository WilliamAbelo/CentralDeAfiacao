using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    public class ProdutosModel
    {
        public int idProduto { get; set; }
        public int idEmpresa { get; set; }
        public string produto { get; set; }
        public int idCategoria { get; set; }
        public decimal valor { get; set; }
        public int ativo { get; set; }
        public string observacao { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataSync { get; set; }
    }

    public class ProdutosCesta
    {
        public int idItemPedido { get; set; }
        public ProdutosModel produto { get; set; }
        public decimal quantidade { get; set; }
        public decimal valorTotal { get; set; }
        public decimal desconto { get; set; }
    }

    public class ProdutosCarrinho
    {
        public int idPedido { get; set; }
        public int idEmpresa { get; set; }
        public List<ProdutosCesta> produtos { get; set; }
    }
}
