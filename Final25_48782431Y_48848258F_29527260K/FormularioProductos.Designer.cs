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
            this.label_productos = new System.Windows.Forms.Label();
            this.dataGridcarrito = new System.Windows.Forms.DataGridView();
            this.label_carrito = new System.Windows.Forms.Label();
            this.pAYAVISOLARDataSet = new Final25_48782431Y_48848258F_29527260K.PAYAVISOLARDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Final25_48782431Y_48848258F_29527260K.PAYAVISOLARDataSetTableAdapters.ProductosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esKitDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYAVISOLARDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridproductos
            // 
            this.dataGridproductos.AllowUserToAddRows = false;
            this.dataGridproductos.AllowUserToDeleteRows = false;
            this.dataGridproductos.AutoGenerateColumns = false;
            this.dataGridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.esKitDataGridViewCheckBoxColumn});
            this.dataGridproductos.DataSource = this.productosBindingSource;
            this.dataGridproductos.Location = new System.Drawing.Point(45, 39);
            this.dataGridproductos.Name = "dataGridproductos";
            this.dataGridproductos.ReadOnly = true;
            this.dataGridproductos.RowHeadersWidth = 62;
            this.dataGridproductos.RowTemplate.Height = 28;
            this.dataGridproductos.Size = new System.Drawing.Size(942, 390);
            this.dataGridproductos.TabIndex = 0;
            // 
            // label_productos
            // 
            this.label_productos.AutoSize = true;
            this.label_productos.Location = new System.Drawing.Point(65, 16);
            this.label_productos.Name = "label_productos";
            this.label_productos.Size = new System.Drawing.Size(81, 20);
            this.label_productos.TabIndex = 1;
            this.label_productos.Text = "Productos";
            // 
            // dataGridcarrito
            // 
            this.dataGridcarrito.AllowUserToAddRows = false;
            this.dataGridcarrito.AllowUserToDeleteRows = false;
            this.dataGridcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcarrito.Location = new System.Drawing.Point(45, 495);
            this.dataGridcarrito.Name = "dataGridcarrito";
            this.dataGridcarrito.ReadOnly = true;
            this.dataGridcarrito.RowHeadersWidth = 62;
            this.dataGridcarrito.RowTemplate.Height = 28;
            this.dataGridcarrito.Size = new System.Drawing.Size(942, 366);
            this.dataGridcarrito.TabIndex = 2;
            // 
            // label_carrito
            // 
            this.label_carrito.AutoSize = true;
            this.label_carrito.Location = new System.Drawing.Point(41, 472);
            this.label_carrito.Name = "label_carrito";
            this.label_carrito.Size = new System.Drawing.Size(56, 20);
            this.label_carrito.TabIndex = 3;
            this.label_carrito.Text = "Carrito";
            // 
            // pAYAVISOLARDataSet
            // 
            this.pAYAVISOLARDataSet.DataSetName = "PAYAVISOLARDataSet";
            this.pAYAVISOLARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 150;
            // 
            // esKitDataGridViewCheckBoxColumn
            // 
            this.esKitDataGridViewCheckBoxColumn.DataPropertyName = "EsKit";
            this.esKitDataGridViewCheckBoxColumn.HeaderText = "EsKit";
            this.esKitDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.esKitDataGridViewCheckBoxColumn.Name = "esKitDataGridViewCheckBoxColumn";
            this.esKitDataGridViewCheckBoxColumn.ReadOnly = true;
            this.esKitDataGridViewCheckBoxColumn.Width = 150;
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 899);
            this.Controls.Add(this.label_carrito);
            this.Controls.Add(this.dataGridcarrito);
            this.Controls.Add(this.label_productos);
            this.Controls.Add(this.dataGridproductos);
            this.Name = "FormularioProductos";
            this.Text = "FormularioProductos";
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYAVISOLARDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esKitDataGridViewCheckBoxColumn;
    }
}