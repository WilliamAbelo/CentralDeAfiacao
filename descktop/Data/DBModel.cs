using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Data
{
    class DBModel
    {
        public Colunas colunas { get; set; }
        public Linhas linhas { get; set; }
    }

    public class Colunas
    {
        public List<string> nome { get; set; }
    }
    public class Linha
    {
        public List<string> item { get; set; }
    }
    public class Linhas
    {
        public List<Linha> linhas { get; set; }
    }
}
