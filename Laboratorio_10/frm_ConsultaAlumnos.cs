using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Laboratorio_10;

namespace Laboratorio2
{
    public partial class frm_ConsultaAlumnos : Form
    {
        public frm_ConsultaAlumnos()
        {
            InitializeComponent();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            

              ConsultaBD consultaralumnos = new ConsultaBD();

              DataTable DT = consultaralumnos.listarAlumnos(txtBuscar.Text);



              if (DT.Rows.Count > 0)
              {



              
                  limpiartextbox();
                  dgwBuscarAlumnos.DataSource = DT;

                  txtCodigo.Text = DT.Rows[0]["Codigo"].ToString();
                  txtNombres.Text = DT.Rows[0]["Nombre"].ToString();
                  txtApellidos.Text = DT.Rows[0]["Apellido"].ToString();
                  txtDNI.Text = DT.Rows[0]["DNI"].ToString();
                  txtFechaDeNacimiento.Text = DT.Rows[0]["Fec_Nac"].ToString();
                  txtSexo.Text = DT.Rows[0]["Sexo"].ToString();
                  txtCarrera.Text = DT.Rows[0]["Carrera"].ToString();
                  txtFechaDeIngreso.Text = DT.Rows[0]["Fec_Ingreso"].ToString();

                  btnInsertar.Enabled = false;
                  btnActualizar.Enabled = true;
                  btnEliminar.Enabled = true; 


              }
              else
              {
                 
                  MessageBox.Show ("No se encontraron resultados para su busqueda");
              
              
              }


            
            
           



        }

        private void limpiartextbox()
        {

            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            txtFechaDeNacimiento.Text = "";
            txtSexo.Text = "";
            txtCarrera.Text = "";
            txtFechaDeIngreso.Text = "";
        
        
        }

        private void HabilitarTextbox()
        {

            txtCodigo.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtDNI.Enabled = true;
            txtFechaDeNacimiento.Enabled = true;
            txtSexo.Enabled = true;
            txtCarrera.Enabled = true;
            txtFechaDeIngreso.Enabled = true;


        }

        private void DeshabilitarTextbox()
        {

            txtCodigo.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtDNI.Enabled = false;
            txtFechaDeNacimiento.Enabled = false;
            txtSexo.Enabled = false;
            txtCarrera.Enabled = false;
            txtFechaDeIngreso.Enabled = false;


        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ConsultaBD InsertarNuevoAlumno = new ConsultaBD();
            if (InsertarNuevoAlumno.InsertarAlumno( txtCodigo.Text, txtNombres.Text, txtApellidos.Text, txtDNI.Text, txtFechaDeNacimiento.Text, txtSexo.Text, txtCarrera.Text, txtFechaDeIngreso.Text) == true)
            {
                MessageBox.Show("El insercion del nuevo alumno se realizo corectamente");
            } 
            else
            {
                MessageBox.Show("Existe un error en la insercion");
            } 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ConsultaBD ActualizarAlumno = new ConsultaBD();
            if (ActualizarAlumno.ActualizarAlumno ( txtCodigo.Text, txtNombres.Text, txtApellidos.Text, txtDNI.Text, txtFechaDeNacimiento.Text, txtSexo.Text, txtCarrera.Text, txtFechaDeIngreso.Text) == true)
            {

                limpiargridview();
                limpiartextbox();

                  ConsultaBD consultaralumnosaaaa = new ConsultaBD();

                  DataTable DTr = consultaralumnosaaaa.listarAlumnos(txtBuscar.Text);

                  dgwBuscarAlumnos.DataSource = DTr;

                  txtCodigo.Text = DTr.Rows[0]["Codigo"].ToString();
                  txtNombres.Text = DTr.Rows[0]["Nombre"].ToString();
                  txtApellidos.Text = DTr.Rows[0]["Apellido"].ToString();
                  txtDNI.Text = DTr.Rows[0]["DNI"].ToString();
                  txtFechaDeNacimiento.Text = DTr.Rows[0]["Fec_Nac"].ToString();
                  txtSexo.Text = DTr.Rows[0]["Sexo"].ToString();
                  txtCarrera.Text = DTr.Rows[0]["Carrera"].ToString();
                  txtFechaDeIngreso.Text = DTr.Rows[0]["Fec_Ingreso"].ToString();

                MessageBox.Show("El actualizacion del nuevo alumno se realizo corectamente");
            }
            else
            {
                MessageBox.Show("Existe un error en la actualizacion");
            } 
        }

        private void limpiargridview()

        {

            int renglon = dgwBuscarAlumnos.CurrentCell.RowIndex;
            dgwBuscarAlumnos.Rows.RemoveAt(renglon); 
        
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConsultaBD EliminarAlumno = new ConsultaBD();
            if (EliminarAlumno.EliminarAlumno ( txtCodigo.Text) == true)
            {

                limpiargridview();

                limpiartextbox();
                DeshabilitarTextbox();
                MessageBox.Show("La eliminacion de datos se realizo corectamente");


            }
            else
            {
                MessageBox.Show("Existe un error en la eliminacion de datos");
            } 
        }

        private void btnExaminar_Click(object sender, EventArgs e)
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
                    rutaimagen = openFileDialog1.FileName;
                    picFoto.Enabled = true;


                    picFoto.Image = Image.FromFile(rutaimagen);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: no se pudo leer el archivo del disco. Original error: " + ex.Message);
                }
            }

        }

        private void dgwBuscarAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgwBuscarAlumnos.Rows[e.RowIndex];
           
                txtCodigo.Text = Convert.ToString(row.Cells[0].Value);
                txtNombres.Text = Convert.ToString(row.Cells[1].Value);
                txtApellidos.Text = Convert.ToString(row.Cells[2].Value);
                txtDNI.Text = Convert.ToString(row.Cells[3].Value);
                txtFechaDeNacimiento.Text = Convert.ToString(row.Cells[4].Value);
                txtSexo.Text = Convert.ToString(row.Cells[5].Value);
                txtCarrera.Text = Convert.ToString(row.Cells[6].Value);
                txtFechaDeIngreso.Text = Convert.ToString(row.Cells[7].Value);
             

          



        }

      

        
    }
}
