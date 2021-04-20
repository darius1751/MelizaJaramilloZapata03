
namespace MelizaJaramilloFernandez03
{
    partial class Cambio
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
            this.lsbxTipoMoneda = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.btnCambio = new System.Windows.Forms.Button();
            this.lsbxTipoUsuario = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtnColombiano = new System.Windows.Forms.RadioButton();
            this.rdbtnExtranjero = new System.Windows.Forms.RadioButton();
            this.pnlCambio = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtTotalEntregar = new System.Windows.Forms.TextBox();
            this.lblTotalEntregar = new System.Windows.Forms.Label();
            this.lblIvaR = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTasaCambioR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoUsuarioR = new System.Windows.Forms.TextBox();
            this.txtMonedaR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbxTipoMoneda
            // 
            this.lsbxTipoMoneda.FormattingEnabled = true;
            this.lsbxTipoMoneda.ItemHeight = 15;
            this.lsbxTipoMoneda.Items.AddRange(new object[] {
            "Dolares",
            "Euros",
            "Pesos Mexicanos",
            "Yenes"});
            this.lsbxTipoMoneda.Location = new System.Drawing.Point(105, 27);
            this.lsbxTipoMoneda.Name = "lsbxTipoMoneda";
            this.lsbxTipoMoneda.Size = new System.Drawing.Size(120, 94);
            this.lsbxTipoMoneda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Moneda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad dinero:";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(105, 149);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(191, 23);
            this.txtDinero.TabIndex = 3;
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(329, 148);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(75, 23);
            this.btnCambio.TabIndex = 4;
            this.btnCambio.Text = "Cambiar";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // lsbxTipoUsuario
            // 
            this.lsbxTipoUsuario.FormattingEnabled = true;
            this.lsbxTipoUsuario.ItemHeight = 15;
            this.lsbxTipoUsuario.Items.AddRange(new object[] {
            "Cliente Preferencial",
            "Cliente Normal",
            "No es Cliente"});
            this.lsbxTipoUsuario.Location = new System.Drawing.Point(329, 28);
            this.lsbxTipoUsuario.Name = "lsbxTipoUsuario";
            this.lsbxTipoUsuario.Size = new System.Drawing.Size(120, 94);
            this.lsbxTipoUsuario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de Usuario:";
            // 
            // rdbtnColombiano
            // 
            this.rdbtnColombiano.AutoSize = true;
            this.rdbtnColombiano.Checked = true;
            this.rdbtnColombiano.Location = new System.Drawing.Point(472, 102);
            this.rdbtnColombiano.Name = "rdbtnColombiano";
            this.rdbtnColombiano.Size = new System.Drawing.Size(91, 19);
            this.rdbtnColombiano.TabIndex = 11;
            this.rdbtnColombiano.TabStop = true;
            this.rdbtnColombiano.Text = "Colombiano";
            this.rdbtnColombiano.UseVisualStyleBackColor = true;
            // 
            // rdbtnExtranjero
            // 
            this.rdbtnExtranjero.AutoSize = true;
            this.rdbtnExtranjero.Location = new System.Drawing.Point(472, 128);
            this.rdbtnExtranjero.Name = "rdbtnExtranjero";
            this.rdbtnExtranjero.Size = new System.Drawing.Size(78, 19);
            this.rdbtnExtranjero.TabIndex = 12;
            this.rdbtnExtranjero.Text = "Extranjero";
            this.rdbtnExtranjero.UseVisualStyleBackColor = true;
            // 
            // pnlCambio
            // 
            this.pnlCambio.Controls.Add(this.label7);
            this.pnlCambio.Controls.Add(this.txtTotalPagar);
            this.pnlCambio.Controls.Add(this.txtTotalEntregar);
            this.pnlCambio.Controls.Add(this.lblTotalEntregar);
            this.pnlCambio.Controls.Add(this.lblIvaR);
            this.pnlCambio.Controls.Add(this.lblIva);
            this.pnlCambio.Controls.Add(this.lblTasaCambioR);
            this.pnlCambio.Controls.Add(this.label6);
            this.pnlCambio.Controls.Add(this.label5);
            this.pnlCambio.Controls.Add(this.txtTipoUsuarioR);
            this.pnlCambio.Controls.Add(this.txtMonedaR);
            this.pnlCambio.Controls.Add(this.label4);
            this.pnlCambio.Location = new System.Drawing.Point(3, 178);
            this.pnlCambio.Name = "pnlCambio";
            this.pnlCambio.Size = new System.Drawing.Size(796, 271);
            this.pnlCambio.TabIndex = 13;
            this.pnlCambio.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total a Pagar";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(228, 157);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(211, 23);
            this.txtTotalPagar.TabIndex = 10;
            // 
            // txtTotalEntregar
            // 
            this.txtTotalEntregar.Location = new System.Drawing.Point(396, 75);
            this.txtTotalEntregar.Name = "txtTotalEntregar";
            this.txtTotalEntregar.ReadOnly = true;
            this.txtTotalEntregar.Size = new System.Drawing.Size(133, 23);
            this.txtTotalEntregar.TabIndex = 9;
            // 
            // lblTotalEntregar
            // 
            this.lblTotalEntregar.AutoSize = true;
            this.lblTotalEntregar.Location = new System.Drawing.Point(298, 75);
            this.lblTotalEntregar.Name = "lblTotalEntregar";
            this.lblTotalEntregar.Size = new System.Drawing.Size(91, 15);
            this.lblTotalEntregar.TabIndex = 8;
            this.lblTotalEntregar.Text = "Total a Entregar:";
            // 
            // lblIvaR
            // 
            this.lblIvaR.AutoSize = true;
            this.lblIvaR.Location = new System.Drawing.Point(43, 75);
            this.lblIvaR.Name = "lblIvaR";
            this.lblIvaR.Size = new System.Drawing.Size(0, 15);
            this.lblIvaR.TabIndex = 7;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(10, 75);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 15);
            this.lblIva.TabIndex = 6;
            this.lblIva.Text = "IVA:";
            // 
            // lblTasaCambioR
            // 
            this.lblTasaCambioR.AutoSize = true;
            this.lblTasaCambioR.Location = new System.Drawing.Point(612, 25);
            this.lblTasaCambioR.Name = "lblTasaCambioR";
            this.lblTasaCambioR.Size = new System.Drawing.Size(0, 15);
            this.lblTasaCambioR.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tasa de Cambio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo de Usuario:";
            // 
            // txtTipoUsuarioR
            // 
            this.txtTipoUsuarioR.Location = new System.Drawing.Point(102, 22);
            this.txtTipoUsuarioR.Name = "txtTipoUsuarioR";
            this.txtTipoUsuarioR.ReadOnly = true;
            this.txtTipoUsuarioR.Size = new System.Drawing.Size(166, 23);
            this.txtTipoUsuarioR.TabIndex = 2;
            // 
            // txtMonedaR
            // 
            this.txtMonedaR.Location = new System.Drawing.Point(384, 25);
            this.txtMonedaR.Name = "txtMonedaR";
            this.txtMonedaR.ReadOnly = true;
            this.txtMonedaR.Size = new System.Drawing.Size(126, 23);
            this.txtMonedaR.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo moneda:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(420, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(510, 149);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlCambio);
            this.Controls.Add(this.rdbtnExtranjero);
            this.Controls.Add(this.rdbtnColombiano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbxTipoUsuario);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbxTipoMoneda);
            this.Name = "Cambio";
            this.Text = "Cambio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cambio_FormClosed);
            this.pnlCambio.ResumeLayout(false);
            this.pnlCambio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbxTipoMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.ListBox lsbxTipoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtnColombiano;
        private System.Windows.Forms.RadioButton rdbtnExtranjero;
        private System.Windows.Forms.Panel pnlCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTasaCambioR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoUsuarioR;
        private System.Windows.Forms.TextBox txtMonedaR;
        private System.Windows.Forms.Label lblIvaR;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtTotalEntregar;
        private System.Windows.Forms.Label lblTotalEntregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}