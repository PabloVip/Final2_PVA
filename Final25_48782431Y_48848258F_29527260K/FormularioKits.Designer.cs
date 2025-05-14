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
            this.btnNuevoKit = new System.Windows.Forms.Button();
            this.btnAñadirProducto = new System.Windows.Forms.Button();
            this.btnEliminarKit = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarKit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pAYAVISOLARDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoKitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCatalogo
            // 
            this.labelCatalogo.AutoSize = true;
            this.labelCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalogo.ForeColor = System.Drawing.Color.Coral;
            this.labelCatalogo.Location = new System.Drawing.Point(12, 9);
            this.labelCatalogo.Name = "labelCatalogo";
            this.labelCatalogo.Size = new System.Drawing.Size(260, 29);
            this.labelCatalogo.TabIndex = 1;
            this.labelCatalogo.Text = "CATÁLOGO DE KITS";
            // 
            // cbCatalogo
            // 
            this.cbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatalogo.FormattingEnabled = true;
            this.cbCatalogo.Location = new System.Drawing.Point(10, 42);
            this.cbCatalogo.Name = "cbCatalogo";
            this.cbCatalogo.Size = new System.Drawing.Size(352, 28);
            this.cbCatalogo.TabIndex = 2;
            this.cbCatalogo.SelectedIndexChanged += new System.EventHandler(this.cbCatalogo_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(1161, 883);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 34);
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
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Codigo,
            this.Descripcion,
            this.Categoria,
            this.Marca,
            this.Precio,
            this.Cantidad});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 202);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1253, 660);
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
            this.Descripcion.Width = 400;
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
            // btnNuevoKit
            // 
            this.btnNuevoKit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoKit.Location = new System.Drawing.Point(369, 38);
            this.btnNuevoKit.Name = "btnNuevoKit";
            this.btnNuevoKit.Size = new System.Drawing.Size(102, 34);
            this.btnNuevoKit.TabIndex = 8;
            this.btnNuevoKit.Text = "Nuevo";
            this.btnNuevoKit.UseVisualStyleBackColor = true;
            this.btnNuevoKit.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirProducto.Location = new System.Drawing.Point(11, 163);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(144, 34);
            this.btnAñadirProducto.TabIndex = 9;
            this.btnAñadirProducto.Text = "Añadir producto";
            this.btnAñadirProducto.UseVisualStyleBackColor = true;
            this.btnAñadirProducto.Click += new System.EventHandler(this.btnAñadirProducto_Click);
            // 
            // btnEliminarKit
            // 
            this.btnEliminarKit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarKit.Location = new System.Drawing.Point(585, 38);
            this.btnEliminarKit.Name = "btnEliminarKit";
            this.btnEliminarKit.Size = new System.Drawing.Size(102, 34);
            this.btnEliminarKit.TabIndex = 10;
            this.btnEliminarKit.Text = "Eliminar";
            this.btnEliminarKit.UseVisualStyleBackColor = true;
            this.btnEliminarKit.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(161, 163);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(144, 34);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarKit
            // 
            this.btnModificarKit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarKit.Location = new System.Drawing.Point(477, 38);
            this.btnModificarKit.Name = "btnModificarKit";
            this.btnModificarKit.Size = new System.Drawing.Size(102, 34);
            this.btnModificarKit.TabIndex = 12;
            this.btnModificarKit.Text = "Modificar";
            this.btnModificarKit.UseVisualStyleBackColor = true;
            this.btnModificarKit.Click += new System.EventHandler(this.btnModificarKit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(72, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(148, 20);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "codigo del producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Descripción:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(99, 43);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(51, 20);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Categoría:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(87, 63);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 20);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(64, 83);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "marca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(68, 103);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 20);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "label12";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Location = new System.Drawing.Point(708, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 135);
            this.panel1.TabIndex = 25;
            // 
            // FormularioKits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1279, 927);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificarKit);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEliminarKit);
            this.Controls.Add(this.btnAñadirProducto);
            this.Controls.Add(this.btnNuevoKit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbCatalogo);
            this.Controls.Add(this.labelCatalogo);
            this.Name = "FormularioKits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kits";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pAYAVISOLARDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoKitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnNuevoKit;
        private System.Windows.Forms.Button btnAñadirProducto;
        private System.Windows.Forms.Button btnEliminarKit;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarKit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Panel panel1;
    }
}