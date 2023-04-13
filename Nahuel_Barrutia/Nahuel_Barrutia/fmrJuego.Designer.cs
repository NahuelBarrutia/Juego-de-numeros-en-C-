namespace Nahuel_Barrutia
{
    partial class fmrJuego
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
            this.btnExit = new System.Windows.Forms.Button();
            this.gbJuego = new System.Windows.Forms.GroupBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.btnTipo = new System.Windows.Forms.Button();
            this.rbAyuda = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbJuego.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(149, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbJuego
            // 
            this.gbJuego.Controls.Add(this.btnProbar);
            this.gbJuego.Controls.Add(this.lblNumero);
            this.gbJuego.Controls.Add(this.txtNumero);
            this.gbJuego.Enabled = false;
            this.gbJuego.Location = new System.Drawing.Point(83, 187);
            this.gbJuego.Name = "gbJuego";
            this.gbJuego.Size = new System.Drawing.Size(206, 166);
            this.gbJuego.TabIndex = 4;
            this.gbJuego.TabStop = false;
            this.gbJuego.Text = "Juego";
            // 
            // btnProbar
            // 
            this.btnProbar.Location = new System.Drawing.Point(64, 123);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(75, 23);
            this.btnProbar.TabIndex = 2;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 78);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(55, 75);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(341, 269);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(0, 13);
            this.lblIntentos.TabIndex = 4;
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(341, 238);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(0, 13);
            this.lblCreditos.TabIndex = 3;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.btnTipo);
            this.gbTipo.Controls.Add(this.rbAyuda);
            this.gbTipo.Controls.Add(this.rbNormal);
            this.gbTipo.Location = new System.Drawing.Point(125, 22);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(103, 150);
            this.gbTipo.TabIndex = 3;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de Juego";
            // 
            // btnTipo
            // 
            this.btnTipo.Location = new System.Drawing.Point(13, 121);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(70, 23);
            this.btnTipo.TabIndex = 2;
            this.btnTipo.Text = "Jugar";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // rbAyuda
            // 
            this.rbAyuda.AutoSize = true;
            this.rbAyuda.Location = new System.Drawing.Point(6, 84);
            this.rbAyuda.Name = "rbAyuda";
            this.rbAyuda.Size = new System.Drawing.Size(77, 17);
            this.rbAyuda.TabIndex = 1;
            this.rbAyuda.TabStop = true;
            this.rbAyuda.Text = "Con Ayuda";
            this.rbAyuda.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(6, 32);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Intentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Creditos";
            // 
            // fmrJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbJuego);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.lblCreditos);
            this.Name = "fmrJuego";
            this.Text = "fmrJuego";
            this.gbJuego.ResumeLayout(false);
            this.gbJuego.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbJuego;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbAyuda;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}