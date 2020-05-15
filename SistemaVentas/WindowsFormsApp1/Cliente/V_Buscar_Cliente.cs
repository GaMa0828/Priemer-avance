using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Cliente
{
    public partial class V__Buscar_Cliente : Form
    {
        public V__Buscar_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            V_Registrar_Cliente a = new V_Registrar_Cliente();
            a.Show();
        }

        private void V__Buscar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
