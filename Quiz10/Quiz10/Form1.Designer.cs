namespace Quiz10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            delegateBtnTask1 = new Button();
            label1 = new Label();
            delegateBtnTask2 = new Button();
            delegateBtnTask3 = new Button();
            delegateBtnTask4 = new Button();
            delegateBtnTask5 = new Button();
            delegateOutput = new Label();
            label2 = new Label();
            eventBtnTask1 = new Button();
            eventBtnTask2 = new Button();
            eventBtnTask3 = new Button();
            eventBtnTask4 = new Button();
            eventBtnTask5 = new Button();
            delegateClearBtn = new Button();
            eventsOutput = new Label();
            eventBtnTask6 = new Button();
            eventBtnTask7 = new Button();
            eventBtnTask8 = new Button();
            SuspendLayout();
            // 
            // delegateBtnTask1
            // 
            delegateBtnTask1.Location = new Point(26, 59);
            delegateBtnTask1.Name = "delegateBtnTask1";
            delegateBtnTask1.Size = new Size(75, 23);
            delegateBtnTask1.TabIndex = 0;
            delegateBtnTask1.Text = "Task 1";
            delegateBtnTask1.UseVisualStyleBackColor = true;
            delegateBtnTask1.Click += delegateBtnTask1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 1;
            label1.Text = "Delegates";
            // 
            // delegateBtnTask2
            // 
            delegateBtnTask2.Location = new Point(107, 59);
            delegateBtnTask2.Name = "delegateBtnTask2";
            delegateBtnTask2.Size = new Size(75, 23);
            delegateBtnTask2.TabIndex = 0;
            delegateBtnTask2.Text = "Task 2";
            delegateBtnTask2.UseVisualStyleBackColor = true;
            delegateBtnTask2.Click += delegateBtnTask2_Click;
            // 
            // delegateBtnTask3
            // 
            delegateBtnTask3.Location = new Point(188, 59);
            delegateBtnTask3.Name = "delegateBtnTask3";
            delegateBtnTask3.Size = new Size(75, 23);
            delegateBtnTask3.TabIndex = 0;
            delegateBtnTask3.Text = "Task 3";
            delegateBtnTask3.UseVisualStyleBackColor = true;
            delegateBtnTask3.Click += delegateBtnTask3_Click;
            // 
            // delegateBtnTask4
            // 
            delegateBtnTask4.Location = new Point(26, 88);
            delegateBtnTask4.Name = "delegateBtnTask4";
            delegateBtnTask4.Size = new Size(75, 23);
            delegateBtnTask4.TabIndex = 0;
            delegateBtnTask4.Text = "Task 4";
            delegateBtnTask4.UseVisualStyleBackColor = true;
            delegateBtnTask4.Click += delegateBtnTask4_Click;
            // 
            // delegateBtnTask5
            // 
            delegateBtnTask5.Location = new Point(107, 88);
            delegateBtnTask5.Name = "delegateBtnTask5";
            delegateBtnTask5.Size = new Size(75, 23);
            delegateBtnTask5.TabIndex = 0;
            delegateBtnTask5.Text = "Task 5";
            delegateBtnTask5.UseVisualStyleBackColor = true;
            delegateBtnTask5.Click += delegateBtnTask5_Click;
            // 
            // delegateOutput
            // 
            delegateOutput.AutoSize = true;
            delegateOutput.Location = new Point(338, 59);
            delegateOutput.Name = "delegateOutput";
            delegateOutput.Size = new Size(0, 15);
            delegateOutput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 208);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 1;
            label2.Text = "Events";
            // 
            // eventBtnTask1
            // 
            eventBtnTask1.Location = new Point(26, 243);
            eventBtnTask1.Name = "eventBtnTask1";
            eventBtnTask1.Size = new Size(75, 23);
            eventBtnTask1.TabIndex = 0;
            eventBtnTask1.Text = "Task 1";
            eventBtnTask1.UseVisualStyleBackColor = true;
            eventBtnTask1.Click += eventBtnTask1_Click;
            // 
            // eventBtnTask2
            // 
            eventBtnTask2.Location = new Point(107, 243);
            eventBtnTask2.Name = "eventBtnTask2";
            eventBtnTask2.Size = new Size(75, 23);
            eventBtnTask2.TabIndex = 0;
            eventBtnTask2.Text = "Task 2";
            eventBtnTask2.UseVisualStyleBackColor = true;
            eventBtnTask2.Click += eventBtnTask2_Click;
            // 
            // eventBtnTask3
            // 
            eventBtnTask3.Location = new Point(188, 243);
            eventBtnTask3.Name = "eventBtnTask3";
            eventBtnTask3.Size = new Size(75, 23);
            eventBtnTask3.TabIndex = 0;
            eventBtnTask3.Text = "Task 3";
            eventBtnTask3.UseVisualStyleBackColor = true;
            eventBtnTask3.Click += eventBtnTask3_Click;
            // 
            // eventBtnTask4
            // 
            eventBtnTask4.Location = new Point(26, 272);
            eventBtnTask4.Name = "eventBtnTask4";
            eventBtnTask4.Size = new Size(75, 23);
            eventBtnTask4.TabIndex = 0;
            eventBtnTask4.Text = "Task 4";
            eventBtnTask4.UseVisualStyleBackColor = true;
            eventBtnTask4.Click += eventBtnTask4_Click;
            // 
            // eventBtnTask5
            // 
            eventBtnTask5.Location = new Point(107, 272);
            eventBtnTask5.Name = "eventBtnTask5";
            eventBtnTask5.Size = new Size(75, 23);
            eventBtnTask5.TabIndex = 0;
            eventBtnTask5.Text = "Task 5";
            eventBtnTask5.UseVisualStyleBackColor = true;
            eventBtnTask5.Click += eventBtnTask5_Click;
            // 
            // delegateClearBtn
            // 
            delegateClearBtn.Location = new Point(188, 88);
            delegateClearBtn.Name = "delegateClearBtn";
            delegateClearBtn.Size = new Size(75, 23);
            delegateClearBtn.TabIndex = 0;
            delegateClearBtn.Text = "Clear";
            delegateClearBtn.UseVisualStyleBackColor = true;
            delegateClearBtn.Click += delegateClearBtn_Click;
            // 
            // eventsOutput
            // 
            eventsOutput.AutoSize = true;
            eventsOutput.Location = new Point(338, 251);
            eventsOutput.Name = "eventsOutput";
            eventsOutput.Size = new Size(0, 15);
            eventsOutput.TabIndex = 2;
            // 
            // eventBtnTask6
            // 
            eventBtnTask6.Location = new Point(188, 272);
            eventBtnTask6.Name = "eventBtnTask6";
            eventBtnTask6.Size = new Size(75, 23);
            eventBtnTask6.TabIndex = 0;
            eventBtnTask6.Text = "Task 6";
            eventBtnTask6.UseVisualStyleBackColor = true;
            eventBtnTask6.Click += eventBtnTask6_Click;
            // 
            // eventBtnTask7
            // 
            eventBtnTask7.Location = new Point(26, 301);
            eventBtnTask7.Name = "eventBtnTask7";
            eventBtnTask7.Size = new Size(75, 23);
            eventBtnTask7.TabIndex = 0;
            eventBtnTask7.Text = "Task 7";
            eventBtnTask7.UseVisualStyleBackColor = true;
            eventBtnTask7.Click += eventBtnTask7_Click;
            // 
            // eventBtnTask8
            // 
            eventBtnTask8.Location = new Point(107, 301);
            eventBtnTask8.Name = "eventBtnTask8";
            eventBtnTask8.Size = new Size(75, 23);
            eventBtnTask8.TabIndex = 0;
            eventBtnTask8.Text = "Task 8";
            eventBtnTask8.UseVisualStyleBackColor = true;
            eventBtnTask8.Click += eventBtnTask8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 497);
            Controls.Add(eventsOutput);
            Controls.Add(delegateOutput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delegateBtnTask3);
            Controls.Add(delegateClearBtn);
            Controls.Add(delegateBtnTask5);
            Controls.Add(delegateBtnTask2);
            Controls.Add(delegateBtnTask4);
            Controls.Add(eventBtnTask3);
            Controls.Add(eventBtnTask8);
            Controls.Add(eventBtnTask7);
            Controls.Add(eventBtnTask6);
            Controls.Add(eventBtnTask5);
            Controls.Add(eventBtnTask4);
            Controls.Add(eventBtnTask2);
            Controls.Add(eventBtnTask1);
            Controls.Add(delegateBtnTask1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button delegateBtnTask1;
        private Label label1;
        private Button delegateBtnTask2;
        private Button delegateBtnTask3;
        private Button delegateBtnTask4;
        private Button delegateBtnTask5;
        private Label delegateOutput;
        private Label label2;
        private Button eventBtnTask1;
        private Button eventBtnTask2;
        private Button eventBtnTask3;
        private Button eventBtnTask4;
        private Button eventBtnTask5;
        private Button delegateClearBtn;
        private Label eventsOutput;
        private Button eventBtnTask6;
        private Button eventBtnTask7;
        private Button eventBtnTask8;
    }
}