using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MySQLConnectorWithCSharp
{
    class MySQLConnection
    {
        public void MySqlConnection () 
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "Teardrop1973";
            builder.Database = "node_mysql";
            try
            {
                MySqlConnection conn = new MySqlConnection(builder.ToString());
                conn.Open();
                MessageBox.Show("Conexion correcta");
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO personaje (nombre, apellido1, apellido2) VALUES ('lokomotiv', 'Puyol', 'soriano')";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
            
            
        }
       
        
    }
}
