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
            this.label_usuario = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btn_vercatalogo = new System.Windows.Forms.Button();
            this.btn_crearkit = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(5, 854);
            this.label_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(85, 20);
            this.label_usuario.TabIndex = 3;
            this.label_usuario.Text = "Empresa:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(88, 854);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(167, 20);
            this.lblEmpresa.TabIndex = 6;
            this.lblEmpresa.Text = "nombre de la empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 854);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(416, 854);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(105, 20);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "datos usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // btn_vercatalogo
            // 
            this.btn_vercatalogo.Location = new System.Drawing.Point(507, 185);
            this.btn_vercatalogo.Name = "btn_vercatalogo";
            this.btn_vercatalogo.Size = new System.Drawing.Size(351, 135);
            this.btn_vercatalogo.TabIndex = 10;
            this.btn_vercatalogo.Text = "Consulta nuestro cátalogo";
            this.btn_vercatalogo.UseVisualStyleBackColor = true;
            this.btn_vercatalogo.Click += new System.EventHandler(this.btn_vercatalogo_Click_1);
            // 
            // btn_crearkit
            // 
            this.btn_crearkit.Location = new System.Drawing.Point(507, 326);
            this.btn_crearkit.Name = "btn_crearkit";
            this.btn_crearkit.Size = new System.Drawing.Size(351, 136);
            this.btn_crearkit.TabIndex = 12;
            this.btn_crearkit.Text = "Crea tu propio kit";
            this.btn_crearkit.UseVisualStyleBackColor = true;
            this.btn_crearkit.Click += new System.EventHandler(this.btn_crearkit_Click_1);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(1021, 770);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(123, 45);
            this.btncerrarsesion.TabIndex = 13;
            this.btncerrarsesion.Text = "Cerrar sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 840);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btn_crearkit);
            this.Controls.Add(this.btn_vercatalogo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.label_usuario);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btn_vercatalogo;
        private System.Windows.Forms.Button btn_crearkit;
        private System.Windows.Forms.Button btncerrarsesion;
    }
}