namespace Nahuel_Barrutia
{
    partial class fmrInicio
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPartidas = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(66, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPartidas
            // 
            this.btnPartidas.Location = new System.Drawing.Point(26, 163);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(166, 61);
            this.btnPartidas.TabIndex = 4;
            this.btnPartidas.Text = "Partidas";
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.Location = new System.Drawing.Point(26, 39);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(166, 65);
            this.btnJuego.TabIndex = 3;
            this.btnJuego.Text = "Juego";
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // fmrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 359);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPartidas);
            this.Controls.Add(this.btnJuego);
            this.Name = "fmrInicio";
            this.Text = "fmrInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.Button btnJuego;
    }
}