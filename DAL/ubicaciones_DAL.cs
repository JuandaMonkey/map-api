using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{

    public class ubicaciones_DAL
    {

        SQLDBHelper oConexion;

        public ubicaciones_DAL()
        {

            oConexion = new SQLDBHelper();

        }

        public DataTable listar()
        {

            SqlCommand cmdComando = new SqlCommand();
            cmdComando.CommandText = "select * from direcciones";
            cmdComando.CommandType = CommandType.Text;

            DataTable tablaResultado = oConexion.ejecutarSentenciaSQL(cmdComando);

            return tablaResultado;

        }
        public bool agregar(ubicaciones_BLL OubicacionesBLL) 
        {

            /* nuevo comando sql */
            SqlCommand cmdComando = new SqlCommand();
            /* sql */
            cmdComando.CommandText = "insert into direcciones (ubicacion, latitud, longitud) " +
                "values (@ubicacion, @latitud, @longitud);";

            /* asignación */
            cmdComando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = OubicacionesBLL.ubicacion;
            cmdComando.Parameters.Add("@latitud", SqlDbType.VarChar).Value = OubicacionesBLL.latitud;
            cmdComando.Parameters.Add("@longitud", SqlDbType.VarChar).Value = OubicacionesBLL.longitud;

            return oConexion.ejecutarComandoSQL(cmdComando);

        }

        public bool modificar(ubicaciones_BLL OubicacionesBLL)
        {

            /* nuevo comando sql */
            SqlCommand cmdComando = new SqlCommand();
            /* sql */
            cmdComando.CommandText = "update direcciones set " +
                "ubicacion = @ubicacion, " +
                "latitud = @latitud, " +
                "longitud = @longitud " +
                "where id = @id;";

            /* asignación */
            cmdComando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = OubicacionesBLL.ubicacion;
            cmdComando.Parameters.Add("@latitud", SqlDbType.VarChar).Value = OubicacionesBLL.latitud;
            cmdComando.Parameters.Add("@longitud", SqlDbType.VarChar).Value = OubicacionesBLL.longitud;
            cmdComando.Parameters.Add("@id", SqlDbType.Int).Value = OubicacionesBLL.id;

            return oConexion.ejecutarComandoSQL(cmdComando);

        }

        public bool eliminar(ubicaciones_BLL OubicacionesBLL) 
        {

            /* nuevo comando sql */
            SqlCommand cmdComando = new SqlCommand();
            /* sql */
            cmdComando.CommandText = "delete from direcciones " +
                "where id = @id";

            /* asignación */
            cmdComando.Parameters.Add("@id", SqlDbType.Int).Value = OubicacionesBLL.id;

            return oConexion.ejecutarComandoSQL(cmdComando);

        }
        
    }

}
