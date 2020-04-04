using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    class Queue
    {
        static int Size = 3;
        string[] Data = new string[Size];
        int End = 0;
        int Start = 0;
        string Message = "ok";



        private void Enqueue(string inputData)
        {
            if (End < Size)
            {
                Data[End] = inputData;
                End++;
            }
            else
            {
               Message = "Очередь заполнена";
            }
        }
        private void Dequeue()
        {
            if (Start != End && Start < Size)
            {
                Start++;
            }
            else
            {
                return;
            }
        }

        private void Anew()
        {
            End = 0;
            Start = 0;
            Message = "ok";
        }
        public void DoEnqueue(System.Windows.Forms.TextBox tbInput, System.Windows.Forms.TextBox tbOutput)
        {
            tbOutput.Clear();
            if (tbInput.Text != "")
            {
                Enqueue(tbInput.Text);
            }
            if (Start < End)
            {
                for (int i = Start; i < End; i++)
                {
                    tbOutput.AppendText(Data[i] + Environment.NewLine);
                }
            }
            tbInput.Clear();
            if (Message != "ok")
            {
                tbInput.AppendText(Message);
            }
        }
        public void DoDequeue(System.Windows.Forms.TextBox tbInput, System.Windows.Forms.TextBox tbOutput)
        {
            tbOutput.Clear();
            tbInput.Clear();
            Dequeue();

            if (Start < End)
            {
                for (int i = Start; i < End; i++)
                {
                    tbOutput.AppendText(Data[i] + Environment.NewLine);
                }         
            }
            tbInput.AppendText(Data[Start - 1]);
            if (Start == Size)
            {
                Anew();
            }
        }
    }
}
