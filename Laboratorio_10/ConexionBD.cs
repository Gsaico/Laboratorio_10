using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;



namespace Laboratorio2
{
    public class ConexionBD
    {

        int intentos = 0;
        private string StrConexion;
        private SqlConnection Conexion;
        private SqlDataAdapter Adapter;
        private DataSet miDataSet = new DataSet();



        public bool VerificarUsuario(string CadenaConexion, string usuario, string contraseña)
        {
                        
            //Creo el nuevo objeto SQLconexion a la variable StrConexion.
            Conexion = new SqlConnection(CadenaConexion);

            string sql = "select * from Administrativo  where Usuario='" + usuario + "' and Password='" + contraseña + "'";

            SqlCommand cmd = new SqlCommand(sql, Conexion);

            Conexion.Open();
            
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.HasRows == true)
           
                return true;
                
           
            else
                return false;

            Conexion.Close();
          
        }


    }
}
