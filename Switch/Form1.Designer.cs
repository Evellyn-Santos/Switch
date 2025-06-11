namespace Switch
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númerosAleatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringToolStripMenuItem,
            this.númerosToolStripMenuItem,
            this.númerosAleatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.AutoSize = false;
            this.stringToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(250, 41);
            this.stringToolStripMenuItem.Text = "String";
            this.stringToolStripMenuItem.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // númerosToolStripMenuItem
            // 
            this.númerosToolStripMenuItem.AutoSize = false;
            this.númerosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.númerosToolStripMenuItem.Name = "númerosToolStripMenuItem";
            this.númerosToolStripMenuItem.Size = new System.Drawing.Size(250, 41);
            this.númerosToolStripMenuItem.Text = "Números";
            this.númerosToolStripMenuItem.Click += new System.EventHandler(this.númerosToolStripMenuItem_Click);
            // 
            // númerosAleatóriosToolStripMenuItem
            // 
            this.númerosAleatóriosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.númerosAleatóriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.númerosAleatóriosToolStripMenuItem.Name = "númerosAleatóriosToolStripMenuItem";
            this.númerosAleatóriosToolStripMenuItem.Size = new System.Drawing.Size(286, 41);
            this.númerosAleatóriosToolStripMenuItem.Text = "Números Aleatórios";
            this.númerosAleatóriosToolStripMenuItem.Click += new System.EventHandler(this.númerosAleatóriosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch_Evellyn Maria_2°DSB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númerosAleatóriosToolStripMenuItem;
    }
}

