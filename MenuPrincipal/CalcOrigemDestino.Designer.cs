namespace MenuPrincipal
{
    partial class CalcOrigemDestino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcOrigemDestino));
            this.lblDataHoje = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataFabricacao = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblQtdeAnos = new System.Windows.Forms.Label();
            this.lblDestinoAposentadoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataHoje
            // 
            this.lblDataHoje.AutoSize = true;
            this.lblDataHoje.Font = new System.Drawing.Font("Javanese Text", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHoje.Location = new System.Drawing.Point(38, 26);
            this.lblDataHoje.Name = "lblDataHoje";
            this.lblDataHoje.Size = new System.Drawing.Size(132, 52);
            this.lblDataHoje.TabIndex = 0;
            this.lblDataHoje.Text = "Data Curta";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(44, 112);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(381, 142);
            this.txtDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição da Aeronave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de Fabricação";
            // 
            // dtpDataFabricacao
            // 
            this.dtpDataFabricacao.Location = new System.Drawing.Point(47, 297);
            this.dtpDataFabricacao.Name = "dtpDataFabricacao";
            this.dtpDataFabricacao.Size = new System.Drawing.Size(378, 20);
            this.dtpDataFabricacao.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Verificar Destino";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQtdeAnos
            // 
            this.lblQtdeAnos.AutoSize = true;
            this.lblQtdeAnos.Location = new System.Drawing.Point(59, 406);
            this.lblQtdeAnos.Name = "lblQtdeAnos";
            this.lblQtdeAnos.Size = new System.Drawing.Size(35, 13);
            this.lblQtdeAnos.TabIndex = 6;
            this.lblQtdeAnos.Text = "label3";
            // 
            // lblDestinoAposentadoria
            // 
            this.lblDestinoAposentadoria.AutoSize = true;
            this.lblDestinoAposentadoria.Location = new System.Drawing.Point(59, 458);
            this.lblDestinoAposentadoria.Name = "lblDestinoAposentadoria";
            this.lblDestinoAposentadoria.Size = new System.Drawing.Size(35, 13);
            this.lblDestinoAposentadoria.TabIndex = 7;
            this.lblDestinoAposentadoria.Text = "label3";
            // 
            // CalcOrigemDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 535);
            this.Controls.Add(this.lblDestinoAposentadoria);
            this.Controls.Add(this.lblQtdeAnos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDataFabricacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDataHoje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcOrigemDestino";
            this.Text = "CalcOrigemDestino";
            this.Load += new System.EventHandler(this.CalcOrigemDestino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataHoje;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataFabricacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblQtdeAnos;
        private System.Windows.Forms.Label lblDestinoAposentadoria;
    }
}