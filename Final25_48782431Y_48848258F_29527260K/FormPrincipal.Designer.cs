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
            this.label_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_vercatalogo
            // 
            this.btn_vercatalogo.Location = new System.Drawing.Point(270, 161);
            this.btn_vercatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_vercatalogo.Name = "btn_vercatalogo";
            this.btn_vercatalogo.Size = new System.Drawing.Size(206, 67);
            this.btn_vercatalogo.TabIndex = 0;
            this.btn_vercatalogo.Text = "Consulta nuestro cátalogo";
            this.btn_vercatalogo.UseVisualStyleBackColor = true;
            this.btn_vercatalogo.Click += new System.EventHandler(this.btn_vercatalogo_Click);
            // 
            // btn_crearkit
            // 
            this.btn_crearkit.Location = new System.Drawing.Point(270, 255);
            this.btn_crearkit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_crearkit.Name = "btn_crearkit";
            this.btn_crearkit.Size = new System.Drawing.Size(206, 63);
            this.btn_crearkit.TabIndex = 1;
            this.btn_crearkit.Text = "Crea tu propio kit";
            this.btn_crearkit.UseVisualStyleBackColor = true;
            this.btn_crearkit.Click += new System.EventHandler(this.btn_crearkit_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(672, 501);
            this.btncerrarsesion.Margin = new System.Windows.Forms.Padding(2);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(82, 41);
            this.btncerrarsesion.TabIndex = 2;
            this.btncerrarsesion.Text = "Cerrar sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(13, 13);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(35, 13);
            this.label_usuario.TabIndex = 3;
            this.label_usuario.Text = "label1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(778, 574);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btn_crearkit);
            this.Controls.Add(this.btn_vercatalogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vercatalogo;
        private System.Windows.Forms.Button btn_crearkit;
        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.Label label_usuario;
    }
}