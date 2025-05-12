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
            this.labelCatalogo.Location = new System.Drawing.Point(88, 37);
            this.labelCatalogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCatalogo.Name = "labelCatalogo";
            this.labelCatalogo.Size = new System.Drawing.Size(350, 25);
            this.labelCatalogo.TabIndex = 1;
            this.labelCatalogo.Text = "CATÁLOGO DE NUESTROS KITS";
            // 
            // cbCatalogo
            // 
            this.cbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatalogo.FormattingEnabled = true;
            this.cbCatalogo.Location = new System.Drawing.Point(115, 77);
            this.cbCatalogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCatalogo.Name = "cbCatalogo";
            this.cbCatalogo.Size = new System.Drawing.Size(206, 21);
            this.cbCatalogo.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(25, 433);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(68, 22);
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
            // FormularioKits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(458, 475);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbCatalogo);
            this.Controls.Add(this.labelCatalogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormularioKits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioKits";
            this.Load += new System.EventHandler(this.FormularioKits_Load);
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
    }
}