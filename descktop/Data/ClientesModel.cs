using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    public class ClientesModel
    {
        public int idCliente { get; set; }
        public int idEmpresa { get; set; }
        public string nome { get; set; }
        public string responsavel { get; set; }
        public string CEP { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string celular1 { get; set; }
        public string email { get; set; }
        public string observacao { get; set; }
        public int ativo { get; set; }
        public string cpfCnpj { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataSync { get; set; }
    }

}