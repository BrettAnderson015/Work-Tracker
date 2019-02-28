namespace WorkTracker
{
    partial class AddEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBEmployeeNumber = new System.Windows.Forms.TextBox();
            this.TBEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBEmployeePhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonAddEmployee = new System.Windows.Forms.Button();
            this.ButtonDoneAdding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // TBEmployeeNumber
            // 
            this.TBEmployeeNumber.Location = new System.Drawing.Point(187, 113);
            this.TBEmployeeNumber.Name = "TBEmployeeNumber";
            this.TBEmployeeNumber.Size = new System.Drawing.Size(69, 20);
            this.TBEmployeeNumber.TabIndex = 1;
            // 
            // TBEmployeeName
            // 
            this.TBEmployeeName.Location = new System.Drawing.Point(187, 155);
            this.TBEmployeeName.Name = "TBEmployeeName";
            this.TBEmployeeName.Size = new System.Drawing.Size(202, 20);
            this.TBEmployeeName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // TBEmployeePhone
            // 
            this.TBEmployeePhone.Location = new System.Drawing.Point(187, 198);
            this.TBEmployeePhone.Name = "TBEmployeePhone";
            this.TBEmployeePhone.Size = new System.Drawing.Size(128, 20);
            this.TBEmployeePhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // ButtonAddEmployee
            // 
            this.ButtonAddEmployee.Location = new System.Drawing.Point(187, 264);
            this.ButtonAddEmployee.Name = "ButtonAddEmployee";
            this.ButtonAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddEmployee.TabIndex = 6;
            this.ButtonAddEmployee.Text = "Add";
            this.ButtonAddEmployee.UseVisualStyleBackColor = true;
            this.ButtonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // ButtonDoneAdding
            // 
            this.ButtonDoneAdding.Location = new System.Drawing.Point(299, 264);
            this.ButtonDoneAdding.Name = "ButtonDoneAdding";
            this.ButtonDoneAdding.Size = new System.Drawing.Size(90, 23);
            this.ButtonDoneAdding.TabIndex = 7;
            this.ButtonDoneAdding.Text = "Done Adding";
            this.ButtonDoneAdding.UseVisualStyleBackColor = true;
            this.ButtonDoneAdding.Click += new System.EventHandler(this.ButtonDoneAdding_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonDoneAdding);
            this.Controls.Add(this.ButtonAddEmployee);
            this.Controls.Add(this.TBEmployeePhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBEmployeeNumber);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBEmployeeNumber;
        private System.Windows.Forms.TextBox TBEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBEmployeePhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonAddEmployee;
        private System.Windows.Forms.Button ButtonDoneAdding;
    }
}