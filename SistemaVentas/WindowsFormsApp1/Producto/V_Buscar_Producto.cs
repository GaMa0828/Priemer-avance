using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Producto
{
    public partial class V_Buscar_Producto : Form
    {
        public V_Buscar_Producto()
        {
            InitializeComponent();
        }

        private void V_Buscar_Producto_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            V_Buscar_Producto a = new V_Buscar_Producto();
            a.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
