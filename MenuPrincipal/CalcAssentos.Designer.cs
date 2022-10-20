namespace MenuPrincipal
{
    partial class CalcAssentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcAssentos));
            this.lblQtdeAssentos = new System.Windows.Forms.Label();
            this.txtQtdeAssentos = new System.Windows.Forms.TextBox();
            this.btnCalcularCat = new System.Windows.Forms.Button();
            this.lblResultAssento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQtdeAssentos
            // 
            this.lblQtdeAssentos.AutoSize = true;
            this.lblQtdeAssentos.Location = new System.Drawing.Point(91, 23);
            this.lblQtdeAssentos.Name = "lblQtdeAssentos";
            this.lblQtdeAssentos.Size = new System.Drawing.Size(123, 13);
            this.lblQtdeAssentos.TabIndex = 0;
            this.lblQtdeAssentos.Text = "Quantidade de Assentos";
            // 
            // txtQtdeAssentos
            // 
            this.txtQtdeAssentos.Location = new System.Drawing.Point(94, 53);
            this.txtQtdeAssentos.Name = "txtQtdeAssentos";
            this.txtQtdeAssentos.Size = new System.Drawing.Size(333, 20);
            this.txtQtdeAssentos.TabIndex = 1;
            // 
            // btnCalcularCat
            // 
            this.btnCalcularCat.Location = new System.Drawing.Point(94, 94);
            this.btnCalcularCat.Name = "btnCalcularCat";
            this.btnCalcularCat.Size = new System.Drawing.Size(333, 23);
            this.btnCalcularCat.TabIndex = 2;
            this.btnCalcularCat.Text = "Mostrar Categoria";
            this.btnCalcularCat.UseVisualStyleBackColor = true;
            this.btnCalcularCat.Click += new System.EventHandler(this.btnCalcularCat_Click);
            // 
            // lblResultAssento
            // 
            this.lblResultAssento.AutoSize = true;
            this.lblResultAssento.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultAssento.ForeColor = System.Drawing.Color.Red;
            this.lblResultAssento.Location = new System.Drawing.Point(201, 129);
            this.lblResultAssento.Name = "lblResultAssento";
            this.lblResultAssento.Size = new System.Drawing.Size(0, 30);
            this.lblResultAssento.TabIndex = 3;
            // 
            // CalcAssentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 184);
            this.Controls.Add(this.lblResultAssento);
            this.Controls.Add(this.btnCalcularCat);
            this.Controls.Add(this.txtQtdeAssentos);
            this.Controls.Add(this.lblQtdeAssentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcAssentos";
            this.Text = "CalcAssentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtdeAssentos;
        private System.Windows.Forms.TextBox txtQtdeAssentos;
        private System.Windows.Forms.Button btnCalcularCat;
        private System.Windows.Forms.Label lblResultAssento;
    }
}