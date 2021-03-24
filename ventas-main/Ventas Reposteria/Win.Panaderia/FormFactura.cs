using BL.Rentas;
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
    public partial class FormFactura : Form
    {
        FacturaBL _facturaBL;
        ClientesBL _clientesBL;
        ProductosBL _productoBL;


        public FormFactura()
        {
            InitializeComponent();

            _facturaBL = new FacturaBL();
            listaFacturasBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productoBL = new ProductosBL();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
        }



        private void FormFactura_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            listaFacturasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturasBindingSource.EndEdit();


            var factura = (Factura)listaFacturasBindingSource.Current;
            var resultado = _facturaBL.GuardarFactura(factura);

            if (resultado.Exitoso == true) 
            {
                listaFacturasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada Exitosamente");

                {
                    else
                }
                MessageBox.Show(resultado.Mensaje);

            }
        
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _facturaBL.CancelarCambios();
        }
    }
}



