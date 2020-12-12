using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrigenDeDatos
{
    public class Usuario
    {
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        public Usuario() { }

        public Usuario (int id, string user, string password)
        {
            this.id = id;
            this.user = user;
            this.password = password;
        }
    }
}
