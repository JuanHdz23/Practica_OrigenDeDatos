using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrigenDeDatos
{
    public class Seguridad
    {
        public static string Encriptar(string cadena)
        {
            string result;
            byte[] encriptar = Encoding.Unicode.GetBytes(cadena);
            result = Convert.ToBase64String(encriptar);
            return result;
        }
    }
}
