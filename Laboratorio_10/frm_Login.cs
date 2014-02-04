using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;

using System.IO;


namespace Laboratorio2
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

      int intentos = 0;
   
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verifico el numero de intentos que lleva
            intentos = intentos + 1;
            if (intentos == 4)
            {
                MessageBox.Show("el limite de intentos termino");
                this.Close();

            }
            //*


            // declaro la clase a utilizar
            ConexionBD claseconexion = new ConexionBD();
            //*

           // verifico si existe el usuario y la contraseña
            if (claseconexion.VerificarUsuario("Data Source = localhost; Initial Catalog = BDAcademico; Integrated Security = True", txtUsuario.Text, txtPassword.Text) == true)
            {
                MessageBox.Show("Acceso Permitido");
                frm_Principal nuevO = new frm_Principal();
                this.Hide();
                nuevO.Show();
            }
                
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
           //*     

       

    }

      
   

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

               
        public string retornarmd5 (string CadenaPassword)
        {
            string login_pass = CadenaPassword;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
            byte[] hash = md5.ComputeHash(inputBytes);
            login_pass = BitConverter.ToString(hash).Replace("-", "");

            return login_pass;
        }

       
        
 


       

       
    }
}
