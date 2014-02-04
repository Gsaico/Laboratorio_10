using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboratorio2
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_de_Usuarios hijo = new frm_Mantenimiento_de_Usuarios();
            hijo.MdiParent = this;
            hijo.Show(); 
        }

        private void consultaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_ConsultaAlumnos   hijo = new frm_ConsultaAlumnos();
            hijo.MdiParent = this;
            hijo.Show(); 
        }
    }
}
