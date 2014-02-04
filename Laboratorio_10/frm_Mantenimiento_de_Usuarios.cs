using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Laboratorio2
{
    public partial class frm_Mantenimiento_de_Usuarios : Form
    {
        public frm_Mantenimiento_de_Usuarios()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
          {
       
        

         if (rbtn_NuevoUsuario.Checked==true  )
         {

             string fileName = "D:\\BD.TXT";

             StreamWriter writer = File.AppendText(fileName);
             writer.WriteLine(txtCodigo.Text + txtPassword.Text + txtRol.Text);
             writer.Close();

         }



            
        }

        private void frm_Mantenimiento_de_Usuarios_Load(object sender, EventArgs e)
        {

           


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            lbx_Usuarios.Items.Clear();

            // Leo el archivo linea a linea D:\\BD.TXT
            string sPath = "D:\\BD.TXT";
            StreamReader sr = new StreamReader(sPath);
            String LINEA = "";
            string USUARIO = "";


            while (LINEA != null)
            {
                LINEA = sr.ReadLine();


                if (LINEA != null)
                {
                    USUARIO = LINEA.Substring(0, 6);
                    lbx_Usuarios.Items.Add(USUARIO);

                }
            }
            //*
        }

        private void rbtn_NuevoUsuario_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void btn_Derecha_Click(object sender, EventArgs e)
        {
            
            txt_UsuarioParaModificar.Text= lbx_Usuarios.SelectedItem.ToString();

            lbx_Usuarios.SelectedIndices.Clear();
      
        }

        private void btn_GrabarModificacion_Click(object sender, EventArgs e)
        {

            string [] valores;
            valores = null;


            int n;

            n = 0;

            // Leo el archivo linea a linea D:\\BD.TXT
            string sPath = "D:\\BD.TXT";
            StreamReader sr = new StreamReader(sPath);
            String LINEA = "";
      


            while (LINEA != null)
            {
                LINEA = sr.ReadLine();

                
                if (LINEA != null)
                {
                    valores[0] = LINEA.Substring(0, 100);
                  }
                             


            }
            //*

     






        }
    }
}
