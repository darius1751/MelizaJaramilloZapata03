﻿
namespace MelizaJaramilloFernandez03
{
    partial class Maestro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCambio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCambio,
            this.btnSalario,
            this.btnSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnCambio
            // 
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(61, 20);
            this.btnCambio.Text = "Cambio";
            this.btnCambio.Click += this.menuStrip1_btnCambio_Click;
            // 
            // btnSalario
            // 
            this.btnSalario.Name = "btnSalario";
            this.btnSalario.Size = new System.Drawing.Size(54, 20);
            this.btnSalario.Text = "Salario";
            this.btnSalario.Click += new System.EventHandler(this.menuStrip1_btnSalario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 20);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.menuStrip1_btnSalir_Click);
            // 
            // Maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Maestro";
            this.Text = "Maestro";
            this.Load += new System.EventHandler(this.Maestro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCambio;
        private System.Windows.Forms.ToolStripMenuItem btnSalario;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
    }
}

