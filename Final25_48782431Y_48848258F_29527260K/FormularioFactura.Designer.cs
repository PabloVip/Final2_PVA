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
            this.SuspendLayout();
            // 
            // richTextBoxFactura
            // 
            this.richTextBoxFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFactura.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxFactura.Name = "richTextBoxFactura";
            this.richTextBoxFactura.ReadOnly = true;
            this.richTextBoxFactura.Size = new System.Drawing.Size(939, 513);
            this.richTextBoxFactura.TabIndex = 0;
            this.richTextBoxFactura.Text = "";
            // 
            // FormularioFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 513);
            this.Controls.Add(this.richTextBoxFactura);
            this.Name = "FormularioFactura";
            this.Text = "FormularioFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFactura;
    }
}