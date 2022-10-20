namespace MenuPrincipal
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aeronavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarWebAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarNoBDLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engenhariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraMODToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadora10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcCategoriaIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraOrigemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirigívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aeronavesToolStripMenuItem,
            this.engenhariaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aeronavesToolStripMenuItem
            // 
            this.aeronavesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarWebAPIToolStripMenuItem,
            this.pesquisarNoBDLocalToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.testeToolStripMenuItem,
            this.testeToolStripMenuItem1});
            this.aeronavesToolStripMenuItem.Name = "aeronavesToolStripMenuItem";
            this.aeronavesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.aeronavesToolStripMenuItem.Text = "Aeronaves";
            // 
            // pesquisarWebAPIToolStripMenuItem
            // 
            this.pesquisarWebAPIToolStripMenuItem.Name = "pesquisarWebAPIToolStripMenuItem";
            this.pesquisarWebAPIToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pesquisarWebAPIToolStripMenuItem.Text = "Pesquisar Web API";
            this.pesquisarWebAPIToolStripMenuItem.Click += new System.EventHandler(this.pesquisarWebAPIToolStripMenuItem_Click);
            // 
            // pesquisarNoBDLocalToolStripMenuItem
            // 
            this.pesquisarNoBDLocalToolStripMenuItem.Name = "pesquisarNoBDLocalToolStripMenuItem";
            this.pesquisarNoBDLocalToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pesquisarNoBDLocalToolStripMenuItem.Text = "Pesquisar no BD Local";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dirigívelToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // engenhariaToolStripMenuItem
            // 
            this.engenhariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraMODToolStripMenuItem,
            this.calculadora10ToolStripMenuItem,
            this.calcCategoriaIToolStripMenuItem,
            this.calculadoraOrigemToolStripMenuItem});
            this.engenhariaToolStripMenuItem.Name = "engenhariaToolStripMenuItem";
            this.engenhariaToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.engenhariaToolStripMenuItem.Text = "Engenharia";
            // 
            // calculadoraMODToolStripMenuItem
            // 
            this.calculadoraMODToolStripMenuItem.Name = "calculadoraMODToolStripMenuItem";
            this.calculadoraMODToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calculadoraMODToolStripMenuItem.Text = "Calculadora MOD";
            this.calculadoraMODToolStripMenuItem.Click += new System.EventHandler(this.calculadoraMODToolStripMenuItem_Click);
            // 
            // calculadora10ToolStripMenuItem
            // 
            this.calculadora10ToolStripMenuItem.Name = "calculadora10ToolStripMenuItem";
            this.calculadora10ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calculadora10ToolStripMenuItem.Text = "Calculadora 10%";
            this.calculadora10ToolStripMenuItem.Click += new System.EventHandler(this.calculadora10ToolStripMenuItem_Click);
            // 
            // calcCategoriaIToolStripMenuItem
            // 
            this.calcCategoriaIToolStripMenuItem.Name = "calcCategoriaIToolStripMenuItem";
            this.calcCategoriaIToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calcCategoriaIToolStripMenuItem.Text = "Calculadora Assentos";
            this.calcCategoriaIToolStripMenuItem.Click += new System.EventHandler(this.calcCategoriaIToolStripMenuItem_Click);
            // 
            // calculadoraOrigemToolStripMenuItem
            // 
            this.calculadoraOrigemToolStripMenuItem.Name = "calculadoraOrigemToolStripMenuItem";
            this.calculadoraOrigemToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calculadoraOrigemToolStripMenuItem.Text = "Calculadora Origem";
            this.calculadoraOrigemToolStripMenuItem.Click += new System.EventHandler(this.calculadoraOrigemToolStripMenuItem_Click);
            // 
            // dirigívelToolStripMenuItem
            // 
            this.dirigívelToolStripMenuItem.Name = "dirigívelToolStripMenuItem";
            this.dirigívelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dirigívelToolStripMenuItem.Text = "Dirigível";
            this.dirigívelToolStripMenuItem.Click += new System.EventHandler(this.dirigívelToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.testeToolStripMenuItem.Text = "Teste";
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem2});
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.testeToolStripMenuItem1.Text = "Teste";
            // 
            // testeToolStripMenuItem2
            // 
            this.testeToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem3});
            this.testeToolStripMenuItem2.Name = "testeToolStripMenuItem2";
            this.testeToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.testeToolStripMenuItem2.Text = "teste";
            // 
            // testeToolStripMenuItem3
            // 
            this.testeToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsteToolStripMenuItem});
            this.testeToolStripMenuItem3.Name = "testeToolStripMenuItem3";
            this.testeToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.testeToolStripMenuItem3.Text = "teste";
            // 
            // tsteToolStripMenuItem
            // 
            this.tsteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem4});
            this.tsteToolStripMenuItem.Name = "tsteToolStripMenuItem";
            this.tsteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tsteToolStripMenuItem.Text = "tste";
            // 
            // testeToolStripMenuItem4
            // 
            this.testeToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.testeToolStripMenuItem4.Name = "testeToolStripMenuItem4";
            this.testeToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.testeToolStripMenuItem4.Text = "teste";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sToolStripMenuItem.Text = "s";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "VOEAIRLINES CLIENT";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aeronavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarWebAPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarNoBDLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engenhariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraMODToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadora10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcCategoriaIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraOrigemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dirigívelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
    }
}

