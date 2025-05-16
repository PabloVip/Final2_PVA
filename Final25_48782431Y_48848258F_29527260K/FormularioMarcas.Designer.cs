namespace Final25_48782431Y_48848258F_29527260K
{
    partial class FormularioMarcas
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
            this.lvMarcas = new System.Windows.Forms.ListView();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripción = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvMarcas
            // 
            this.lvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMarcas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Descripción});
            this.lvMarcas.FullRowSelect = true;
            this.lvMarcas.HideSelection = false;
            this.lvMarcas.Location = new System.Drawing.Point(12, 59);
            this.lvMarcas.Name = "lvMarcas";
            this.lvMarcas.Size = new System.Drawing.Size(1189, 562);
            this.lvMarcas.TabIndex = 0;
            this.lvMarcas.UseCompatibleStateImageBehavior = false;
            this.lvMarcas.View = System.Windows.Forms.View.Details;
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(12, 12);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(89, 41);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "Nuevo";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(198, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 41);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(107, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 41);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(1110, 627);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 36);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 200;
            // 
            // Descripción
            // 
            this.Descripción.Text = "Descripción";
            this.Descripción.Width = 550;
            // 
            // FormularioMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 675);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.lvMarcas);
            this.Name = "FormularioMarcas";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.FormularioMarcas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMarcas;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Descripción;
    }
}