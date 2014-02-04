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

        
    }
}
