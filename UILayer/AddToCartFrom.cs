﻿using System;
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
    public partial class AddToCartFrom : Form
    {
        public AddToCartFrom(string text)
        {
            InitializeComponent();
            this.textBox1.Text = text;
        }
    }
}
