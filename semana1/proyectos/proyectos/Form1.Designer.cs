namespace proyectos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btcalcular = new System.Windows.Forms.Button();
            this.Tbaltura = new System.Windows.Forms.TextBox();
            this.Tbpeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contador = new System.Windows.Forms.Button();
            this.click = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.conv = new System.Windows.Forms.Button();
            this.celci = new System.Windows.Forms.TextBox();
            this.faren = new System.Windows.Forms.TextBox();
            this.cel = new System.Windows.Forms.Label();
            this.Fah = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 394);
            this.tabControl1.TabIndex = 0;
           
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btcalcular);
            this.tabPage1.Controls.Add(this.Tbaltura);
            this.tabPage1.Controls.Add(this.Tbpeso);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IMC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btcalcular
            // 
            this.Btcalcular.Location = new System.Drawing.Point(181, 130);
            this.Btcalcular.Name = "Btcalcular";
            this.Btcalcular.Size = new System.Drawing.Size(84, 38);
            this.Btcalcular.TabIndex = 4;
            this.Btcalcular.Text = "CALCULAR";
            this.Btcalcular.UseVisualStyleBackColor = true;
            this.Btcalcular.Click += new System.EventHandler(this.Btcalcular_Click);
            // 
            // Tbaltura
            // 
            this.Tbaltura.Location = new System.Drawing.Point(181, 74);
            this.Tbaltura.Name = "Tbaltura";
            this.Tbaltura.Size = new System.Drawing.Size(94, 22);
            this.Tbaltura.TabIndex = 3;
            // 
            // Tbpeso
            // 
            this.Tbpeso.Location = new System.Drawing.Point(181, 39);
            this.Tbpeso.Name = "Tbpeso";
            this.Tbpeso.Size = new System.Drawing.Size(94, 22);
            this.Tbpeso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese su altura (m)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese su peso (kg)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.contador);
            this.tabPage2.Controls.Add(this.click);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(428, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contador
            // 
            this.contador.Location = new System.Drawing.Point(116, 135);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(118, 48);
            this.contador.TabIndex = 1;
            this.contador.Text = "CONTADOR";
            this.contador.UseVisualStyleBackColor = true;
            this.contador.Click += new System.EventHandler(this.contador_Click);
            // 
            // click
            // 
            this.click.AutoSize = true;
            this.click.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click.Location = new System.Drawing.Point(151, 49);
            this.click.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(50, 54);
            this.click.TabIndex = 0;
            this.click.Text = "0";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.conv);
            this.tabPage3.Controls.Add(this.celci);
            this.tabPage3.Controls.Add(this.faren);
            this.tabPage3.Controls.Add(this.cel);
            this.tabPage3.Controls.Add(this.Fah);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(428, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convensor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // conv
            // 
            this.conv.Location = new System.Drawing.Point(152, 157);
            this.conv.Name = "conv";
            this.conv.Size = new System.Drawing.Size(110, 39);
            this.conv.TabIndex = 4;
            this.conv.Text = "Convertir";
            this.conv.UseVisualStyleBackColor = true;
            this.conv.Click += new System.EventHandler(this.conv_Click);
            // 
            // celci
            // 
            this.celci.Location = new System.Drawing.Point(162, 89);
            this.celci.Name = "celci";
            this.celci.Size = new System.Drawing.Size(100, 22);
            this.celci.TabIndex = 3;
            // 
            // faren
            // 
            this.faren.Location = new System.Drawing.Point(162, 50);
            this.faren.Name = "faren";
            this.faren.Size = new System.Drawing.Size(100, 22);
            this.faren.TabIndex = 2;
            // 
            // cel
            // 
            this.cel.AutoSize = true;
            this.cel.Location = new System.Drawing.Point(83, 92);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(51, 16);
            this.cel.TabIndex = 1;
            this.cel.Text = "Celcius";
            // 
            // Fah
            // 
            this.Fah.AutoSize = true;
            this.Fah.Location = new System.Drawing.Point(83, 53);
            this.Fah.Name = "Fah";
            this.Fah.Size = new System.Drawing.Size(70, 16);
            this.Fah.TabIndex = 0;
            this.Fah.Text = "Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 394);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Tbpeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Btcalcular;
        private System.Windows.Forms.TextBox Tbaltura;
        private System.Windows.Forms.Button contador;
        private System.Windows.Forms.Label click;
        private System.Windows.Forms.TextBox faren;
        private System.Windows.Forms.Label cel;
        private System.Windows.Forms.Label Fah;
        private System.Windows.Forms.TextBox celci;
        private System.Windows.Forms.Button conv;
    }
}

