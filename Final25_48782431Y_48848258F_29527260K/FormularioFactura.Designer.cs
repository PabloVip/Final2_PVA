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
            this.SuspendLayout();
            // 
            // richTextBoxFactura
            // 
            this.richTextBoxFactura.Location = new System.Drawing.Point(26, 70);
            this.richTextBoxFactura.Name = "richTextBoxFactura";
            this.richTextBoxFactura.ReadOnly = true;
            this.richTextBoxFactura.Size = new System.Drawing.Size(793, 522);
            this.richTextBoxFactura.TabIndex = 0;
            this.richTextBoxFactura.Text = "";
            // 
            // labelfactura
            // 
            this.labelfactura.AutoSize = true;
            this.labelfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfactura.Location = new System.Drawing.Point(21, 38);
            this.labelfactura.Name = "labelfactura";
            this.labelfactura.Size = new System.Drawing.Size(132, 29);
            this.labelfactura.TabIndex = 1;
            this.labelfactura.Text = "FACTURA";
            // 
            // btnvolverfactura
            // 
            this.btnvolverfactura.Location = new System.Drawing.Point(591, 598);
            this.btnvolverfactura.Name = "btnvolverfactura";
            this.btnvolverfactura.Size = new System.Drawing.Size(111, 58);
            this.btnvolverfactura.TabIndex = 2;
            this.btnvolverfactura.Text = "Volver";
            this.btnvolverfactura.UseVisualStyleBackColor = true;
            // 
            // FormularioFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 743);
            this.Controls.Add(this.btnvolverfactura);
            this.Controls.Add(this.labelfactura);
            this.Controls.Add(this.richTextBoxFactura);
            this.Name = "FormularioFactura";
            this.Text = "FormularioFactura";
            this.Load += new System.EventHandler(this.FormularioFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFactura;
        private System.Windows.Forms.Label labelfactura;
        private System.Windows.Forms.Button btnvolverfactura;
    }
}