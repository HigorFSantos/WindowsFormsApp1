
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnUsd = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnUsdb = new System.Windows.Forms.Button();
            this.btnHoras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(124, 317);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(76, 276);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(113, 273);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 11;
            // 
            // btnUsd
            // 
            this.btnUsd.Location = new System.Drawing.Point(194, 186);
            this.btnUsd.Name = "btnUsd";
            this.btnUsd.Size = new System.Drawing.Size(75, 23);
            this.btnUsd.TabIndex = 10;
            this.btnUsd.Text = "BRL - USD";
            this.btnUsd.UseVisualStyleBackColor = true;
            this.btnUsd.Click += new System.EventHandler(this.btnUsd_Click);
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(194, 110);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(75, 36);
            this.btnDia.TabIndex = 9;
            this.btnDia.Text = "Que Dia é Hoje?";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnUsdb
            // 
            this.btnUsdb.Location = new System.Drawing.Point(69, 186);
            this.btnUsdb.Name = "btnUsdb";
            this.btnUsdb.Size = new System.Drawing.Size(75, 23);
            this.btnUsdb.TabIndex = 8;
            this.btnUsdb.Text = "USD - BRL";
            this.btnUsdb.UseVisualStyleBackColor = true;
            this.btnUsdb.Click += new System.EventHandler(this.btnUsdb_Click);
            // 
            // btnHoras
            // 
            this.btnHoras.Location = new System.Drawing.Point(69, 110);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(75, 36);
            this.btnHoras.TabIndex = 7;
            this.btnHoras.Text = "Que Horas São?";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnUsd);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.btnUsdb);
            this.Controls.Add(this.btnHoras);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnUsd;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnUsdb;
        private System.Windows.Forms.Button btnHoras;
    }
}