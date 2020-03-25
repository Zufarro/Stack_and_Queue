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
            // 
            // btPop
            // 
            this.btPop.Location = new System.Drawing.Point(170, 154);
            this.btPop.Name = "btPop";
            this.btPop.Size = new System.Drawing.Size(101, 27);
            this.btPop.TabIndex = 2;
            this.btPop.Text = "Pop";
            this.btPop.UseVisualStyleBackColor = true;
            // 
            // tbStack
            // 
            this.tbStack.Location = new System.Drawing.Point(58, 211);
            this.tbStack.Multiline = true;
            this.tbStack.Name = "tbStack";
            this.tbStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStack.Size = new System.Drawing.Size(212, 212);
            this.tbStack.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStack);
            this.Controls.Add(this.btPop);
            this.Controls.Add(this.btPush);
            this.Controls.Add(this.tbPushOrPop);
            this.Name = "MainForm";
            this.Text = "Стек и очередь";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPushOrPop;
        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.Button btPop;
        private System.Windows.Forms.TextBox tbStack;
    }
}

