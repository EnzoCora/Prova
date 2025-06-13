using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaProgEstru
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadCliente cliente = new CadCliente();
            cliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            produto.ShowDialog();
        }

        private void btnCadPedido_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.ShowDialog();
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            CadUsuario usuario = new CadUsuario();
            usuario.ShowDialog();
        }

        private void btnConsultPedido_Click(object sender, EventArgs e)
        {
            ConsultaPedido consultaPedido = new ConsultaPedido();
            consultaPedido.ShowDialog();
        }
    }
}
