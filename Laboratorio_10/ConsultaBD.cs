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
    
        


        public DataTable listarAlumnos( string CodigoAlumno)
        {

            //Creo el nuevo objeto SQLconexion a la variable Conexion.
            Conexion = new SqlConnection("Data Source = localhost; Initial Catalog = BDAcademico; Integrated Security = True");

            string sqlquery = "select * from TablaAlumnos where Codigo='" + CodigoAlumno + "'";

                      
            Adapter = new SqlDataAdapter(sqlquery, Conexion);
            //Creo el DataTable 
            DataTable dt = new DataTable();

            //Relleno el datatable con el adaptador 

            Adapter.Fill(dt);

                       
         
            return dt;  



        }


        public bool InsertarAlumno(string Codigo, string Nombre, string Apellido, string DNI, string Fec_Nac, string Sexo, string Carrera, string Fec_Ingreso, byte[] foto)
        {

            //Creo el nuevo objeto SQLconexion a la variable StrConexion.
           

       
            Conexion = new SqlConnection("Data Source = localhost; Initial Catalog = BDAcademico; Integrated Security = True");

            string sql = "insert into TablaAlumnos(Codigo, Nombre, Apellido, DNI, Fec_Nac, Sexo, Carrera, Fec_Ingreso, Foto) values( '" + Codigo + "','" + Nombre + "','" + Apellido + "','" + DNI + "','" + Fec_Nac + "','" + Sexo + "','" + Carrera + "','" + Fec_Ingreso + "', @Foto)";

            SqlCommand cmd = new SqlCommand(sql, Conexion);




            cmd.Parameters.AddWithValue("@Foto", foto);
            try
            {
                //Abrimos la conexion
                Conexion.Open();
                //Ejecutamos
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {

                //Cerramos la conexion
                Conexion.Close();
            }











        }


        public bool ActualizarAlumno(string Codigo, string Nombre, string Apellido, string DNI, string Fec_Nac, string Sexo, string Carrera, string Fec_Ingreso, byte[] fotoactualizar)
        {

            //Creo el nuevo objeto SQLconexion a la variable StrConexion.


            
                Conexion = new SqlConnection("Data Source = localhost; Initial Catalog = BDAcademico; Integrated Security = True");

                string sql = "UPDATE TablaAlumnos SET  Nombre='"+Nombre+ "', Apellido='"+Apellido+ "', DNI='"+DNI+ "', Fec_Nac='"+Fec_Nac+ "', Sexo='"+Sexo+ "', Carrera='"+Carrera+ "', Fec_Ingreso='"+Fec_Ingreso+ "', Foto = @Foto WHERE Codigo='" + Codigo +"'";
                
                
                SqlCommand cmd = new SqlCommand(sql, Conexion);

                cmd.Parameters.AddWithValue("@Foto", fotoactualizar);
                try
                {
                    //Abrimos la conexion
                    Conexion.Open();
                    //Ejecutamos
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {

                    //Cerramos la conexion
                    Conexion.Close();
                }

           

        }
        public bool EliminarAlumno( string Codigo)
        {

            //Creo el nuevo objeto SQLconexion a la variable StrConexion.


            try
            {
                Conexion = new SqlConnection("Data Source = localhost; Initial Catalog = BDAcademico; Integrated Security = True");

                string sql = "DELETE FROM TablaAlumnos WHERE Codigo = '" + Codigo +"'";


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
