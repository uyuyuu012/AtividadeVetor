namespace AtividadeVetor
{
    partial class frm1
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtMatrizB = new System.Windows.Forms.TextBox();
            this.lblMatrizA = new System.Windows.Forms.Label();
            this.txtMatrizA = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMatA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(576, 403);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 35);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(416, 403);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 35);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(253, 403);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(104, 35);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtMatrizB
            // 
            this.txtMatrizB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrizB.Location = new System.Drawing.Point(546, 61);
            this.txtMatrizB.Multiline = true;
            this.txtMatrizB.Name = "txtMatrizB";
            this.txtMatrizB.ReadOnly = true;
            this.txtMatrizB.Size = new System.Drawing.Size(217, 313);
            this.txtMatrizB.TabIndex = 3;
            // 
            // lblMatrizA
            // 
            this.lblMatrizA.AutoSize = true;
            this.lblMatrizA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrizA.Location = new System.Drawing.Point(12, 9);
            this.lblMatrizA.Name = "lblMatrizA";
            this.lblMatrizA.Size = new System.Drawing.Size(313, 20);
            this.lblMatrizA.TabIndex = 5;
            this.lblMatrizA.Text = "Digite um valor para adicionar para a matriz";
            // 
            // txtMatrizA
            // 
            this.txtMatrizA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrizA.Location = new System.Drawing.Point(340, 9);
            this.txtMatrizA.Name = "txtMatrizA";
            this.txtMatrizA.Size = new System.Drawing.Size(148, 26);
            this.txtMatrizA.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(86, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMatA
            // 
            this.txtMatA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatA.Location = new System.Drawing.Point(303, 61);
            this.txtMatA.Multiline = true;
            this.txtMatA.Name = "txtMatA";
            this.txtMatA.ReadOnly = true;
            this.txtMatA.Size = new System.Drawing.Size(217, 313);
            this.txtMatA.TabIndex = 8;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtMatA);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMatrizA);
            this.Controls.Add(this.lblMatrizA);
            this.Controls.Add(this.txtMatrizB);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtMatrizB;
        private System.Windows.Forms.Label lblMatrizA;
        private System.Windows.Forms.TextBox txtMatrizA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMatA;
    }
}