namespace Final25_48782431Y_48848258F_29527260K
{
    partial class FormularioKits
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
            this.components = new System.ComponentModel.Container();
            this.labelCatalogo = new System.Windows.Forms.Label();
            this.cbCatalogo = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pAYAVISOLARDataSet = new Final25_48782431Y_48848258F_29527260K.PAYAVISOLARDataSet();
            this.productoKitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoKitsTableAdapter = new Final25_48782431Y_48848258F_29527260K.PAYAVISOLARDataSetTableAdapters.ProductoKitsTableAdapter();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Final25_48782431Y_48848258F_29527260K.PAYAVISOLARDataSetTableAdapters.ProductosTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAñadirProducto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pAYAVISOLARDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoKitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCatalogo
            // 
            this.labelCatalogo.AutoSize = true;
            this.labelCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalogo.ForeColor = System.Drawing.Color.Coral;
            this.labelCatalogo.Location = new System.Drawing.Point(16, 11);
            this.labelCatalogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCatalogo.Name = "labelCatalogo";
            this.labelCatalogo.Size = new System.Drawing.Size(345, 37);
            this.labelCatalogo.TabIndex = 1;
            this.labelCatalogo.Text = "CATÁLOGO DE KITS";
            // 
            // cbCatalogo
            // 
            this.cbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatalogo.FormattingEnabled = true;
            this.cbCatalogo.Location = new System.Drawing.Point(15, 51);
            this.cbCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCatalogo.Name = "cbCatalogo";
            this.cbCatalogo.Size = new System.Drawing.Size(468, 33);
            this.cbCatalogo.TabIndex = 2;
            this.cbCatalogo.SelectedIndexChanged += new System.EventHandler(this.cbCatalogo_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(837, 892);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(136, 42);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pAYAVISOLARDataSet
            // 
            this.pAYAVISOLARDataSet.DataSetName = "PAYAVISOLARDataSet";
            this.pAYAVISOLARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoKitsBindingSource
            // 
            this.productoKitsBindingSource.DataMember = "ProductoKits";
            this.productoKitsBindingSource.DataSource = this.pAYAVISOLARDataSet;
            // 
            // productoKitsTableAdapter
            // 
            this.productoKitsTableAdapter.ClearBeforeFill = true;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.pAYAVISOLARDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Codigo,
            this.Descripcion,
            this.Categoria,
            this.Marca,
            this.Precio,
            this.Cantidad});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 155);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(959, 712);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 110;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 206;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 128;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 157;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 110;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 408;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(493, 51);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(136, 42);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo kit";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirProducto.Location = new System.Drawing.Point(15, 106);
            this.btnAñadirProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(192, 42);
            this.btnAñadirProducto.TabIndex = 9;
            this.btnAñadirProducto.Text = "Añadir producto";
            this.btnAñadirProducto.UseVisualStyleBackColor = true;
            this.btnAñadirProducto.Click += new System.EventHandler(this.btnAñadirProducto_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(637, 51);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 42);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(215, 106);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(192, 42);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // FormularioKits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(995, 949);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadirProducto);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbCatalogo);
            this.Controls.Add(this.labelCatalogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioKits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kits";
            ((System.ComponentModel.ISupportInitialize)(this.pAYAVISOLARDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoKitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCatalogo;
        private System.Windows.Forms.ComboBox cbCatalogo;
        private System.Windows.Forms.Button btnVolver;
        private PAYAVISOLARDataSet pAYAVISOLARDataSet;
        private System.Windows.Forms.BindingSource productoKitsBindingSource;
        private PAYAVISOLARDataSetTableAdapters.ProductoKitsTableAdapter productoKitsTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private PAYAVISOLARDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAñadirProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarProducto;
    }
}