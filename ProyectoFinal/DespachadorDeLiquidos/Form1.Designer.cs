namespace DespachadorDeLiquidos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbCuba = new System.Windows.Forms.RadioButton();
            this.rdbSoloHielo = new System.Windows.Forms.RadioButton();
            this.rdbShot = new System.Windows.Forms.RadioButton();
            this.rdbPersonalizado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbAlcohol = new System.Windows.Forms.TextBox();
            this.txtbRefresco = new System.Windows.Forms.TextBox();
            this.txtbAguaMineral = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbHielos = new System.Windows.Forms.TextBox();
            this.cmbPorcion = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPersonalizado);
            this.groupBox1.Controls.Add(this.rdbShot);
            this.groupBox1.Controls.Add(this.rdbSoloHielo);
            this.groupBox1.Controls.Add(this.rdbCuba);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBebida);
            this.groupBox1.Location = new System.Drawing.Point(31, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // cmbBebida
            // 
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Location = new System.Drawing.Point(34, 63);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(158, 24);
            this.cmbBebida.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona una bebida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preparación";
            // 
            // rdbCuba
            // 
            this.rdbCuba.AutoSize = true;
            this.rdbCuba.Location = new System.Drawing.Point(289, 64);
            this.rdbCuba.Name = "rdbCuba";
            this.rdbCuba.Size = new System.Drawing.Size(62, 21);
            this.rdbCuba.TabIndex = 3;
            this.rdbCuba.TabStop = true;
            this.rdbCuba.Text = "Cuba";
            this.rdbCuba.UseVisualStyleBackColor = true;
            // 
            // rdbSoloHielo
            // 
            this.rdbSoloHielo.AutoSize = true;
            this.rdbSoloHielo.Location = new System.Drawing.Point(289, 92);
            this.rdbSoloHielo.Name = "rdbSoloHielo";
            this.rdbSoloHielo.Size = new System.Drawing.Size(91, 21);
            this.rdbSoloHielo.TabIndex = 4;
            this.rdbSoloHielo.TabStop = true;
            this.rdbSoloHielo.Text = "Solo hielo";
            this.rdbSoloHielo.UseVisualStyleBackColor = true;
            // 
            // rdbShot
            // 
            this.rdbShot.AutoSize = true;
            this.rdbShot.Location = new System.Drawing.Point(289, 120);
            this.rdbShot.Name = "rdbShot";
            this.rdbShot.Size = new System.Drawing.Size(58, 21);
            this.rdbShot.TabIndex = 5;
            this.rdbShot.TabStop = true;
            this.rdbShot.Text = "Shot";
            this.rdbShot.UseVisualStyleBackColor = true;
            // 
            // rdbPersonalizado
            // 
            this.rdbPersonalizado.AutoSize = true;
            this.rdbPersonalizado.Location = new System.Drawing.Point(289, 148);
            this.rdbPersonalizado.Name = "rdbPersonalizado";
            this.rdbPersonalizado.Size = new System.Drawing.Size(119, 21);
            this.rdbPersonalizado.TabIndex = 6;
            this.rdbPersonalizado.TabStop = true;
            this.rdbPersonalizado.Text = "Personalizado";
            this.rdbPersonalizado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPorcion);
            this.groupBox2.Controls.Add(this.txtbHielos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbAguaMineral);
            this.groupBox2.Controls.Add(this.txtbRefresco);
            this.groupBox2.Controls.Add(this.txtbAlcohol);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(498, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[Añade una bebida]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Porción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alcohol";
            // 
            // txtbAlcohol
            // 
            this.txtbAlcohol.Enabled = false;
            this.txtbAlcohol.Location = new System.Drawing.Point(190, 80);
            this.txtbAlcohol.Name = "txtbAlcohol";
            this.txtbAlcohol.Size = new System.Drawing.Size(100, 22);
            this.txtbAlcohol.TabIndex = 1;
            // 
            // txtbRefresco
            // 
            this.txtbRefresco.Enabled = false;
            this.txtbRefresco.Location = new System.Drawing.Point(190, 108);
            this.txtbRefresco.Name = "txtbRefresco";
            this.txtbRefresco.Size = new System.Drawing.Size(100, 22);
            this.txtbRefresco.TabIndex = 2;
            // 
            // txtbAguaMineral
            // 
            this.txtbAguaMineral.Enabled = false;
            this.txtbAguaMineral.Location = new System.Drawing.Point(190, 136);
            this.txtbAguaMineral.Name = "txtbAguaMineral";
            this.txtbAguaMineral.Size = new System.Drawing.Size(100, 22);
            this.txtbAguaMineral.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Refresco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agua Mineral";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hielos";
            // 
            // txtbHielos
            // 
            this.txtbHielos.Enabled = false;
            this.txtbHielos.Location = new System.Drawing.Point(190, 164);
            this.txtbHielos.Name = "txtbHielos";
            this.txtbHielos.Size = new System.Drawing.Size(100, 22);
            this.txtbHielos.TabIndex = 2;
            // 
            // cmbPorcion
            // 
            this.cmbPorcion.FormattingEnabled = true;
            this.cmbPorcion.Location = new System.Drawing.Point(121, 40);
            this.cmbPorcion.Name = "cmbPorcion";
            this.cmbPorcion.Size = new System.Drawing.Size(169, 24);
            this.cmbPorcion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPersonalizado;
        private System.Windows.Forms.RadioButton rdbShot;
        private System.Windows.Forms.RadioButton rdbSoloHielo;
        private System.Windows.Forms.RadioButton rdbCuba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbAguaMineral;
        private System.Windows.Forms.TextBox txtbRefresco;
        private System.Windows.Forms.TextBox txtbAlcohol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPorcion;
        private System.Windows.Forms.TextBox txtbHielos;
        private System.Windows.Forms.Label label7;
    }
}

