using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Utils
{
    class ParseUtils
    {
        public ParseUtils()
        {

        }
        public string encodeString(string paraCodificar)
        {
            string utf8_String = paraCodificar;
            byte[] bytes = Encoding.Default.GetBytes(utf8_String);
            utf8_String = Encoding.UTF8.GetString(bytes);

            return utf8_String;
        }

        //public DateTime encodeDateTime(string data)
        //{
        //    DateTime dataConvertida = Convert.ToDateTime(data);
        //    return dataConvertida;
        //}
    }
}
