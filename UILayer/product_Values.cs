using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class product_Values : UserControl
    {
        public product_Values()
        {
            InitializeComponent();
        }

        public void openTab(TabPage tb)
        {
            this.tabControl1.TabPages.Add(tb);
            Product_Details _detail = new Product_Details();
            _detail.Dock = DockStyle.Fill;
            _detail.TopLevel = false;
            tb.Controls.Add(_detail);
            _detail.Show();
        }
    }
}
