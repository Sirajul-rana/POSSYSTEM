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
    public partial class PosSystem : Form
    {
        public PosSystem()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(21);
            timer_Now.Start();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done", " Well Done", MessageBoxButtons.OK);
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log= new LoginForm();
            log.Show(); 
        }

        private void timer_Now_Tick(object sender, EventArgs e)
        {
            labelClock.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string[] divide = tBoxCode.Text.Split('-');
            string firstValue = divide[0];
            string secondValue = divide[1];



            AddToCartFrom addToCartFrom = new AddToCartFrom(this.tBoxCode.Text);
            addToCartFrom.Show();
        }
    }
}
