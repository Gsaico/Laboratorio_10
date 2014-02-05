using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            InsertarImagen();

        }



        private void InsertarImagen()

        {

            //Inicializamos la cadena de conexion 
            SqlConnection con = new SqlConnection("Server=.;database=BDAcademico;integrated security=true");

            //Ingresamos la query con la conexion a SqlCommand
            SqlCommand com = new SqlCommand("insert into TablaUsuarios(Codigo,Foto) values(2,@Foto)", con);

            //Declaramos un contenedor para el almacenamiento de la imagen
            MemoryStream stream = new MemoryStream();

            //Grabamos la imagen el objeto stream 
            picGrabar.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Esta parte es importante ya que convertimos la imagen a bytes
            byte[] pic = stream.ToArray();

            //Terminamos de ejecutar nuestra sentencia para ellos enviamos la imagen transformada a Bytes a nuestro parametro dentro de la query
            com.Parameters.AddWithValue("@Foto", pic);
            try
            {
                //Abrimos la conexion
                con.Open();
                //Ejecutamos
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                //Cerramos la conexion
                con.Close();
            }
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            //Inicializamos la cadena de conexion 
            SqlConnection connect = new SqlConnection ("Server=.;database=BDAcademico;integrated security=true");
            
            
            //Ingresamos la query con la conexion a SqlCommand
             SqlCommand command = new SqlCommand ("select Foto from TablaUsuarios where Codigo=2", connect);


             //declaro un nuevo objeto SqlDataAdapter con la la     QUERY Y LA CONEXION
            SqlDataAdapter dp = new SqlDataAdapter(command);

            //declaro un nuevo objeto  DataSet  con el nombre de memoria "MyImages"
            DataSet ds = new DataSet("MyImages");


            //declaro un nuevo objeto byte tipo array unidimensional
            byte[] MyData = new byte[0];


            //lleno mi dataset "MyImages" mediante el SqlDataAdapter
            dp.Fill(ds, "MyImages");

            DataRow myRow;

            myRow = ds.Tables["MyImages"].Rows[0];

            MyData = (byte[])myRow["Foto"];

            MemoryStream stream = new MemoryStream(MyData);
            picMostrar.Image = Image.FromStream(stream);

        }



        private void MostrarImagen()
        {
         //Inicializamos la cadena de conexion 
            SqlConnection connect = new SqlConnection ("Server=.;database=BDAcademico;integrated security=true");
            
            
            //Ingresamos la query con la conexion a SqlCommand
             SqlCommand command = new SqlCommand ("select Foto from TablaUsuarios where Codigo=2", connect);


             //declaro un nuevo objeto SqlDataAdapter con la la     QUERY Y LA CONEXION
            SqlDataAdapter dp = new SqlDataAdapter(command);

            //declaro un nuevo objeto  DataSet  con el nombre de memoria "MyImages"
            DataSet ds = new DataSet("MyImages");


            //declaro un nuevo objeto byte tipo array unidimensional
            byte[] MyData = new byte[0];


            //lleno mi dataset "MyImages" mediante el SqlDataAdapter
            dp.Fill(ds, "MyImages");

            DataRow myRow;

            myRow = ds.Tables["MyImages"].Rows[0];

            MyData = (byte[])myRow["Foto"];

            MemoryStream stream = new MemoryStream(MyData);
            picMostrar.Image = Image.FromStream(stream);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string rutaimagen = "";
                     
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                            rutaimagen=openFileDialog1.FileName;

                            picGrabar.Image = Image.FromFile(rutaimagen);
                                             
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: no se pudo leer el archivo del disco. Original error: " + ex.Message);
                }
            }

          
        }
    }
}
