using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{

    class Stack
    {
        static int MaxLength = 100;
        string[] Data = new string[MaxLength];
        int Top = -1;

        public void Push(string inputData)
        {
            if (Top < MaxLength - 1)
            {
                Top++;
                Data[Top] = inputData;
            }
            else
            {
                return;
            }
        }

        public string Pop()
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
        public void showStack(System.Windows.Forms.TextBox tbOutput, System.Windows.Forms.TextBox tbInput, string PopOrPush)
        {
            if (PopOrPush == "Push")
            {
                Push(tbInput.Text);
            }
            else if (PopOrPush == "Pop")
            {
                Pop();
            }
            else
            {
                return;
            }
            
            tbOutput.Clear();
            for (int i = Top; i >= 0; i--)
            {
                tbOutput.AppendText(Data[i] + Environment.NewLine);
            }
            tbInput.Clear();
        }
    }
}
