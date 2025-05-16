namespace Final25_48782431Y_48848258F_29527260K
{
    partial class FormularioFacturas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumeroCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Empresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(1463, 973);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 36);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lvFacturas
            // 
            this.lvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NumeroCliente,
            this.Empresa,
            this.NombreCliente,
            this.Fecha,
            this.Total});
            this.lvFacturas.FullRowSelect = true;
            this.lvFacturas.HideSelection = false;
            this.lvFacturas.Location = new System.Drawing.Point(9, 50);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(1545, 917);
            this.lvFacturas.TabIndex = 5;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 50;
            // 
            // NumeroCliente
            // 
            this.NumeroCliente.Text = "Nº CLIENTE";
            this.NumeroCliente.Width = 100;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Text = "NOMBRE CLIENTE";
            this.NombreCliente.Width = 300;
            // 
            // Fecha
            // 
            this.Fecha.Text = "FECHA";
            this.Fecha.Width = 150;
            // 
            // Total
            // 
            this.Total.Text = "TOTAL";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Total.Width = 100;
            // 
            // Empresa
            // 
            this.Empresa.Text = "EMPRESA";
            this.Empresa.Width = 200;
            // 
            // FormularioFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 1021);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lvFacturas);
            this.Name = "FormularioFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.FormularioFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListView lvFacturas;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NumeroCliente;
        private System.Windows.Forms.ColumnHeader NombreCliente;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Empresa;
    }
}