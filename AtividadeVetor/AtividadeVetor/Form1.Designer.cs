namespace AtividadeVetor
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem,
            this.tsmiSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1,
            this.tsm2,
            this.tsmi3});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // tsmi1
            // 
            this.tsmi1.Name = "tsmi1";
            this.tsmi1.Size = new System.Drawing.Size(180, 22);
            this.tsmi1.Text = "1";
            this.tsmi1.Click += new System.EventHandler(this.tsmi1_Click);
            // 
            // tsm2
            // 
            this.tsm2.Name = "tsm2";
            this.tsm2.Size = new System.Drawing.Size(180, 22);
            this.tsm2.Text = "2";
            this.tsm2.Click += new System.EventHandler(this.tsm2_Click);
            // 
            // tsmi3
            // 
            this.tsmi3.Name = "tsmi3";
            this.tsmi3.Size = new System.Drawing.Size(180, 22);
            this.tsmi3.Text = "3";
            this.tsmi3.Click += new System.EventHandler(this.tsmi3_Click);
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi1;
        private System.Windows.Forms.ToolStripMenuItem tsm2;
        private System.Windows.Forms.ToolStripMenuItem tsmi3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
    }
}

