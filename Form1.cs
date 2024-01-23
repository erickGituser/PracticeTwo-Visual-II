using expressApp.bdventa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expressApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void unitOfWork1_SchemaInit(object sender, DevExpress.Xpo.SchemaInitEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            usuario u = new usuario(unitOfWork1);
            u.login = "Marcos";
            u.clave = "marcos 453";
            u.nombre = "Marquitos";
            u.rol = "vendedor";
            unitOfWork1.CommitChanges();
            xpProducto.Reload();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            usuario u = (usuario)gridView1.GetFocusedRow();
            DialogResult d = MessageBox.Show("Want to remove this field?", "Remove complete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                unitOfWork1.Delete(u);
                unitOfWork1.CommitChanges();
                xpProducto.Reload();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            unitOfWork1.CommitChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowForm2_Click(object sender, EventArgs e)
        {
           Form2 form = new Form2();
           form.ShowDialog();
        }
    }
}
