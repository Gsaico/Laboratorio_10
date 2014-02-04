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


        public bool InsertarAlumno(string CadenaConexion, string Codigo, string Nombre,string  Apellido, string DNI,string  Fec_Nac, string Sexo, string Carrera, string Fec_Ingreso)
        {

            //Creo el nuevo objeto SQLconexion a la variable StrConexion.
           

        try
        {            
             Conexion = new SqlConnection(CadenaConexion);

            string sql = "insert into TablaAlumnos(Codigo, Nombre, Apellido, DNI, Fec_Nac, Sexo, Carrera, Fec_Ingreso) values( '" + Codigo + "','" + Nombre + "','" + Apellido + "','" + DNI + "','" + Fec_Nac + "','" + Sexo + "','" + Carrera + "','" + Fec_Ingreso + "')";

            SqlCommand cmd = new SqlCommand(sql, Conexion);

            Conexion.Open();

           cmd.BeginExecuteNonQuery();

            return true;
            
        }

        catch (Exception ex)
        {
            
            return false;
        }


           

            Conexion.Close();

        }


        public bool ActualizarAlumno(string CadenaConexion, string Codigo, string Nombre, string Apellido, string DNI, string Fec_Nac, string Sexo, string Carrera, string Fec_Ingreso)
        {

            //Creo el nuevo objeto SQLconexion a la variable StrConexion.


            try
            {
                Conexion = new SqlConnection(CadenaConexion);

                string sql = "UPDATE TablaAlumnos SET  Nombre='"+Nombre+ "', Apellido='"+Apellido+ "', DNI='"+DNI+ "', Fec_Nac='"+Fec_Nac+ "', Sexo='"+Sexo+ "', Carrera='"+Carrera+ "', Fec_Ingreso='"+Fec_Ingreso+ "'"+ "WHERE Codigo='" + Codigo +"'";
                
                
                SqlCommand cmd = new SqlCommand(sql, Conexion);

                Conexion.Open();

                cmd.BeginExecuteNonQuery();

                return true;

            }

            catch (Exception ex)
            {

                return false;
            }




            Conexion.Close();

        }

    }
}
