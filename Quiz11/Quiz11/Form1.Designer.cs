namespace Quiz11 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            TABLE = new DataGridView();
            viewTableBtn = new Button();
            filterBtn = new Button();
            orderByBtn = new Button();
            findBtn = new Button();
            femalesCntBtn = new Button();
            maxSalaryBtn = new Button();
            minSalaryBtn = new Button();
            avgSalaryBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TABLE).BeginInit();
            SuspendLayout();
            // 
            // TABLE
            // 
            TABLE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABLE.Location = new Point(8, 8);
            TABLE.Name = "TABLE";
            TABLE.RowTemplate.Height = 25;
            TABLE.Size = new Size(886, 400);
            TABLE.TabIndex = 0;
            // 
            // viewTableBtn
            // 
            viewTableBtn.Location = new Point(18, 429);
            viewTableBtn.Name = "viewTableBtn";
            viewTableBtn.Size = new Size(75, 23);
            viewTableBtn.TabIndex = 1;
            viewTableBtn.Text = "View Table";
            viewTableBtn.UseVisualStyleBackColor = true;
            viewTableBtn.Click += viewTableBtn_Click;
            // 
            // filterBtn
            // 
            filterBtn.Location = new Point(114, 429);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(75, 23);
            filterBtn.TabIndex = 1;
            filterBtn.Text = "Filter";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += filterBtn_Click;
            // 
            // orderByBtn
            // 
            orderByBtn.Location = new Point(215, 429);
            orderByBtn.Name = "orderByBtn";
            orderByBtn.Size = new Size(75, 23);
            orderByBtn.TabIndex = 2;
            orderByBtn.Text = "Order";
            orderByBtn.UseVisualStyleBackColor = true;
            orderByBtn.Click += orderByBtn_Click;
            // 
            // findBtn
            // 
            findBtn.Location = new Point(316, 429);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(75, 23);
            findBtn.TabIndex = 2;
            findBtn.Text = "Find";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // femalesCntBtn
            // 
            femalesCntBtn.Location = new Point(417, 429);
            femalesCntBtn.Name = "femalesCntBtn";
            femalesCntBtn.Size = new Size(75, 23);
            femalesCntBtn.TabIndex = 2;
            femalesCntBtn.Text = "Females";
            femalesCntBtn.UseVisualStyleBackColor = true;
            femalesCntBtn.Click += femalesCntBtn_Click;
            // 
            // maxSalaryBtn
            // 
            maxSalaryBtn.Location = new Point(516, 429);
            maxSalaryBtn.Name = "maxSalaryBtn";
            maxSalaryBtn.Size = new Size(75, 23);
            maxSalaryBtn.TabIndex = 2;
            maxSalaryBtn.Text = "Max Salary";
            maxSalaryBtn.UseVisualStyleBackColor = true;
            maxSalaryBtn.Click += maxSalaryBtn_Click;
            // 
            // minSalaryBtn
            // 
            minSalaryBtn.Location = new Point(610, 429);
            minSalaryBtn.Name = "minSalaryBtn";
            minSalaryBtn.Size = new Size(75, 23);
            minSalaryBtn.TabIndex = 2;
            minSalaryBtn.Text = "Min Salary";
            minSalaryBtn.UseVisualStyleBackColor = true;
            minSalaryBtn.Click += minSalaryBtn_Click;
            // 
            // avgSalaryBtn
            // 
            avgSalaryBtn.Location = new Point(709, 429);
            avgSalaryBtn.Name = "avgSalaryBtn";
            avgSalaryBtn.Size = new Size(75, 23);
            avgSalaryBtn.TabIndex = 2;
            avgSalaryBtn.Text = "Avg Salary";
            avgSalaryBtn.UseVisualStyleBackColor = true;
            avgSalaryBtn.Click += avgSalaryBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 514);
            Controls.Add(avgSalaryBtn);
            Controls.Add(minSalaryBtn);
            Controls.Add(maxSalaryBtn);
            Controls.Add(femalesCntBtn);
            Controls.Add(findBtn);
            Controls.Add(orderByBtn);
            Controls.Add(filterBtn);
            Controls.Add(viewTableBtn);
            Controls.Add(TABLE);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)TABLE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TABLE;
        private Button viewTableBtn;
        private Button filterBtn;
        private Button orderByBtn;
        private Button findBtn;
        private Button femalesCntBtn;
        private Button maxSalaryBtn;
        private Button minSalaryBtn;
        private Button avgSalaryBtn;
    }
}