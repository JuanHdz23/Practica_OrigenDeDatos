using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OrigenDeDatos
{
    public class Funciones
    {
        public static List<Usuario> mostrar()
        {
            List<Usuario> lista = new List<Usuario>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select id, user, password from usuarios"),Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            while (lector.Read())
            {
                Usuario usr = new Usuario();
                usr.id = lector.GetInt32(0);
                usr.user = lector.GetString(1);
                usr.password = lector.GetString(2);
                lista.Add(usr);
            }

            return lista;
        }

        public static bool login(string usuario, string contra)
        {
            bool bandera = false;
            MySqlCommand sentencia = new MySqlCommand(String.Format("select * from usuarios where user='"+ usuario + "' and password='" + contra + "'"), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.Read())
            {
                bandera = true;
            } 
            else
            {
                bandera = false;
            }

            return bandera;
        }

        public static string insertar(string usuario, string contra)
        {
            string mensaje;
            string query = "INSERT INTO usuarios (user, password) VALUES ( '" + usuario + "', '" + contra + "');";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se registro usuario";
            }

            return mensaje;
        }

        public static string actualizar(int id, string usuario, string contra)
        {
            string mensaje;
            string query = "UPDATE usuarios SET user='" + usuario +
                           "', password='" + contra +
                           "' WHERE id =" + id + ";" ;
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se actualizo usuario";
            }

            return mensaje;
        }

        public static string eliminar(int id)
        {
            string mensaje;
            string query = "DELETE FROM usuarios WHERE id =" + id + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), Conexion.obtenerConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "OK";
            }
            else
            {
                mensaje = "No se elimino usuario";
            }

            return mensaje;
        }
    }
}
