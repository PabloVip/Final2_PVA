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
            this.label_usuario.Location = new System.Drawing.Point(10, 298);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(76, 17);
            this.label_usuario.TabIndex = 3;
            this.label_usuario.Text = "Empresa:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(65, 298);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(132, 15);
            this.lblEmpresa.TabIndex = 6;
            this.lblEmpresa.Text = "nombre de la empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(284, 298);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 15);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "datos usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // btn_vercatalogo
            // 
            this.btn_vercatalogo.Location = new System.Drawing.Point(189, 79);
            this.btn_vercatalogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_vercatalogo.Name = "btn_vercatalogo";
            this.btn_vercatalogo.Size = new System.Drawing.Size(197, 55);
            this.btn_vercatalogo.TabIndex = 10;
            this.btn_vercatalogo.Text = "CATÁLOGO ";
            this.btn_vercatalogo.UseVisualStyleBackColor = true;
            this.btn_vercatalogo.Click += new System.EventHandler(this.btn_vercatalogo_Click_1);
            // 
            // btn_crearkit
            // 
            this.btn_crearkit.Location = new System.Drawing.Point(189, 138);
            this.btn_crearkit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_crearkit.Name = "btn_crearkit";
            this.btn_crearkit.Size = new System.Drawing.Size(197, 54);
            this.btn_crearkit.TabIndex = 12;
            this.btn_crearkit.Text = "PEDIDOS";
            this.btn_crearkit.UseVisualStyleBackColor = true;
            this.btn_crearkit.Click += new System.EventHandler(this.btn_crearkit_Click_1);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(471, 281);
            this.btncerrarsesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(82, 29);
            this.btncerrarsesion.TabIndex = 13;
            this.btncerrarsesion.Text = "Cerrar sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 318);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btn_crearkit);
            this.Controls.Add(this.btn_vercatalogo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.label_usuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payavi Solar";
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