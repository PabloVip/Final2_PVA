namespace Final25_48782431Y_48848258F_29527260K
{
    partial class FormularioProductos
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
            this.dataGridproductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAYAVISOLARDataSet = new Final25_48782431Y_48848258F_29527260K.PAYAVISOLARDataSet();
            this.label_productos = new System.Windows.Forms.Label();
            this.dataGridcarrito = new System.Windows.Forms.DataGridView();
            this.label_carrito = new System.Windows.Forms.Label();
            this.productosTableAdapter = new Final25_48782431Y_48848258F_29527260K.PAYAVISOLARDataSetTableAdapters.ProductosTableAdapter();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnvolverproductos = new System.Windows.Forms.Button();
            this.btncrearfactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYAVISOLARDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridproductos
            // 
            this.dataGridproductos.AllowUserToAddRows = false;
            this.dataGridproductos.AllowUserToDeleteRows = false;
            this.dataGridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Descripcion,
            this.Categoria,
            this.Marca,
            this.Precio});
            this.dataGridproductos.Location = new System.Drawing.Point(45, 63);
            this.dataGridproductos.Name = "dataGridproductos";
            this.dataGridproductos.ReadOnly = true;
            this.dataGridproductos.RowHeadersWidth = 62;
            this.dataGridproductos.RowTemplate.Height = 28;
            this.dataGridproductos.Size = new System.Drawing.Size(1212, 337);
            this.dataGridproductos.TabIndex = 0;
            this.dataGridproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridproductos_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 200;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 10;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 10;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 10;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 200;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 10;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 10;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 200;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.pAYAVISOLARDataSet;
            // 
            // pAYAVISOLARDataSet
            // 
            this.pAYAVISOLARDataSet.DataSetName = "PAYAVISOLARDataSet";
            this.pAYAVISOLARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_productos
            // 
            this.label_productos.AutoSize = true;
            this.label_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productos.Location = new System.Drawing.Point(40, 31);
            this.label_productos.Name = "label_productos";
            this.label_productos.Size = new System.Drawing.Size(131, 29);
            this.label_productos.TabIndex = 1;
            this.label_productos.Text = "Productos";
            // 
            // dataGridcarrito
            // 
            this.dataGridcarrito.AllowUserToDeleteRows = false;
            this.dataGridcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcarrito.Location = new System.Drawing.Point(45, 459);
            this.dataGridcarrito.Name = "dataGridcarrito";
            this.dataGridcarrito.ReadOnly = true;
            this.dataGridcarrito.RowHeadersWidth = 62;
            this.dataGridcarrito.RowTemplate.Height = 28;
            this.dataGridcarrito.Size = new System.Drawing.Size(1212, 314);
            this.dataGridcarrito.TabIndex = 2;
            // 
            // label_carrito
            // 
            this.label_carrito.AutoSize = true;
            this.label_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_carrito.Location = new System.Drawing.Point(40, 427);
            this.label_carrito.Name = "label_carrito";
            this.label_carrito.Size = new System.Drawing.Size(92, 29);
            this.label_carrito.TabIndex = 3;
            this.label_carrito.Text = "Carrito";
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(45, 781);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(228, 61);
            this.btnEliminarProducto.TabIndex = 4;
            this.btnEliminarProducto.Text = "Borrar producto del carrito";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnvolverproductos
            // 
            this.btnvolverproductos.Location = new System.Drawing.Point(1110, 779);
            this.btnvolverproductos.Name = "btnvolverproductos";
            this.btnvolverproductos.Size = new System.Drawing.Size(147, 63);
            this.btnvolverproductos.TabIndex = 5;
            this.btnvolverproductos.Text = "Volver";
            this.btnvolverproductos.UseVisualStyleBackColor = true;
            this.btnvolverproductos.Click += new System.EventHandler(this.btnvolverproductos_Click);
            // 
            // btncrearfactura
            // 
            this.btncrearfactura.Location = new System.Drawing.Point(1292, 459);
            this.btncrearfactura.Name = "btncrearfactura";
            this.btncrearfactura.Size = new System.Drawing.Size(190, 314);
            this.btncrearfactura.TabIndex = 6;
            this.btncrearfactura.Text = "Crear factura";
            this.btncrearfactura.UseVisualStyleBackColor = true;
            this.btncrearfactura.Click += new System.EventHandler(this.btncrearfactura_Click);
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 877);
            this.Controls.Add(this.btncrearfactura);
            this.Controls.Add(this.btnvolverproductos);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.label_carrito);
            this.Controls.Add(this.dataGridcarrito);
            this.Controls.Add(this.label_productos);
            this.Controls.Add(this.dataGridproductos);
            this.Name = "FormularioProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYAVISOLARDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridproductos;
        private System.Windows.Forms.Label label_productos;
        private System.Windows.Forms.DataGridView dataGridcarrito;
        private System.Windows.Forms.Label label_carrito;
        private PAYAVISOLARDataSet pAYAVISOLARDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private PAYAVISOLARDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnvolverproductos;
        private System.Windows.Forms.Button btncrearfactura;
    }
}