using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UILayer
{
    public partial class ViewInventory : Form
    {
        product_Values productValues = new product_Values();
            
        public ViewInventory()
        {
            InitializeComponent();
            splitContainer1.Visible = false;
            productValues.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(productValues);
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Visible = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TabPage tb = new TabPage();
            if(e.RowIndex>=0)
            {
                tb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                productValues.openTab(tb);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
