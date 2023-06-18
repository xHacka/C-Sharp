namespace Quiz12 {
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
            update6thBtn = new Button();
            viewTableBtn = new Button();
            AddRowBtn = new Button();
            button1 = new Button();
            delete2ndBtn = new Button();
            joinTablesBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TABLE).BeginInit();
            SuspendLayout();
            // 
            // TABLE
            // 
            TABLE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABLE.Location = new Point(12, 12);
            TABLE.Name = "TABLE";
            TABLE.RowTemplate.Height = 25;
            TABLE.Size = new Size(776, 347);
            TABLE.TabIndex = 0;
            // 
            // update6thBtn
            // 
            update6thBtn.Location = new Point(105, 375);
            update6thBtn.Name = "update6thBtn";
            update6thBtn.Size = new Size(75, 23);
            update6thBtn.TabIndex = 1;
            update6thBtn.Text = "Update 6th";
            update6thBtn.UseVisualStyleBackColor = true;
            update6thBtn.Click += update6thBtn_Click;
            // 
            // viewTableBtn
            // 
            viewTableBtn.Location = new Point(22, 375);
            viewTableBtn.Name = "viewTableBtn";
            viewTableBtn.Size = new Size(75, 23);
            viewTableBtn.TabIndex = 2;
            viewTableBtn.Text = "View Table";
            viewTableBtn.UseVisualStyleBackColor = true;
            viewTableBtn.Click += viewTableBtn_Click;
            // 
            // AddRowBtn
            // 
            AddRowBtn.Location = new Point(189, 375);
            AddRowBtn.Name = "AddRowBtn";
            AddRowBtn.Size = new Size(75, 23);
            AddRowBtn.TabIndex = 3;
            AddRowBtn.Text = "Add Row";
            AddRowBtn.UseVisualStyleBackColor = true;
            AddRowBtn.Click += AddRowBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(635, 375);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // delete2ndBtn
            // 
            delete2ndBtn.Location = new Point(272, 375);
            delete2ndBtn.Name = "delete2ndBtn";
            delete2ndBtn.Size = new Size(75, 23);
            delete2ndBtn.TabIndex = 4;
            delete2ndBtn.Text = "Delete 2nd";
            delete2ndBtn.UseVisualStyleBackColor = true;
            delete2ndBtn.Click += delete2ndBtn_Click;
            // 
            // joinTablesBtn
            // 
            joinTablesBtn.Location = new Point(353, 375);
            joinTablesBtn.Name = "joinTablesBtn";
            joinTablesBtn.Size = new Size(75, 23);
            joinTablesBtn.TabIndex = 4;
            joinTablesBtn.Text = "Join Tables";
            joinTablesBtn.UseVisualStyleBackColor = true;
            joinTablesBtn.Click += joinTablesBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete2ndBtn);
            Controls.Add(joinTablesBtn);
            Controls.Add(button1);
            Controls.Add(AddRowBtn);
            Controls.Add(viewTableBtn);
            Controls.Add(update6thBtn);
            Controls.Add(TABLE);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TABLE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TABLE;
        private Button update6thBtn;
        private Button viewTableBtn;
        private Button AddRowBtn;
        private Button button1;
        private Button delete2ndBtn;
        private Button joinTablesBtn;
    }
}