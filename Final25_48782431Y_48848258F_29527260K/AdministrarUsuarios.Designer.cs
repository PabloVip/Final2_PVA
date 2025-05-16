namespace Final25_48782431Y_48848258F_29527260K
{
    partial class AdministrarUsuarios
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Empresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigoPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provincia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaCreacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NIF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RolId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_poblacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_provincia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_fechacreacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nif = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_rolid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_añadir = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Empresa,
            this.Nombre,
            this.Direccion,
            this.Poblacion,
            this.CodigoPostal,
            this.Provincia,
            this.Pais,
            this.Email,
            this.FechaCreacion,
            this.NIF,
            this.RolId,
            this.Password});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 75);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1800, 1008);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Empresa
            // 
            this.Empresa.Text = "Empresa";
            this.Empresa.Width = 74;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 63;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 77;
            // 
            // Poblacion
            // 
            this.Poblacion.Text = "Poblacion";
            this.Poblacion.Width = 64;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.Text = "C.P.";
            this.CodigoPostal.Width = 48;
            // 
            // Provincia
            // 
            this.Provincia.Text = "Provincia";
            this.Provincia.Width = 90;
            // 
            // Pais
            // 
            this.Pais.Text = "Pais";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.Text = "FechaCreacion";
            this.FechaCreacion.Width = 85;
            // 
            // NIF
            // 
            this.NIF.Text = "NIF";
            // 
            // RolId
            // 
            this.RolId.Text = "RolId";
            // 
            // Password
            // 
            this.Password.Text = "Password";
            // 
            // tb_empresa
            // 
            this.tb_empresa.Location = new System.Drawing.Point(1874, 125);
            this.tb_empresa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Size = new System.Drawing.Size(288, 31);
            this.tb_empresa.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1868, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Empresa";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(1874, 204);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(288, 31);
            this.tb_nombre.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1868, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // tb_poblacion
            // 
            this.tb_poblacion.Location = new System.Drawing.Point(1874, 358);
            this.tb_poblacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_poblacion.Name = "tb_poblacion";
            this.tb_poblacion.Size = new System.Drawing.Size(288, 31);
            this.tb_poblacion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1868, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Poblacion";
            // 
            // tb_CP
            // 
            this.tb_CP.Location = new System.Drawing.Point(1874, 442);
            this.tb_CP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_CP.Name = "tb_CP";
            this.tb_CP.Size = new System.Drawing.Size(288, 31);
            this.tb_CP.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1868, 410);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "C.P.";
            // 
            // tb_provincia
            // 
            this.tb_provincia.Location = new System.Drawing.Point(1874, 529);
            this.tb_provincia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_provincia.Name = "tb_provincia";
            this.tb_provincia.Size = new System.Drawing.Size(288, 31);
            this.tb_provincia.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1868, 496);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Provincia";
            // 
            // tb_pais
            // 
            this.tb_pais.Location = new System.Drawing.Point(1874, 621);
            this.tb_pais.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(288, 31);
            this.tb_pais.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1868, 588);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pais";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(1874, 708);
            this.tb_email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(288, 31);
            this.tb_email.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1868, 675);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Email";
            // 
            // tb_fechacreacion
            // 
            this.tb_fechacreacion.Location = new System.Drawing.Point(1874, 787);
            this.tb_fechacreacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_fechacreacion.Name = "tb_fechacreacion";
            this.tb_fechacreacion.Size = new System.Drawing.Size(288, 31);
            this.tb_fechacreacion.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1868, 754);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "FechaCreacion";
            // 
            // tb_nif
            // 
            this.tb_nif.Location = new System.Drawing.Point(1874, 873);
            this.tb_nif.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_nif.Name = "tb_nif";
            this.tb_nif.Size = new System.Drawing.Size(288, 31);
            this.tb_nif.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1868, 840);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "NIF";
            // 
            // tb_rolid
            // 
            this.tb_rolid.Location = new System.Drawing.Point(1874, 963);
            this.tb_rolid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_rolid.Name = "tb_rolid";
            this.tb_rolid.Size = new System.Drawing.Size(288, 31);
            this.tb_rolid.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1868, 931);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Rol ID";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(1874, 1046);
            this.tb_password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(288, 31);
            this.tb_password.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1868, 1013);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Password";
            // 
            // bt_añadir
            // 
            this.bt_añadir.Location = new System.Drawing.Point(26, 1096);
            this.bt_añadir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_añadir.Name = "bt_añadir";
            this.bt_añadir.Size = new System.Drawing.Size(236, 115);
            this.bt_añadir.TabIndex = 33;
            this.bt_añadir.Text = "Añadir";
            this.bt_añadir.UseVisualStyleBackColor = true;
            this.bt_añadir.Click += new System.EventHandler(this.bt_añadir_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(274, 1096);
            this.bt_modificar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(236, 115);
            this.bt_modificar.TabIndex = 34;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 1096);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 115);
            this.button1.TabIndex = 35;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(1874, 281);
            this.tb_direccion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(288, 31);
            this.tb_direccion.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1868, 248);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "Direccion";
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2384, 1319);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_añadir);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_rolid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_nif);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_fechacreacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_pais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_provincia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_CP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_poblacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdministrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Empresa;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader Poblacion;
        private System.Windows.Forms.ColumnHeader CodigoPostal;
        private System.Windows.Forms.ColumnHeader Provincia;
        private System.Windows.Forms.ColumnHeader Pais;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader FechaCreacion;
        private System.Windows.Forms.ColumnHeader NIF;
        private System.Windows.Forms.ColumnHeader RolId;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.TextBox tb_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_poblacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_provincia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_fechacreacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_nif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_rolid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_añadir;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.Label label13;
    }
}