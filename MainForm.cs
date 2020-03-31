using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_and_Queue
{
    public partial class MainForm : Form
    {
        Stack stack = new Stack();

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtPush_Click(object sender, EventArgs e)
        {
          stack.showStack(tbStack, tbPushOrPop, "Push");
        }

        private void BtPop_Click(object sender, EventArgs e)
        {
            stack.showStack(tbStack, tbPushOrPop, "Pop");

        }

        
    }
}
