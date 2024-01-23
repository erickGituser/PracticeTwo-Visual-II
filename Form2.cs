using expressApp.bdventa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expressApp
{
    public partial class Form2 : Form
    {
        venta venta;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            venta = new venta(unitOfWork1);
            gridDetalle.DataSource = venta.detalles;
        }

        private void searchClient_EditValueChanged(object sender, EventArgs e)
        {
            cliente cli =(cliente) searchLookUpEdit1View.GetFocusedRow();
            venta.cliente_idcliente = cli;

        }

        private void ctCantidad_EditValueChanged(object sender, EventArgs e)
        {
            if(ctCantidad.Text.Trim().Length == 0) {
                return;
            }
            producto p = (producto)gridView1.GetFocusedRow();
            int cantidad = Convert.ToInt32(ctCantidad.Text);
            ctSubTotal.Text = (cantidad * p.precio).ToString(); 
        }

        private void ctSubTotal_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            detalle detalle_venta = new detalle(unitOfWork1);
            detalle_venta.producto_idproducto = (producto)gridView1.GetFocusedRow();
            detalle_venta.cantidad = Convert.ToInt32(ctCantidad.Text);  
            detalle_venta.subtotal = Convert.ToInt32(ctSubTotal.Text);
            detalle_venta.Save();

            venta.detalles.Add(detalle_venta);
           
        }

        private void searchProducto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void unitOfWork1_SchemaInit(object sender, DevExpress.Xpo.SchemaInitEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            venta.fecha = DateTime.Today;
            unitOfWork1.CommitChanges();
            MessageBox.Show("Venta realizada correactamente...");

        }
    }
}