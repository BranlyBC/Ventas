using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Panaderia
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();

        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();


        }

        private void registroDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVentas = new FormVentas();
            formVentas.MdiParent = this;
            formVentas.Show();
        }

        private void reporteDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formInventario = new FormInventario();
            formInventario.MdiParent = this;
            formInventario.Show();
        }

        private void reporteDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRproducto = new FormRproducto();
            formRproducto.MdiParent = this;
            formRproducto.Show();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRventas = new FormRventas();
            formRventas.MdiParent = this;
            formRventas.Show();
        }

        private void reporteDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRproveedores = new FormRproveedores();
            formRproveedores.MdiParent = this;
            formRproveedores.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS POR UTILIZAR NUESTROS SISTEMAS");
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }
    }
}
