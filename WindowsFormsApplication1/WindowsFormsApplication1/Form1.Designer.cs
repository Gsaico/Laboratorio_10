namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.picMostrar = new System.Windows.Forms.PictureBox();
            this.picGrabar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrabar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(38, 364);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(75, 23);
            this.btnMostar.TabIndex = 0;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(282, 350);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // picMostrar
            // 
            this.picMostrar.Location = new System.Drawing.Point(38, 39);
            this.picMostrar.Name = "picMostrar";
            this.picMostrar.Size = new System.Drawing.Size(184, 291);
            this.picMostrar.TabIndex = 3;
            this.picMostrar.TabStop = false;
            // 
            // picGrabar
            // 
            this.picGrabar.Image = global::WindowsFormsApplication1.Properties.Resources.Chrysanthemum;
            this.picGrabar.Location = new System.Drawing.Point(293, 39);
            this.picGrabar.Name = "picGrabar";
            this.picGrabar.Size = new System.Drawing.Size(189, 291);
            this.picGrabar.TabIndex = 2;
            this.picGrabar.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picMostrar);
            this.Controls.Add(this.picGrabar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnMostar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrabar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.PictureBox picGrabar;
        private System.Windows.Forms.PictureBox picMostrar;
        private System.Windows.Forms.Button button1;
    }
}

