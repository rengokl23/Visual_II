namespace calculadora
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
            this.tbpantalla = new System.Windows.Forms.TextBox();
            this.btsumar = new System.Windows.Forms.Button();
            this.btresta = new System.Windows.Forms.Button();
            this.btmulti = new System.Windows.Forms.Button();
            this.btdivi = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btlimpiar = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btbor = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btpun = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btMme = new System.Windows.Forms.Button();
            this.btMc = new System.Windows.Forms.Button();
            this.btMmr = new System.Windows.Forms.Button();
            this.btInver = new System.Windows.Forms.Button();
            this.btMmas = new System.Windows.Forms.Button();
            this.btLog = new System.Windows.Forms.Button();
            this.btCuadra = new System.Windows.Forms.Button();
            this.btLnn = new System.Windows.Forms.Button();
            this.btExponen = new System.Windows.Forms.Button();
            this.btExp = new System.Windows.Forms.Button();
            this.btRai = new System.Windows.Forms.Button();
            this.btPi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbpantalla
            // 
            this.tbpantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpantalla.Location = new System.Drawing.Point(77, 35);
            this.tbpantalla.Multiline = true;
            this.tbpantalla.Name = "tbpantalla";
            this.tbpantalla.ReadOnly = true;
            this.tbpantalla.Size = new System.Drawing.Size(254, 47);
            this.tbpantalla.TabIndex = 0;
            this.tbpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btsumar
            // 
            this.btsumar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsumar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btsumar.Location = new System.Drawing.Point(77, 88);
            this.btsumar.Name = "btsumar";
            this.btsumar.Size = new System.Drawing.Size(59, 40);
            this.btsumar.TabIndex = 1;
            this.btsumar.Text = "+";
            this.btsumar.UseVisualStyleBackColor = false;
            this.btsumar.Click += new System.EventHandler(this.btsumar_Click);
            // 
            // btresta
            // 
            this.btresta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btresta.Location = new System.Drawing.Point(142, 88);
            this.btresta.Name = "btresta";
            this.btresta.Size = new System.Drawing.Size(59, 40);
            this.btresta.TabIndex = 2;
            this.btresta.Text = "-";
            this.btresta.UseVisualStyleBackColor = false;
            this.btresta.Click += new System.EventHandler(this.btresta_Click);
            // 
            // btmulti
            // 
            this.btmulti.BackColor = System.Drawing.Color.RoyalBlue;
            this.btmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmulti.Location = new System.Drawing.Point(207, 88);
            this.btmulti.Name = "btmulti";
            this.btmulti.Size = new System.Drawing.Size(59, 40);
            this.btmulti.TabIndex = 3;
            this.btmulti.Text = "*";
            this.btmulti.UseVisualStyleBackColor = false;
            this.btmulti.Click += new System.EventHandler(this.btmulti_Click);
            // 
            // btdivi
            // 
            this.btdivi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btdivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdivi.Location = new System.Drawing.Point(272, 88);
            this.btdivi.Name = "btdivi";
            this.btdivi.Size = new System.Drawing.Size(59, 40);
            this.btdivi.TabIndex = 4;
            this.btdivi.Text = "/";
            this.btdivi.UseVisualStyleBackColor = false;
            this.btdivi.Click += new System.EventHandler(this.btdivi_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(77, 137);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(59, 40);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(142, 134);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(59, 40);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(207, 134);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 40);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btlimpiar
            // 
            this.btlimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpiar.Location = new System.Drawing.Point(272, 180);
            this.btlimpiar.Name = "btlimpiar";
            this.btlimpiar.Size = new System.Drawing.Size(59, 40);
            this.btlimpiar.TabIndex = 8;
            this.btlimpiar.Text = "CE";
            this.btlimpiar.UseVisualStyleBackColor = false;
            this.btlimpiar.Click += new System.EventHandler(this.btlimpiar_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(77, 180);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(59, 40);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(142, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(59, 40);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(207, 180);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 40);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btbor
            // 
            this.btbor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btbor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbor.Location = new System.Drawing.Point(272, 134);
            this.btbor.Name = "btbor";
            this.btbor.Size = new System.Drawing.Size(59, 40);
            this.btbor.TabIndex = 12;
            this.btbor.Text = "BA";
            this.btbor.UseVisualStyleBackColor = false;
            this.btbor.Click += new System.EventHandler(this.btbor_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(77, 226);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(59, 40);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(142, 226);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(59, 40);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(207, 226);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(59, 40);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btpun
            // 
            this.btpun.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btpun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpun.Location = new System.Drawing.Point(207, 269);
            this.btpun.Name = "btpun";
            this.btpun.Size = new System.Drawing.Size(59, 40);
            this.btpun.TabIndex = 16;
            this.btpun.Text = ".";
            this.btpun.UseVisualStyleBackColor = false;
            this.btpun.Click += new System.EventHandler(this.btpun_Click);
            // 
            // btigual
            // 
            this.btigual.BackColor = System.Drawing.Color.RoyalBlue;
            this.btigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btigual.Location = new System.Drawing.Point(272, 226);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(59, 83);
            this.btigual.TabIndex = 17;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = false;
            this.btigual.Click += new System.EventHandler(this.btigual_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(77, 269);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(124, 40);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btMme
            // 
            this.btMme.BackColor = System.Drawing.Color.Tomato;
            this.btMme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMme.Location = new System.Drawing.Point(337, 134);
            this.btMme.Name = "btMme";
            this.btMme.Size = new System.Drawing.Size(59, 40);
            this.btMme.TabIndex = 19;
            this.btMme.Text = "M-";
            this.btMme.UseVisualStyleBackColor = false;
            this.btMme.Click += new System.EventHandler(this.btMme_Click);
            // 
            // btMc
            // 
            this.btMc.BackColor = System.Drawing.Color.Tomato;
            this.btMc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMc.Location = new System.Drawing.Point(337, 177);
            this.btMc.Name = "btMc";
            this.btMc.Size = new System.Drawing.Size(59, 40);
            this.btMc.TabIndex = 20;
            this.btMc.Text = "MC";
            this.btMc.UseVisualStyleBackColor = false;
            this.btMc.Click += new System.EventHandler(this.btMc_Click);
            // 
            // btMmr
            // 
            this.btMmr.BackColor = System.Drawing.Color.Tomato;
            this.btMmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMmr.Location = new System.Drawing.Point(337, 223);
            this.btMmr.Name = "btMmr";
            this.btMmr.Size = new System.Drawing.Size(59, 40);
            this.btMmr.TabIndex = 21;
            this.btMmr.Text = "MR";
            this.btMmr.UseVisualStyleBackColor = false;
            this.btMmr.Click += new System.EventHandler(this.btMmr_Click);
            // 
            // btInver
            // 
            this.btInver.BackColor = System.Drawing.Color.Violet;
            this.btInver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInver.Location = new System.Drawing.Point(207, 315);
            this.btInver.Name = "btInver";
            this.btInver.Size = new System.Drawing.Size(59, 40);
            this.btInver.TabIndex = 22;
            this.btInver.Text = "1/x";
            this.btInver.UseVisualStyleBackColor = false;
            this.btInver.Click += new System.EventHandler(this.btInver_Click);
            // 
            // btMmas
            // 
            this.btMmas.BackColor = System.Drawing.Color.Tomato;
            this.btMmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMmas.Location = new System.Drawing.Point(337, 91);
            this.btMmas.Name = "btMmas";
            this.btMmas.Size = new System.Drawing.Size(59, 40);
            this.btMmas.TabIndex = 23;
            this.btMmas.Text = "M+";
            this.btMmas.UseVisualStyleBackColor = false;
            this.btMmas.Click += new System.EventHandler(this.btMmas_Click);
            // 
            // btLog
            // 
            this.btLog.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLog.Location = new System.Drawing.Point(12, 229);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(59, 40);
            this.btLog.TabIndex = 24;
            this.btLog.Text = "Log ";
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click_1);
            // 
            // btCuadra
            // 
            this.btCuadra.BackColor = System.Drawing.Color.Violet;
            this.btCuadra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCuadra.Location = new System.Drawing.Point(272, 315);
            this.btCuadra.Name = "btCuadra";
            this.btCuadra.Size = new System.Drawing.Size(59, 40);
            this.btCuadra.TabIndex = 25;
            this.btCuadra.Text = "x²";
            this.btCuadra.UseVisualStyleBackColor = false;
            this.btCuadra.Click += new System.EventHandler(this.btCuadra_Click_1);
            // 
            // btLnn
            // 
            this.btLnn.BackColor = System.Drawing.Color.Violet;
            this.btLnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLnn.Location = new System.Drawing.Point(142, 315);
            this.btLnn.Name = "btLnn";
            this.btLnn.Size = new System.Drawing.Size(59, 40);
            this.btLnn.TabIndex = 26;
            this.btLnn.Text = "Ln";
            this.btLnn.UseVisualStyleBackColor = false;
            this.btLnn.Click += new System.EventHandler(this.btLnn_Click);
            // 
            // btExponen
            // 
            this.btExponen.BackColor = System.Drawing.Color.Violet;
            this.btExponen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExponen.Location = new System.Drawing.Point(77, 315);
            this.btExponen.Name = "btExponen";
            this.btExponen.Size = new System.Drawing.Size(59, 40);
            this.btExponen.TabIndex = 27;
            this.btExponen.Text = "Exp";
            this.btExponen.UseVisualStyleBackColor = false;
            this.btExponen.Click += new System.EventHandler(this.btExponen_Click);
            // 
            // btExp
            // 
            this.btExp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExp.Location = new System.Drawing.Point(12, 91);
            this.btExp.Name = "btExp";
            this.btExp.Size = new System.Drawing.Size(59, 40);
            this.btExp.TabIndex = 28;
            this.btExp.Text = "^";
            this.btExp.UseVisualStyleBackColor = false;
            this.btExp.Click += new System.EventHandler(this.btExp_Click);
            // 
            // btRai
            // 
            this.btRai.BackColor = System.Drawing.Color.RoyalBlue;
            this.btRai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRai.Location = new System.Drawing.Point(12, 137);
            this.btRai.Name = "btRai";
            this.btRai.Size = new System.Drawing.Size(59, 40);
            this.btRai.TabIndex = 29;
            this.btRai.Text = "√ ";
            this.btRai.UseVisualStyleBackColor = false;
            this.btRai.Click += new System.EventHandler(this.btRai_Click);
            // 
            // btPi
            // 
            this.btPi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPi.Location = new System.Drawing.Point(12, 183);
            this.btPi.Name = "btPi";
            this.btPi.Size = new System.Drawing.Size(59, 40);
            this.btPi.TabIndex = 30;
            this.btPi.Text = "π ";
            this.btPi.UseVisualStyleBackColor = false;
            this.btPi.Click += new System.EventHandler(this.btPi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 423);
            this.Controls.Add(this.btPi);
            this.Controls.Add(this.btRai);
            this.Controls.Add(this.btExp);
            this.Controls.Add(this.btExponen);
            this.Controls.Add(this.btLnn);
            this.Controls.Add(this.btCuadra);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.btMmas);
            this.Controls.Add(this.btInver);
            this.Controls.Add(this.btMmr);
            this.Controls.Add(this.btMc);
            this.Controls.Add(this.btMme);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.btpun);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btbor);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btlimpiar);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btdivi);
            this.Controls.Add(this.btmulti);
            this.Controls.Add(this.btresta);
            this.Controls.Add(this.btsumar);
            this.Controls.Add(this.tbpantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbpantalla;
        private System.Windows.Forms.Button btresta;
        private System.Windows.Forms.Button btmulti;
        private System.Windows.Forms.Button btdivi;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btlimpiar;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btbor;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btpun;
        private System.Windows.Forms.Button btigual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btMme;
        private System.Windows.Forms.Button btMc;
        private System.Windows.Forms.Button btMmr;
        private System.Windows.Forms.Button btInver;
        private System.Windows.Forms.Button btMmas;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btCuadra;
        private System.Windows.Forms.Button btLnn;
        private System.Windows.Forms.Button btExponen;
        private System.Windows.Forms.Button btExp;
        private System.Windows.Forms.Button btRai;
        private System.Windows.Forms.Button btPi;
        private System.Windows.Forms.Button btsumar;
    }
}

