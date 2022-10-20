namespace MenuPrincipal
{
    partial class FrmAeronave
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblResultadoFabricante = new System.Windows.Forms.Label();
            this.lblResultadoModelo = new System.Windows.Forms.Label();
            this.lblResultadoCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(114, 25);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(418, 20);
            this.txtFabricante.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(114, 67);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(418, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(418, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(71, 161);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(461, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Nova Aeronave";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblResultadoFabricante
            // 
            this.lblResultadoFabricante.AutoSize = true;
            this.lblResultadoFabricante.Location = new System.Drawing.Point(69, 243);
            this.lblResultadoFabricante.Name = "lblResultadoFabricante";
            this.lblResultadoFabricante.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoFabricante.TabIndex = 7;
            this.lblResultadoFabricante.Text = "label4";
            // 
            // lblResultadoModelo
            // 
            this.lblResultadoModelo.AutoSize = true;
            this.lblResultadoModelo.Location = new System.Drawing.Point(69, 298);
            this.lblResultadoModelo.Name = "lblResultadoModelo";
            this.lblResultadoModelo.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoModelo.TabIndex = 8;
            this.lblResultadoModelo.Text = "label5";
            // 
            // lblResultadoCodigo
            // 
            this.lblResultadoCodigo.AutoSize = true;
            this.lblResultadoCodigo.Location = new System.Drawing.Point(71, 344);
            this.lblResultadoCodigo.Name = "lblResultadoCodigo";
            this.lblResultadoCodigo.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoCodigo.TabIndex = 9;
            this.lblResultadoCodigo.Text = "label6";
            // 
            // FrmAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 584);
            this.Controls.Add(this.lblResultadoCodigo);
            this.Controls.Add(this.lblResultadoModelo);
            this.Controls.Add(this.lblResultadoFabricante);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAeronave";
            this.Text = "FrmAeronave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblResultadoFabricante;
        private System.Windows.Forms.Label lblResultadoModelo;
        private System.Windows.Forms.Label lblResultadoCodigo;
    }
}