namespace Quiz13 {
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
            tbilisiOrdersBtn = new Button();
            contractsBtn = new Button();
            avgSalaryBtn = new Button();
            viewTableBtn = new Button();
            salaryRaiseBtn = new Button();
            newRowBtn = new Button();
            deleteTbilisiRowsBtn = new Button();
            viewTableBtn2 = new Button();
            ((System.ComponentModel.ISupportInitialize)TABLE).BeginInit();
            SuspendLayout();
            // 
            // TABLE
            // 
            TABLE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABLE.Location = new Point(12, 12);
            TABLE.Name = "TABLE";
            TABLE.RowTemplate.Height = 25;
            TABLE.Size = new Size(776, 354);
            TABLE.TabIndex = 0;
            // 
            // tbilisiOrdersBtn
            // 
            tbilisiOrdersBtn.Location = new Point(90, 385);
            tbilisiOrdersBtn.Name = "tbilisiOrdersBtn";
            tbilisiOrdersBtn.Size = new Size(84, 23);
            tbilisiOrdersBtn.TabIndex = 1;
            tbilisiOrdersBtn.Text = "Tbilisi Orders";
            tbilisiOrdersBtn.UseVisualStyleBackColor = true;
            tbilisiOrdersBtn.Click += tbilisiOrdersBtn_Click;
            // 
            // contractsBtn
            // 
            contractsBtn.Location = new Point(185, 385);
            contractsBtn.Name = "contractsBtn";
            contractsBtn.Size = new Size(75, 39);
            contractsBtn.TabIndex = 1;
            contractsBtn.Text = "Contracts Over 3000 GEL";
            contractsBtn.UseVisualStyleBackColor = true;
            contractsBtn.Click += contractsBtn_Click;
            // 
            // avgSalaryBtn
            // 
            avgSalaryBtn.Location = new Point(266, 385);
            avgSalaryBtn.Name = "avgSalaryBtn";
            avgSalaryBtn.Size = new Size(75, 39);
            avgSalaryBtn.TabIndex = 1;
            avgSalaryBtn.Text = "Average Salary";
            avgSalaryBtn.UseVisualStyleBackColor = true;
            avgSalaryBtn.Click += avgSalaryBtn_Click;
            // 
            // viewTableBtn
            // 
            viewTableBtn.Location = new Point(9, 385);
            viewTableBtn.Name = "viewTableBtn";
            viewTableBtn.Size = new Size(75, 23);
            viewTableBtn.TabIndex = 1;
            viewTableBtn.Text = "Personali";
            viewTableBtn.UseVisualStyleBackColor = true;
            viewTableBtn.Click += viewTableBtn_Click;
            // 
            // salaryRaiseBtn
            // 
            salaryRaiseBtn.Location = new Point(347, 385);
            salaryRaiseBtn.Name = "salaryRaiseBtn";
            salaryRaiseBtn.Size = new Size(75, 39);
            salaryRaiseBtn.TabIndex = 1;
            salaryRaiseBtn.Text = "Raise Salaries By 15%";
            salaryRaiseBtn.UseVisualStyleBackColor = true;
            salaryRaiseBtn.Click += salaryRaiseBtn_Click;
            // 
            // newRowBtn
            // 
            newRowBtn.Location = new Point(428, 385);
            newRowBtn.Name = "newRowBtn";
            newRowBtn.Size = new Size(75, 23);
            newRowBtn.TabIndex = 1;
            newRowBtn.Text = "New Row";
            newRowBtn.UseVisualStyleBackColor = true;
            newRowBtn.Click += newRowBtn_Click;
            // 
            // deleteTbilisiRowsBtn
            // 
            deleteTbilisiRowsBtn.Location = new Point(509, 385);
            deleteTbilisiRowsBtn.Name = "deleteTbilisiRowsBtn";
            deleteTbilisiRowsBtn.Size = new Size(80, 39);
            deleteTbilisiRowsBtn.TabIndex = 1;
            deleteTbilisiRowsBtn.Text = "Delete Tbilisi Rows";
            deleteTbilisiRowsBtn.UseVisualStyleBackColor = true;
            deleteTbilisiRowsBtn.Click += deleteTbilisiRowsBtn_Click;
            // 
            // viewTableBtn2
            // 
            viewTableBtn2.Location = new Point(9, 414);
            viewTableBtn2.Name = "viewTableBtn2";
            viewTableBtn2.Size = new Size(75, 26);
            viewTableBtn2.TabIndex = 1;
            viewTableBtn2.Text = "Shemkveti";
            viewTableBtn2.UseVisualStyleBackColor = true;
            viewTableBtn2.Click += viewTableBtn2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(salaryRaiseBtn);
            Controls.Add(newRowBtn);
            Controls.Add(deleteTbilisiRowsBtn);
            Controls.Add(viewTableBtn2);
            Controls.Add(viewTableBtn);
            Controls.Add(avgSalaryBtn);
            Controls.Add(contractsBtn);
            Controls.Add(tbilisiOrdersBtn);
            Controls.Add(TABLE);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TABLE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TABLE;
        private Button tbilisiOrdersBtn;
        private Button contractsBtn;
        private Button avgSalaryBtn;
        private Button viewTableBtn;
        private Button salaryRaiseBtn;
        private Button newRowBtn;
        private Button deleteTbilisiRowsBtn;
        private Button viewTableBtn2;
    }
}