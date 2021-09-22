using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//Para usar el MessageBox, componente de la clase Form.
using Npgsql;//Librería que conecta con PostgreSQL.

namespace hotVoley
{
    public class ConexionPgsql
    {
        //Declaramos nuestra conexión:
        private NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = ruravi; Database = hotVoley");

        public string Consultar(string tabla, string columna, string condicion)
        {
            string result = "null";//Guardamos el TEXTO "null" en result.

            conn.Open();//Abrimos la conexión.

            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM \"" + tabla + "\" WHERE " + condicion, conn);//Creamos el comando de consulta.


            NpgsqlDataReader resgistro = comando.ExecuteReader();//Ejecutamos el comando.
            if (resgistro.Read())//Si nuestra consulta retorna al menos 1 registro se activa este if, en caso contrario no se activa y result sigue siendo igual a "null".
            {
                result = resgistro[columna].ToString();//Guardamos en result el contenido de la columna (NOTA: En caso de haber retornado más de 1 registro, solo revisará el primero).
            }
            
            conn.Close();//Cerramos la conexión.
            return result;
        }
    }
}