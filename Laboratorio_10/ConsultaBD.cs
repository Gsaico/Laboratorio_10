using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Laboratorio_10
{
    class ConsultaBD
    {
   
   
        private SqlConnection Conexion;
        private SqlDataAdapter Adapter;
    



        public DataTable listarAlumnos(string CadenaConexion, string CodigoAlumno)
        {

            //Creo el nuevo objeto SQLconexion a la variable Conexion.
            Conexion = new SqlConnection(CadenaConexion);

            string sqlquery = "select * from TablaAlumnos where Codigo='" + CodigoAlumno + "'";

                      
            Adapter = new SqlDataAdapter(sqlquery, Conexion);
            //Creo el DataTable 
            DataTable dt = new DataTable();

            //Relleno el datatable con el adaptador 

            Adapter.Fill(dt);

                       
         
            return dt;  



        }

    }
}
