namespace visual1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btInical = new System.Windows.Forms.Button();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.ctClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "usuario:";
        
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // btInical
            // 
            this.btInical.Location = new System.Drawing.Point(226, 247);
            this.btInical.Margin = new System.Windows.Forms.Padding(4);
            this.btInical.Name = "btInical";
            this.btInical.Size = new System.Drawing.Size(210, 38);
            this.btInical.TabIndex = 4;
            this.btInical.Text = "INICIAR SEION";
            this.btInical.UseVisualStyleBackColor = true;
            this.btInical.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctUsuario
            // 
            this.ctUsuario.Location = new System.Drawing.Point(226, 138);
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(210, 22);
            this.ctUsuario.TabIndex = 5;
          
            // 
            // ctClave
            // 
            this.ctClave.Location = new System.Drawing.Point(226, 188);
            this.ctClave.Name = "ctClave";
            this.ctClave.PasswordChar = '*';
            this.ctClave.Size = new System.Drawing.Size(210, 22);
            this.ctClave.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 399);
            this.Controls.Add(this.ctClave);
            this.Controls.Add(this.ctUsuario);
            this.Controls.Add(this.btInical);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInical;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.TextBox ctClave;
    }
}

