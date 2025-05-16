namespace Final25_48782431Y_48848258F_29527260K
{
    partial class FormAdmin
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
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.btn_vercatalogo = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(1414, 765);
            this.btncerrarsesion.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(164, 79);
            this.btncerrarsesion.TabIndex = 3;
            this.btncerrarsesion.Text = "Cerrar sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // btn_vercatalogo
            // 
            this.btn_vercatalogo.Location = new System.Drawing.Point(576, 146);
            this.btn_vercatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vercatalogo.Name = "btn_vercatalogo";
            this.btn_vercatalogo.Size = new System.Drawing.Size(412, 129);
            this.btn_vercatalogo.TabIndex = 4;
            this.btn_vercatalogo.Text = "Administrar cátalogo";
            this.btn_vercatalogo.UseVisualStyleBackColor = true;
            this.btn_vercatalogo.Click += new System.EventHandler(this.btn_vercatalogo_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.Location = new System.Drawing.Point(576, 283);
            this.btn_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(412, 129);
            this.btn_usuario.TabIndex = 5;
            this.btn_usuario.Text = "Editar usuarios";
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 419);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(412, 129);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registro de ventas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 556);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(412, 129);
            this.button1.TabIndex = 7;
            this.button1.Text = "Editar productos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(46, 30);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(160, 61);
            this.btnMarcas.TabIndex = 10;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(240, 30);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(163, 61);
            this.btnCategorias.TabIndex = 11;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.btn_vercatalogo);
            this.Controls.Add(this.btncerrarsesion);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.Button btn_vercatalogo;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
    }
}