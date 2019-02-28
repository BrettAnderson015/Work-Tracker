namespace WorkTracker
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVEmployees = new System.Windows.Forms.DataGridView();
            this.ButtonAddEmployeeForm = new System.Windows.Forms.Button();
            this.ButtonReturntoJob = new System.Windows.Forms.Button();
            this.buttonUpdateEmployeeList = new System.Windows.Forms.Button();
            this.CBName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBDayTwo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBDayOne = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBDayFour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBDayFive = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBDayThree = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVEmployees
            // 
            this.DGVEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployees.Location = new System.Drawing.Point(12, 69);
            this.DGVEmployees.Name = "DGVEmployees";
            this.DGVEmployees.Size = new System.Drawing.Size(886, 150);
            this.DGVEmployees.TabIndex = 0;
            // 
            // ButtonAddEmployeeForm
            // 
            this.ButtonAddEmployeeForm.Location = new System.Drawing.Point(177, 260);
            this.ButtonAddEmployeeForm.Name = "ButtonAddEmployeeForm";
            this.ButtonAddEmployeeForm.Size = new System.Drawing.Size(92, 23);
            this.ButtonAddEmployeeForm.TabIndex = 1;
            this.ButtonAddEmployeeForm.Text = "Add Employee";
            this.ButtonAddEmployeeForm.UseVisualStyleBackColor = true;
            this.ButtonAddEmployeeForm.Click += new System.EventHandler(this.ButtonAddEmployeeForm_Click);
            // 
            // ButtonReturntoJob
            // 
            this.ButtonReturntoJob.Location = new System.Drawing.Point(782, 260);
            this.ButtonReturntoJob.Name = "ButtonReturntoJob";
            this.ButtonReturntoJob.Size = new System.Drawing.Size(116, 23);
            this.ButtonReturntoJob.TabIndex = 2;
            this.ButtonReturntoJob.Text = "Return to Job List";
            this.ButtonReturntoJob.UseVisualStyleBackColor = true;
            this.ButtonReturntoJob.Click += new System.EventHandler(this.ButtonReturntoJob_Click);
            // 
            // buttonUpdateEmployeeList
            // 
            this.buttonUpdateEmployeeList.Location = new System.Drawing.Point(12, 260);
            this.buttonUpdateEmployeeList.Name = "buttonUpdateEmployeeList";
            this.buttonUpdateEmployeeList.Size = new System.Drawing.Size(121, 23);
            this.buttonUpdateEmployeeList.TabIndex = 3;
            this.buttonUpdateEmployeeList.Text = "Update Employee List";
            this.buttonUpdateEmployeeList.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployeeList.Click += new System.EventHandler(this.buttonLoadAllEmployees_Click);
            // 
            // CBName
            // 
            this.CBName.FormattingEnabled = true;
            this.CBName.Location = new System.Drawing.Point(12, 424);
            this.CBName.Name = "CBName";
            this.CBName.Size = new System.Drawing.Size(121, 21);
            this.CBName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tuesday";
            // 
            // CBDayTwo
            // 
            this.CBDayTwo.FormattingEnabled = true;
            this.CBDayTwo.Location = new System.Drawing.Point(266, 424);
            this.CBDayTwo.Name = "CBDayTwo";
            this.CBDayTwo.Size = new System.Drawing.Size(121, 21);
            this.CBDayTwo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Monday";
            // 
            // CBDayOne
            // 
            this.CBDayOne.FormattingEnabled = true;
            this.CBDayOne.Location = new System.Drawing.Point(139, 424);
            this.CBDayOne.Name = "CBDayOne";
            this.CBDayOne.Size = new System.Drawing.Size(121, 21);
            this.CBDayOne.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Thursday";
            // 
            // CBDayFour
            // 
            this.CBDayFour.FormattingEnabled = true;
            this.CBDayFour.Location = new System.Drawing.Point(520, 424);
            this.CBDayFour.Name = "CBDayFour";
            this.CBDayFour.Size = new System.Drawing.Size(121, 21);
            this.CBDayFour.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Friday";
            // 
            // CBDayFive
            // 
            this.CBDayFive.FormattingEnabled = true;
            this.CBDayFive.Location = new System.Drawing.Point(647, 424);
            this.CBDayFive.Name = "CBDayFive";
            this.CBDayFive.Size = new System.Drawing.Size(121, 21);
            this.CBDayFive.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wednesday";
            // 
            // CBDayThree
            // 
            this.CBDayThree.FormattingEnabled = true;
            this.CBDayThree.Location = new System.Drawing.Point(393, 424);
            this.CBDayThree.Name = "CBDayThree";
            this.CBDayThree.Size = new System.Drawing.Size(121, 21);
            this.CBDayThree.TabIndex = 10;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(774, 414);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 39);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Save Work Assignment";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 512);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBDayFour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBDayFive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBDayThree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBDayOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBDayTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBName);
            this.Controls.Add(this.buttonUpdateEmployeeList);
            this.Controls.Add(this.ButtonReturntoJob);
            this.Controls.Add(this.ButtonAddEmployeeForm);
            this.Controls.Add(this.DGVEmployees);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVEmployees;
        private System.Windows.Forms.Button ButtonAddEmployeeForm;
        private System.Windows.Forms.Button ButtonReturntoJob;
        private System.Windows.Forms.Button buttonUpdateEmployeeList;
        private System.Windows.Forms.ComboBox CBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBDayTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBDayOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBDayFour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBDayFive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBDayThree;
        private System.Windows.Forms.Button buttonUpdate;
    }
}