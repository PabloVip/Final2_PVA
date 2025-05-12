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
            this.btn_vercatalogo = new System.Windows.Forms.Button();
            this.btn_crearkit = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_vercatalogo
            // 
            this.btn_vercatalogo.Location = new System.Drawing.Point(539, 310);
            this.btn_vercatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_vercatalogo.Name = "btn_vercatalogo";
            this.btn_vercatalogo.Size = new System.Drawing.Size(411, 128);
            this.btn_vercatalogo.TabIndex = 0;
            this.btn_vercatalogo.Text = "Consulta nuestro cátalogo";
            this.btn_vercatalogo.UseVisualStyleBackColor = true;
            this.btn_vercatalogo.Click += new System.EventHandler(this.btn_vercatalogo_Click);
            // 
            // btn_crearkit
            // 
            this.btn_crearkit.Location = new System.Drawing.Point(539, 490);
            this.btn_crearkit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_crearkit.Name = "btn_crearkit";
            this.btn_crearkit.Size = new System.Drawing.Size(411, 121);
            this.btn_crearkit.TabIndex = 1;
            this.btn_crearkit.Text = "Crea tu propio kit";
            this.btn_crearkit.UseVisualStyleBackColor = true;
            this.btn_crearkit.Click += new System.EventHandler(this.btn_crearkit_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(1344, 964);
            this.btncerrarsesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(163, 78);
            this.btncerrarsesion.TabIndex = 2;
            this.btncerrarsesion.Text = "Cerrar sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 1104);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btn_crearkit);
            this.Controls.Add(this.btn_vercatalogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vercatalogo;
        private System.Windows.Forms.Button btn_crearkit;
        private System.Windows.Forms.Button btncerrarsesion;
    }
}