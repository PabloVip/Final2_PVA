namespace Final25_48782431Y_48848258F_29527260K
{
    partial class FormPrincipal
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
            this.btnvercatalogo = new System.Windows.Forms.Button();
            this.btncrearkit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvercatalogo
            // 
            this.btnvercatalogo.Location = new System.Drawing.Point(404, 186);
            this.btnvercatalogo.Name = "btnvercatalogo";
            this.btnvercatalogo.Size = new System.Drawing.Size(307, 102);
            this.btnvercatalogo.TabIndex = 0;
            this.btnvercatalogo.Text = "Consulta nuestro catalogo";
            this.btnvercatalogo.UseVisualStyleBackColor = true;
            // 
            // btncrearkit
            // 
            this.btncrearkit.Location = new System.Drawing.Point(404, 355);
            this.btncrearkit.Name = "btncrearkit";
            this.btncrearkit.Size = new System.Drawing.Size(307, 97);
            this.btncrearkit.TabIndex = 1;
            this.btncrearkit.Text = "Crea tu propio kit";
            this.btncrearkit.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 883);
            this.Controls.Add(this.btncrearkit);
            this.Controls.Add(this.btnvercatalogo);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvercatalogo;
        private System.Windows.Forms.Button btncrearkit;
    }
}