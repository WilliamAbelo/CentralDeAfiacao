using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    public class FreteModel
    {
        public int idFrete { get; set; }
        public int idEmpresa { get; set; }
        public int idPedido { get; set; }
        public int idCliente { get; set; }
        public string CEP { get; set; }
        public decimal valorFrete { get; set; }
        public DateTime dataEnvio { get; set; }
        public int enviado { get; set; }
    }
}
