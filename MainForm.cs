﻿using System;
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
        Queue queue = new Queue();

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtPush_Click(object sender, EventArgs e)
        {
          stack.DoPush(tbStack, tbPushOrPop);
        }

        private void BtPop_Click(object sender, EventArgs e)
        {
            stack.DoPop(tbStack, tbPushOrPop);

        }

        private void BEnQ_Click(object sender, EventArgs e)
        {
            queue.DoEnqueue(tbInput, tbQueue);
        }

        private void BDeQ_Click(object sender, EventArgs e)
        {
            queue.DoDequeue(tbInput, tbQueue);
        }
    }
}
