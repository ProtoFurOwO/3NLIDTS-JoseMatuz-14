namespace _3N_LIDTS_JoseMatuz
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
            this.lblimitetitle = new System.Windows.Forms.Label();
            this.lbConection = new System.Windows.Forms.Label();
            this.lbtemparriba = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.tbLimTemp = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblimitetitle
            // 
            this.lblimitetitle.AutoSize = true;
            this.lblimitetitle.Location = new System.Drawing.Point(140, 79);
            this.lblimitetitle.Name = "lblimitetitle";
            this.lblimitetitle.Size = new System.Drawing.Size(145, 16);
            this.lblimitetitle.TabIndex = 0;
            this.lblimitetitle.Text = "Limite de Temperatura:";
            // 
            // lbConection
            // 
            this.lbConection.AutoSize = true;
            this.lbConection.Font = new System.Drawing.Font("MS Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConection.ForeColor = System.Drawing.Color.Blue;
            this.lbConection.Location = new System.Drawing.Point(130, 159);
            this.lbConection.Name = "lbConection";
            this.lbConection.Size = new System.Drawing.Size(166, 23);
            this.lbConection.TabIndex = 1;
            this.lbConection.Text = "Sin Conexion";
            // 
            // lbtemparriba
            // 
            this.lbtemparriba.AutoSize = true;
            this.lbtemparriba.Location = new System.Drawing.Point(445, 79);
            this.lbtemparriba.Name = "lbtemparriba";
            this.lbtemparriba.Size = new System.Drawing.Size(85, 16);
            this.lbtemparriba.TabIndex = 2;
            this.lbtemparriba.Text = "Temperatura";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.Location = new System.Drawing.Point(448, 137);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(80, 44);
            this.lbTemp.TabIndex = 3;
            this.lbTemp.Text = "00.0";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.ForeColor = System.Drawing.Color.Red;
            this.btnDesconectar.Location = new System.Drawing.Point(448, 223);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(108, 48);
            this.btnDesconectar.TabIndex = 4;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            this.btnConectar.ForeColor = System.Drawing.Color.Lime;
            this.btnConectar.Location = new System.Drawing.Point(190, 223);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(108, 48);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // tbLimTemp
            // 
            this.tbLimTemp.Location = new System.Drawing.Point(165, 119);
            this.tbLimTemp.Name = "tbLimTemp";
            this.tbLimTemp.Size = new System.Drawing.Size(100, 22);
            this.tbLimTemp.TabIndex = 6;
            // 
            // btnguardar
            // 
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguardar.Location = new System.Drawing.Point(314, 223);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(108, 48);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar a base";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 295);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tbLimTemp);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbtemparriba);
            this.Controls.Add(this.lbConection);
            this.Controls.Add(this.lblimitetitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblimitetitle;
        private System.Windows.Forms.Label lbConection;
        private System.Windows.Forms.Label lbtemparriba;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox tbLimTemp;
        private System.Windows.Forms.Button btnguardar;
    }
}

