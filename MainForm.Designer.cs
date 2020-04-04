namespace Stack_and_Queue
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPushOrPop = new System.Windows.Forms.TextBox();
            this.btPush = new System.Windows.Forms.Button();
            this.btPop = new System.Windows.Forms.Button();
            this.tbStack = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.bEnQ = new System.Windows.Forms.Button();
            this.bDeQ = new System.Windows.Forms.Button();
            this.tbQueue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPushOrPop
            // 
            this.tbPushOrPop.Location = new System.Drawing.Point(57, 117);
            this.tbPushOrPop.Name = "tbPushOrPop";
            this.tbPushOrPop.Size = new System.Drawing.Size(214, 22);
            this.tbPushOrPop.TabIndex = 0;
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point(57, 154);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(101, 27);
            this.btPush.TabIndex = 1;
            this.btPush.Text = "Push";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.BtPush_Click);
            // 
            // btPop
            // 
            this.btPop.Location = new System.Drawing.Point(170, 154);
            this.btPop.Name = "btPop";
            this.btPop.Size = new System.Drawing.Size(101, 27);
            this.btPop.TabIndex = 2;
            this.btPop.Text = "Pop";
            this.btPop.UseVisualStyleBackColor = true;
            this.btPop.Click += new System.EventHandler(this.BtPop_Click);
            // 
            // tbStack
            // 
            this.tbStack.Location = new System.Drawing.Point(59, 204);
            this.tbStack.Multiline = true;
            this.tbStack.Name = "tbStack";
            this.tbStack.ReadOnly = true;
            this.tbStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStack.Size = new System.Drawing.Size(212, 212);
            this.tbStack.TabIndex = 3;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(494, 117);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(214, 22);
            this.tbInput.TabIndex = 5;
            // 
            // bEnQ
            // 
            this.bEnQ.Location = new System.Drawing.Point(494, 154);
            this.bEnQ.Name = "bEnQ";
            this.bEnQ.Size = new System.Drawing.Size(101, 27);
            this.bEnQ.TabIndex = 6;
            this.bEnQ.Text = "Enqueue";
            this.bEnQ.UseVisualStyleBackColor = true;
            this.bEnQ.Click += new System.EventHandler(this.BEnQ_Click);
            // 
            // bDeQ
            // 
            this.bDeQ.Location = new System.Drawing.Point(607, 154);
            this.bDeQ.Name = "bDeQ";
            this.bDeQ.Size = new System.Drawing.Size(101, 27);
            this.bDeQ.TabIndex = 7;
            this.bDeQ.Text = "Dequeue ";
            this.bDeQ.UseVisualStyleBackColor = true;
            this.bDeQ.Click += new System.EventHandler(this.BDeQ_Click);
            // 
            // tbQueue
            // 
            this.tbQueue.Location = new System.Drawing.Point(494, 204);
            this.tbQueue.Multiline = true;
            this.tbQueue.Name = "tbQueue";
            this.tbQueue.ReadOnly = true;
            this.tbQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbQueue.Size = new System.Drawing.Size(212, 212);
            this.tbQueue.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbQueue);
            this.Controls.Add(this.bDeQ);
            this.Controls.Add(this.bEnQ);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbStack);
            this.Controls.Add(this.btPop);
            this.Controls.Add(this.btPush);
            this.Controls.Add(this.tbPushOrPop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.Text = "Стек и очередь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPushOrPop;
        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.Button btPop;
        private System.Windows.Forms.TextBox tbStack;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button bEnQ;
        private System.Windows.Forms.Button bDeQ;
        private System.Windows.Forms.TextBox tbQueue;
    }
}

