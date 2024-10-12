using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting;

namespace DAL
{
    public class SQLDBHelper
    {

        DataTable tabla;
        SqlConnection strConexion = new SqlConnection("Data Source=JUANDA\\SQLEXPRESS;Initial Catalog=BDUbicaciones;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public bool ejecutarComandoSQL(SqlCommand strSQLCommand)
        {

            bool Respuesta = true;

            cmd = strSQLCommand;
            cmd.Connection = strConexion;
            strConexion.Open();
            Respuesta = (cmd.ExecuteNonQuery() <= 0) ? false : true;
            strConexion.Close();

            return Respuesta;

        }

        public DataTable ejecutarSentenciaSQL(SqlCommand strSQLCommand)
        {

            cmd = strSQLCommand;
            cmd.Connection = strConexion;
            strConexion.Open();
            tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            strConexion.Close();

            return tabla;

        }

    }

}
