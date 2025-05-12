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
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();

            //CARGO LOS PRODUCTOS A DATAGRIDPRODUCTOS
            foreach (var p in BaseDeDatos.LeerProductos())
            {
                if (!p.EsKit)
                    dataGridproductos.Rows.Add(p.Id, p.Codigo, p.Descripcion, p.Categoria, p.Marca, p.Precio);
            }

        }
    }
}
