
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
            this.lstUsd = new System.Windows.Forms.ListView();
            this.lstHoras = new System.Windows.Forms.ListView();
            this.lstBrl = new System.Windows.Forms.ListView();
            this.lstData = new System.Windows.Forms.ListView();
            this.lstCep = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(181, 356);
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
            this.lblCep.Location = new System.Drawing.Point(116, 315);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(165, 312);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 11;
            // 
            // btnUsd
            // 
            this.btnUsd.Location = new System.Drawing.Point(357, 154);
            this.btnUsd.Name = "btnUsd";
            this.btnUsd.Size = new System.Drawing.Size(75, 23);
            this.btnUsd.TabIndex = 10;
            this.btnUsd.Text = "BRL - USD";
            this.btnUsd.UseVisualStyleBackColor = true;
            this.btnUsd.Click += new System.EventHandler(this.btnUsd_Click);
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(357, 12);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(75, 36);
            this.btnDia.TabIndex = 9;
            this.btnDia.Text = "Que Dia é Hoje?";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnUsdb
            // 
            this.btnUsdb.Location = new System.Drawing.Point(12, 154);
            this.btnUsdb.Name = "btnUsdb";
            this.btnUsdb.Size = new System.Drawing.Size(75, 23);
            this.btnUsdb.TabIndex = 8;
            this.btnUsdb.Text = "USD - BRL";
            this.btnUsdb.UseVisualStyleBackColor = true;
            this.btnUsdb.Click += new System.EventHandler(this.btnUsdb_Click);
            // 
            // btnHoras
            // 
            this.btnHoras.Location = new System.Drawing.Point(13, 12);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(75, 58);
            this.btnHoras.TabIndex = 7;
            this.btnHoras.Text = "Que Horas São?";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // lstUsd
            // 
            this.lstUsd.HideSelection = false;
            this.lstUsd.Location = new System.Drawing.Point(93, 152);
            this.lstUsd.Name = "lstUsd";
            this.lstUsd.Size = new System.Drawing.Size(121, 111);
            this.lstUsd.TabIndex = 20;
            this.lstUsd.UseCompatibleStateImageBehavior = false;
            // 
            // lstHoras
            // 
            this.lstHoras.HideSelection = false;
            this.lstHoras.Location = new System.Drawing.Point(94, 12);
            this.lstHoras.Name = "lstHoras";
            this.lstHoras.Size = new System.Drawing.Size(121, 111);
            this.lstHoras.TabIndex = 21;
            this.lstHoras.UseCompatibleStateImageBehavior = false;
            // 
            // lstBrl
            // 
            this.lstBrl.HideSelection = false;
            this.lstBrl.Location = new System.Drawing.Point(230, 152);
            this.lstBrl.Name = "lstBrl";
            this.lstBrl.Size = new System.Drawing.Size(121, 111);
            this.lstBrl.TabIndex = 22;
            this.lstBrl.UseCompatibleStateImageBehavior = false;
            // 
            // lstData
            // 
            this.lstData.HideSelection = false;
            this.lstData.Location = new System.Drawing.Point(230, 12);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(121, 111);
            this.lstData.TabIndex = 23;
            this.lstData.UseCompatibleStateImageBehavior = false;
            // 
            // lstCep
            // 
            this.lstCep.HideSelection = false;
            this.lstCep.Location = new System.Drawing.Point(283, 312);
            this.lstCep.Name = "lstCep";
            this.lstCep.Size = new System.Drawing.Size(121, 111);
            this.lstCep.TabIndex = 24;
            this.lstCep.UseCompatibleStateImageBehavior = false;
            this.lstCep.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.lstCep);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.lstBrl);
            this.Controls.Add(this.lstHoras);
            this.Controls.Add(this.lstUsd);
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
        private System.Windows.Forms.ListView lstUsd;
        private System.Windows.Forms.ListView lstHoras;
        private System.Windows.Forms.ListView lstBrl;
        private System.Windows.Forms.ListView lstData;
        private System.Windows.Forms.ListView lstCep;
    }
}