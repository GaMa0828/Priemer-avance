using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Cliente;
using WindowsFormsApp1.Producto;
using WindowsFormsApp1.Pedido;
using WindowsFormsApp1.Comprobante;
using WindowsFormsApp1.Catalogo;

namespace WindowsFormsApp1.Menu
{
    public partial class V_Menu : Form
    {
        public V_Menu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            V__Buscar_Cliente a = new V__Buscar_Cliente();
            a.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            V_Buscar_Producto b = new V_Buscar_Producto();
            b.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            V_Pedido c = new V_Pedido();
            c.Show();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            V_Imprimir_Comprobante d = new V_Imprimir_Comprobante();
            d.Show();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            V_Catalogo f = new V_Catalogo();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
