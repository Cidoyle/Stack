using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            i = new NodeStack();
            InitializeComponent();
        }

        NodeStack i;
        //StackOfInt i = new StackOfInt(10);

        private void btnPush_Click(object sender, EventArgs e)
        {
            i.push(int.Parse(txtBox.Text));
        }
        private void btnPop_Click(object sender, EventArgs e)
        {
            txtBox.Text = ""+ i.pop();
        }
    }
}
