namespace MultiLenguaje
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
            this.lblLenguaje = new System.Windows.Forms.Label();
            this.ckActivo = new System.Windows.Forms.CheckBox();
            this.btnMensaje = new System.Windows.Forms.Button();
            this.lblnuevo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLenguaje
            // 
            this.lblLenguaje.AutoSize = true;
            this.lblLenguaje.Location = new System.Drawing.Point(47, 19);
            this.lblLenguaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLenguaje.Name = "lblLenguaje";
            this.lblLenguaje.Size = new System.Drawing.Size(57, 21);
            this.lblLenguaje.TabIndex = 0;
            this.lblLenguaje.Text = "label1";
            // 
            // ckActivo
            // 
            this.ckActivo.AutoSize = true;
            this.ckActivo.Location = new System.Drawing.Point(70, 171);
            this.ckActivo.Margin = new System.Windows.Forms.Padding(5);
            this.ckActivo.Name = "ckActivo";
            this.ckActivo.Size = new System.Drawing.Size(113, 25);
            this.ckActivo.TabIndex = 1;
            this.ckActivo.Text = "checkBox1";
            this.ckActivo.UseVisualStyleBackColor = true;
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(338, 37);
            this.btnMensaje.Margin = new System.Windows.Forms.Padding(5);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(125, 37);
            this.btnMensaje.TabIndex = 2;
            this.btnMensaje.Text = "button1";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnuevo
            // 
            this.lblnuevo.AutoSize = true;
            this.lblnuevo.Location = new System.Drawing.Point(47, 79);
            this.lblnuevo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnuevo.Name = "lblnuevo";
            this.lblnuevo.Size = new System.Drawing.Size(57, 21);
            this.lblnuevo.TabIndex = 3;
            this.lblnuevo.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 29);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(338, 139);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(125, 37);
            this.btnAplicar.TabIndex = 7;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblnuevo);
            this.panel1.Controls.Add(this.lblLenguaje);
            this.panel1.Location = new System.Drawing.Point(56, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 108);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 239);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnMensaje);
            this.Controls.Add(this.ckActivo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLenguaje;
        private System.Windows.Forms.CheckBox ckActivo;
        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Label lblnuevo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Panel panel1;
    }
}

