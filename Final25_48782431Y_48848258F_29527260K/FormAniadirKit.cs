using Final25_48782431Y_48848258F_29527260K.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final25_48782431Y_48848258F_29527260K
{
    public partial class FormAniadirKit : Form
    {
        public Producto kit { get; private set;}
        
        public FormAniadirKit()
        {
            InitializeComponent();
        }

        //ARREGLAR AÑADIR CREAR KIT Y AÑADIR PRODUCTO, (COMO DEVOLVER UN PRODUCTO PARA AÑADIRLO A BBDD?)
        private void btnCrear_Click(object sender, EventArgs e)
        {
            //METO LOS DATOS DEL KIT
            kit = new Producto();
            kit.Codigo = tbCodigo.Text;
            //compruebo que el codigo no exista
            if(BaseDeDatos.ProductoExiste(kit.Codigo))
            {
                MessageBox.Show("Ese kit ya existe");
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            kit.Descripcion = tbDescripcion.Text;
            kit.Categoria = tbCategoria.Text;
            kit.Marca = tbMarca.Text;
            kit.Precio = decimal.Parse(tbPrecio.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
     }
}


