using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pedido
{
    public partial class V_Pedido : Form
    {
        public V_Pedido()
        {
            InitializeComponent();
        }

        private void V_Crear__Pedido_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            V_Crear a = new V_Crear();
            a.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            V_Consulta_Nombre a = new V_Consulta_Nombre();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            V_Consultar_Categoria b = new V_Consultar_Categoria();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_Consultar_Codigo c = new V_Consultar_Codigo();
            c.Show();
        }
    }
}
