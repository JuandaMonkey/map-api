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

        public void agregar() { }
        public void eliminar() { }
        public void modificar() { }
        public DataTable listar()
        {

            SqlCommand cmdComando = new SqlCommand();
            cmdComando.CommandText = "select * from direcciones";
            cmdComando.CommandType = CommandType.Text;

            DataTable tablaResultado = oConexion.ejecutarSentenciaSQL(cmdComando);

            return tablaResultado;

        }
    }

}
