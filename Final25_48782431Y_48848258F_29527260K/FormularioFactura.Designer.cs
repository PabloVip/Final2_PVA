namespace Final25_48782431Y_48848258F_29527260K
{
    partial class FormularioFactura
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
            this.richTextBoxFactura = new System.Windows.Forms.RichTextBox();
            this.labelfactura = new System.Windows.Forms.Label();
            this.btnvolverfactura = new System.Windows.Forms.Button();
            this.btnPasarAExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxFactura
            // 
            this.richTextBoxFactura.Location = new System.Drawing.Point(35, 88);
            this.richTextBoxFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxFactura.Name = "richTextBoxFactura";
            this.richTextBoxFactura.ReadOnly = true;
            this.richTextBoxFactura.Size = new System.Drawing.Size(1056, 652);
            this.richTextBoxFactura.TabIndex = 0;
            this.richTextBoxFactura.Text = "";
            // 
            // labelfactura
            // 
            this.labelfactura.AutoSize = true;
            this.labelfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfactura.Location = new System.Drawing.Point(28, 48);
            this.labelfactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfactura.Name = "labelfactura";
            this.labelfactura.Size = new System.Drawing.Size(176, 37);
            this.labelfactura.TabIndex = 1;
            this.labelfactura.Text = "FACTURA";
            // 
            // btnvolverfactura
            // 
            this.btnvolverfactura.Location = new System.Drawing.Point(788, 748);
            this.btnvolverfactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvolverfactura.Name = "btnvolverfactura";
            this.btnvolverfactura.Size = new System.Drawing.Size(148, 72);
            this.btnvolverfactura.TabIndex = 2;
            this.btnvolverfactura.Text = "Volver";
            this.btnvolverfactura.UseVisualStyleBackColor = true;
            this.btnvolverfactura.Click += new System.EventHandler(this.btnvolverfactura_Click);
            // 
            // btnPasarAExcel
            // 
            this.btnPasarAExcel.Location = new System.Drawing.Point(35, 748);
            this.btnPasarAExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasarAExcel.Name = "btnPasarAExcel";
            this.btnPasarAExcel.Size = new System.Drawing.Size(240, 71);
            this.btnPasarAExcel.TabIndex = 3;
            this.btnPasarAExcel.Text = "Pasar factura a excel";
            this.btnPasarAExcel.UseVisualStyleBackColor = true;
            this.btnPasarAExcel.Click += new System.EventHandler(this.btnPasarAExcel_Click);
            // 
            // FormularioFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 929);
            this.Controls.Add(this.btnPasarAExcel);
            this.Controls.Add(this.btnvolverfactura);
            this.Controls.Add(this.labelfactura);
            this.Controls.Add(this.richTextBoxFactura);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioFactura";
            this.Load += new System.EventHandler(this.FormularioFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFactura;
        private System.Windows.Forms.Label labelfactura;
        private System.Windows.Forms.Button btnvolverfactura;
        private System.Windows.Forms.Button btnPasarAExcel;
    }
}