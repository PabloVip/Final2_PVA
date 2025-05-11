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
            this.dataGridproductos = new System.Windows.Forms.DataGridView();
            this.label_productos = new System.Windows.Forms.Label();
            this.dataGridcarrito = new System.Windows.Forms.DataGridView();
            this.label_carrito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridproductos
            // 
            this.dataGridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridproductos.Location = new System.Drawing.Point(92, 138);
            this.dataGridproductos.Name = "dataGridproductos";
            this.dataGridproductos.RowHeadersWidth = 62;
            this.dataGridproductos.RowTemplate.Height = 28;
            this.dataGridproductos.Size = new System.Drawing.Size(434, 663);
            this.dataGridproductos.TabIndex = 0;
            // 
            // label_productos
            // 
            this.label_productos.AutoSize = true;
            this.label_productos.Location = new System.Drawing.Point(88, 101);
            this.label_productos.Name = "label_productos";
            this.label_productos.Size = new System.Drawing.Size(81, 20);
            this.label_productos.TabIndex = 1;
            this.label_productos.Text = "Productos";
            // 
            // dataGridcarrito
            // 
            this.dataGridcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcarrito.Location = new System.Drawing.Point(632, 138);
            this.dataGridcarrito.Name = "dataGridcarrito";
            this.dataGridcarrito.RowHeadersWidth = 62;
            this.dataGridcarrito.RowTemplate.Height = 28;
            this.dataGridcarrito.Size = new System.Drawing.Size(483, 663);
            this.dataGridcarrito.TabIndex = 2;
            // 
            // label_carrito
            // 
            this.label_carrito.AutoSize = true;
            this.label_carrito.Location = new System.Drawing.Point(633, 106);
            this.label_carrito.Name = "label_carrito";
            this.label_carrito.Size = new System.Drawing.Size(84, 30);
            this.label_carrito.TabIndex = 3;
            this.label_carrito.Text = "Carrito";
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 899);
            this.Controls.Add(this.label_carrito);
            this.Controls.Add(this.dataGridcarrito);
            this.Controls.Add(this.label_productos);
            this.Controls.Add(this.dataGridproductos);
            this.Name = "FormularioProductos";
            this.Text = "FormularioProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridproductos;
        private System.Windows.Forms.Label label_productos;
        private System.Windows.Forms.DataGridView dataGridcarrito;
        private System.Windows.Forms.Label label_carrito;
    }
}