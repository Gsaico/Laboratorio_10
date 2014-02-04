namespace Laboratorio2
{
    partial class frm_Mantenimiento_de_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.rbtn_ModificarUsuario = new System.Windows.Forms.RadioButton();
            this.rbtn_NuevoUsuario = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_UsuarioParaModificar = new System.Windows.Forms.TextBox();
            this.txt_NuevoPassword = new System.Windows.Forms.TextBox();
            this.txt_NuevoRol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_GrabarModificacion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Derecha = new System.Windows.Forms.Button();
            this.btn_Izquierda = new System.Windows.Forms.Button();
            this.lbx_Usuarios = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(313, 50);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(313, 21);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANTENIMIENTO DE USUARIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elija una Opción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese Código ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = " Ingrese Rol";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(124, 78);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(166, 20);
            this.txtRol.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(124, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(166, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // rbtn_ModificarUsuario
            // 
            this.rbtn_ModificarUsuario.AutoSize = true;
            this.rbtn_ModificarUsuario.Location = new System.Drawing.Point(226, 75);
            this.rbtn_ModificarUsuario.Name = "rbtn_ModificarUsuario";
            this.rbtn_ModificarUsuario.Size = new System.Drawing.Size(107, 17);
            this.rbtn_ModificarUsuario.TabIndex = 10;
            this.rbtn_ModificarUsuario.TabStop = true;
            this.rbtn_ModificarUsuario.Text = "Modificar Usuario";
            this.rbtn_ModificarUsuario.UseVisualStyleBackColor = true;
            this.rbtn_ModificarUsuario.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_NuevoUsuario
            // 
            this.rbtn_NuevoUsuario.AutoSize = true;
            this.rbtn_NuevoUsuario.Location = new System.Drawing.Point(18, 75);
            this.rbtn_NuevoUsuario.Name = "rbtn_NuevoUsuario";
            this.rbtn_NuevoUsuario.Size = new System.Drawing.Size(137, 17);
            this.rbtn_NuevoUsuario.TabIndex = 11;
            this.rbtn_NuevoUsuario.TabStop = true;
            this.rbtn_NuevoUsuario.Text = "Ingresar Nuevo Usuario";
            this.rbtn_NuevoUsuario.UseVisualStyleBackColor = true;
            this.rbtn_NuevoUsuario.CheckedChanged += new System.EventHandler(this.rbtn_NuevoUsuario_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtRol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGrabar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.lbx_Usuarios);
            this.groupBox2.Controls.Add(this.btn_Izquierda);
            this.groupBox2.Controls.Add(this.btn_Derecha);
            this.groupBox2.Controls.Add(this.txt_UsuarioParaModificar);
            this.groupBox2.Controls.Add(this.txt_NuevoPassword);
            this.groupBox2.Controls.Add(this.txt_NuevoRol);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_GrabarModificacion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(18, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 229);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // txt_UsuarioParaModificar
            // 
            this.txt_UsuarioParaModificar.Location = new System.Drawing.Point(259, 32);
            this.txt_UsuarioParaModificar.Name = "txt_UsuarioParaModificar";
            this.txt_UsuarioParaModificar.Size = new System.Drawing.Size(129, 20);
            this.txt_UsuarioParaModificar.TabIndex = 9;
            // 
            // txt_NuevoPassword
            // 
            this.txt_NuevoPassword.Location = new System.Drawing.Point(259, 78);
            this.txt_NuevoPassword.Name = "txt_NuevoPassword";
            this.txt_NuevoPassword.Size = new System.Drawing.Size(129, 20);
            this.txt_NuevoPassword.TabIndex = 8;
            // 
            // txt_NuevoRol
            // 
            this.txt_NuevoRol.Location = new System.Drawing.Point(259, 121);
            this.txt_NuevoRol.Name = "txt_NuevoRol";
            this.txt_NuevoRol.Size = new System.Drawing.Size(129, 20);
            this.txt_NuevoRol.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = " Ingrese Nuevo Rol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Usuario:";
            // 
            // btn_GrabarModificacion
            // 
            this.btn_GrabarModificacion.Location = new System.Drawing.Point(259, 158);
            this.btn_GrabarModificacion.Name = "btn_GrabarModificacion";
            this.btn_GrabarModificacion.Size = new System.Drawing.Size(75, 23);
            this.btn_GrabarModificacion.TabIndex = 1;
            this.btn_GrabarModificacion.Text = "Grabar";
            this.btn_GrabarModificacion.UseVisualStyleBackColor = true;
            this.btn_GrabarModificacion.Click += new System.EventHandler(this.btn_GrabarModificacion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ingrese Nuevo  Password";
            // 
            // btn_Derecha
            // 
            this.btn_Derecha.Location = new System.Drawing.Point(221, 57);
            this.btn_Derecha.Name = "btn_Derecha";
            this.btn_Derecha.Size = new System.Drawing.Size(29, 23);
            this.btn_Derecha.TabIndex = 10;
            this.btn_Derecha.Text = ">>";
            this.btn_Derecha.UseVisualStyleBackColor = true;
            this.btn_Derecha.Click += new System.EventHandler(this.btn_Derecha_Click);
            // 
            // btn_Izquierda
            // 
            this.btn_Izquierda.Location = new System.Drawing.Point(221, 86);
            this.btn_Izquierda.Name = "btn_Izquierda";
            this.btn_Izquierda.Size = new System.Drawing.Size(29, 23);
            this.btn_Izquierda.TabIndex = 11;
            this.btn_Izquierda.Text = "<<";
            this.btn_Izquierda.UseVisualStyleBackColor = true;
            // 
            // lbx_Usuarios
            // 
            this.lbx_Usuarios.FormattingEnabled = true;
            this.lbx_Usuarios.Location = new System.Drawing.Point(18, 19);
            this.lbx_Usuarios.Name = "lbx_Usuarios";
            this.lbx_Usuarios.Size = new System.Drawing.Size(78, 199);
            this.lbx_Usuarios.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(124, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(78, 199);
            this.listBox1.TabIndex = 13;
            // 
            // frm_Mantenimiento_de_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtn_NuevoUsuario);
            this.Controls.Add(this.rbtn_ModificarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Mantenimiento_de_Usuarios";
            this.Text = "frm_Mantenimiento_de_Usuarios";
            this.Load += new System.EventHandler(this.frm_Mantenimiento_de_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton rbtn_ModificarUsuario;
        private System.Windows.Forms.RadioButton rbtn_NuevoUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbx_Usuarios;
        private System.Windows.Forms.Button btn_Izquierda;
        private System.Windows.Forms.Button btn_Derecha;
        private System.Windows.Forms.TextBox txt_UsuarioParaModificar;
        private System.Windows.Forms.TextBox txt_NuevoPassword;
        private System.Windows.Forms.TextBox txt_NuevoRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_GrabarModificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}