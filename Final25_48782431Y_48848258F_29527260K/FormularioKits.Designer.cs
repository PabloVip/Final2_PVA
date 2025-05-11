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
            this.GridKits = new System.Windows.Forms.DataGridView();
            this.labelCatalogo = new System.Windows.Forms.Label();
            this.labelBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridKits)).BeginInit();
            this.SuspendLayout();
            // 
            // GridKits
            // 
            this.GridKits.AllowUserToAddRows = false;
            this.GridKits.AllowUserToDeleteRows = false;
            this.GridKits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridKits.Location = new System.Drawing.Point(64, 134);
            this.GridKits.Name = "GridKits";
            this.GridKits.ReadOnly = true;
            this.GridKits.RowHeadersWidth = 82;
            this.GridKits.RowTemplate.Height = 33;
            this.GridKits.Size = new System.Drawing.Size(764, 417);
            this.GridKits.TabIndex = 0;
            // 
            // labelCatalogo
            // 
            this.labelCatalogo.AutoSize = true;
            this.labelCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalogo.ForeColor = System.Drawing.Color.Coral;
            this.labelCatalogo.Location = new System.Drawing.Point(177, 72);
            this.labelCatalogo.Name = "labelCatalogo";
            this.labelCatalogo.Size = new System.Drawing.Size(540, 37);
            this.labelCatalogo.TabIndex = 1;
            this.labelCatalogo.Text = "CATÁLOGO DE NUESTROS KITS";
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.Location = new System.Drawing.Point(82, 603);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(282, 25);
            this.labelBusqueda.TabIndex = 2;
            this.labelBusqueda.Text = "Búsqueda de kit por nombre";
            // 
            // FormularioKits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(906, 1022);
            this.Controls.Add(this.labelBusqueda);
            this.Controls.Add(this.labelCatalogo);
            this.Controls.Add(this.GridKits);
            this.Name = "FormularioKits";
            this.Text = "FormularioKits";
            ((System.ComponentModel.ISupportInitialize)(this.GridKits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridKits;
        private System.Windows.Forms.Label labelCatalogo;
        private System.Windows.Forms.Label labelBusqueda;
    }
}