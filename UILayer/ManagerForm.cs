using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace UILayer
{
    public partial class ManagerForm : Form
    {
        int count = 0;
        ProfileTab tab = new ProfileTab();
        Employee em = new Employee();
        public ManagerForm()
        {
            InitializeComponent();
            tab.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(tab);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm _aboutForm = new AboutForm();
            _aboutForm.TopLevel = false;
            _aboutForm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(_aboutForm);

            //this.splitContainer1.Panel2.Hide();
            //this.splitContainer1.Panel1.Hide();
            _aboutForm.Show();

            
        }
        
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TabPage tb = new TabPage();
            if (e.RowIndex>=0)
            {
                
                tb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tab.openTab(tb,count);
            }
            count++;
        }
               
    }
}
