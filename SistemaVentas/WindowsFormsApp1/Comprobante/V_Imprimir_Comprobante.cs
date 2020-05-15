using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Comprobante
{
    public partial class V_Imprimir_Comprobante : Form
    {
        public V_Imprimir_Comprobante()
        {
            InitializeComponent();
        }

        private void V_Imprimir_Comprobante_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
