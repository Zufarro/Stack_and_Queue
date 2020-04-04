using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{

    class Stack
    {
        static int MaxLength = 3;
        string[] Data = new string[MaxLength];
        int Top = -1;

        private void Push(string inputData)
        {
            if (Top < MaxLength - 1 && inputData != "")
            {
                Top++;
                Data[Top] = inputData;
            }
            else
            {
                return;
            }
        }

        private string Pop()
        {
            if (Top == -1)
            {
                return "";
            }
            else
            {
                string temp = Data[Top];
                Top--;
                return temp;
            }
        }

        public void DoPush(System.Windows.Forms.TextBox tbOutput, System.Windows.Forms.TextBox tbInput)
        {
                Push(tbInput.Text);
            tbOutput.Clear();
            for (int i = Top; i >= 0; i--)
            {
                tbOutput.AppendText(Data[i] + Environment.NewLine);
            }
            tbInput.Clear();
        }
        public void DoPop(System.Windows.Forms.TextBox tbOutput, System.Windows.Forms.TextBox tbInput)
        {
            string getTop = Pop();
            tbOutput.Clear();
            for (int i = Top; i >= 0; i--)
            {
                tbOutput.AppendText(Data[i] + Environment.NewLine);
            }
            tbInput.Clear();
            tbInput.AppendText(getTop);
        }
    }
}
