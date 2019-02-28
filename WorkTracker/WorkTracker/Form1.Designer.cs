namespace WorkTracker
{
    partial class Form1
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
            this.DGVJobs = new System.Windows.Forms.DataGridView();
            this.ButtonAddJob = new System.Windows.Forms.Button();
            this.ButtonLoadAll = new System.Windows.Forms.Button();
            this.ButtonEmployee = new System.Windows.Forms.Button();
            this.CBJobStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVJobs
            // 
            this.DGVJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVJobs.Location = new System.Drawing.Point(24, 90);
            this.DGVJobs.Name = "DGVJobs";
            this.DGVJobs.Size = new System.Drawing.Size(937, 150);
            this.DGVJobs.TabIndex = 4;
            // 
            // ButtonAddJob
            // 
            this.ButtonAddJob.Location = new System.Drawing.Point(80, 341);
            this.ButtonAddJob.Name = "ButtonAddJob";
            this.ButtonAddJob.Size = new System.Drawing.Size(99, 23);
            this.ButtonAddJob.TabIndex = 5;
            this.ButtonAddJob.Text = "Add New Job";
            this.ButtonAddJob.UseVisualStyleBackColor = true;
            this.ButtonAddJob.Click += new System.EventHandler(this.ButtonAddJob_Click_1);
            // 
            // ButtonLoadAll
            // 
            this.ButtonLoadAll.Location = new System.Drawing.Point(83, 284);
            this.ButtonLoadAll.Name = "ButtonLoadAll";
            this.ButtonLoadAll.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoadAll.TabIndex = 6;
            this.ButtonLoadAll.Text = "Load All";
            this.ButtonLoadAll.UseVisualStyleBackColor = true;
            this.ButtonLoadAll.Click += new System.EventHandler(this.ButtonLoadAll_Click);
            // 
            // ButtonEmployee
            // 
            this.ButtonEmployee.Location = new System.Drawing.Point(226, 284);
            this.ButtonEmployee.Name = "ButtonEmployee";
            this.ButtonEmployee.Size = new System.Drawing.Size(108, 23);
            this.ButtonEmployee.TabIndex = 7;
            this.ButtonEmployee.Text = "View Employees";
            this.ButtonEmployee.UseVisualStyleBackColor = true;
            this.ButtonEmployee.Click += new System.EventHandler(this.ButtonEmployee_Click);
            // 
            // CBJobStatus
            // 
            this.CBJobStatus.FormattingEnabled = true;
            this.CBJobStatus.Location = new System.Drawing.Point(153, 50);
            this.CBJobStatus.Name = "CBJobStatus";
            this.CBJobStatus.Size = new System.Drawing.Size(121, 21);
            this.CBJobStatus.TabIndex = 8;
            this.CBJobStatus.SelectedIndexChanged += new System.EventHandler(this.CBJobStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Job Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBJobStatus);
            this.Controls.Add(this.ButtonEmployee);
            this.Controls.Add(this.ButtonLoadAll);
            this.Controls.Add(this.ButtonAddJob);
            this.Controls.Add(this.DGVJobs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVJobs;
        private System.Windows.Forms.Button ButtonAddJob;
        private System.Windows.Forms.Button ButtonLoadAll;
        private System.Windows.Forms.Button ButtonEmployee;
        private System.Windows.Forms.ComboBox CBJobStatus;
        private System.Windows.Forms.Label label1;
    }
}

