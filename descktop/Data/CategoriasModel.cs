using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    class CategoriasModel
    {
        public int idCategoria { get; set; }
        public int idEmpresa { get; set; }
        public string categoria { get; set; }  
        public string unidade { get; set; }
        public string observacao { get; set; }
        public DateTime dataCriacao { get; set; }
    }
}
