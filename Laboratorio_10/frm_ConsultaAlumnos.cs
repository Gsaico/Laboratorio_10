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


              dgwBuscarAlumnos.DataSource = consultaralumnos.listarAlumnos("Data Source = localhost; Initial Catalog = BDAcademico; Integrated Security = True", txtBuscar.Text);
     

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ConsultaBD InsertarNuevoAlumno = new ConsultaBD();
            if (InsertarNuevoAlumno.InsertarAlumno("Data Source = localhost; Initial Catalog = BDAcademico; Integrated Security = True", txtCodigo.Text, txtNombres.Text, txtApellidos.Text, txtDNI.Text, txtFechaDeNacimiento.Text, txtSexo.Text, txtCarrera.Text, txtFechaDeIngreso.Text) == true)
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
            if (ActualizarAlumno.ActualizarAlumno ("Data Source = localhost; Initial Catalog = BDAcademico; Integrated Security = True", txtCodigo.Text, txtNombres.Text, txtApellidos.Text, txtDNI.Text, txtFechaDeNacimiento.Text, txtSexo.Text, txtCarrera.Text, txtFechaDeIngreso.Text) == true)
            {
                MessageBox.Show("El actualizacion del nuevo alumno se realizo corectamente");
            }
            else
            {
                MessageBox.Show("Existe un error en la actualizacion");
            } 
        }

        
    }
}
