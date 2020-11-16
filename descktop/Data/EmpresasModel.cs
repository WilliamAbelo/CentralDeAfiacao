using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    public class EmpresasModel
    {
        public int idEmpresa { get; set; }
        public string empresa { get; set; }
        public string prefixo { get; set; }
        public DateTime dataCriacao { get; set; }
        public int ativo { get; set; }
    }
}
