
namespace WindowsFormsApp1
{
    partial class frmLogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(109, 184);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(123, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(109, 210);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(123, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(56, 187);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(56, 210);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(174, 245);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(76, 245);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Name = "frmLogin";
            this.Text = "Tela de login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

