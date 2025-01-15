namespace Task_Project
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
            this.descTxt = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.taskProgress = new System.Windows.Forms.ProgressBar();
            this.checkedListTasks = new System.Windows.Forms.CheckedListBox();
            this.txtSpent = new System.Windows.Forms.TextBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.completionLabel = new System.Windows.Forms.Label();
            this.dueLabel = new System.Windows.Forms.Label();
            this.spendLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descTxt
            // 
            this.descTxt.AllowDrop = true;
            this.descTxt.AutoSize = true;
            this.descTxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.descTxt.Font = new System.Drawing.Font("Georgia", 36F);
            this.descTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descTxt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.descTxt.Location = new System.Drawing.Point(262, 9);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(366, 82);
            this.descTxt.TabIndex = 0;
            this.descTxt.Tag = "descTxt";
            this.descTxt.Text = "To Do List";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(111, 151);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(136, 26);
            this.txtTaskName.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(111, 228);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(136, 26);
            this.txtTime.TabIndex = 2;
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(111, 310);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(136, 26);
            this.txtDue.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Georgia", 14F);
            this.btnSave.Location = new System.Drawing.Point(111, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save task";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // taskProgress
            // 
            this.taskProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskProgress.Location = new System.Drawing.Point(12, 534);
            this.taskProgress.Name = "taskProgress";
            this.taskProgress.Size = new System.Drawing.Size(729, 45);
            this.taskProgress.TabIndex = 7;
            // 
            // checkedListTasks
            // 
            this.checkedListTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkedListTasks.CheckOnClick = true;
            this.checkedListTasks.Font = new System.Drawing.Font("Georgia", 12F);
            this.checkedListTasks.FormattingEnabled = true;
            this.checkedListTasks.Location = new System.Drawing.Point(320, 96);
            this.checkedListTasks.Name = "checkedListTasks";
            this.checkedListTasks.Size = new System.Drawing.Size(418, 420);
            this.checkedListTasks.TabIndex = 8;
            this.checkedListTasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListTasks_ItemCheck);
            // 
            // txtSpent
            // 
            this.txtSpent.Location = new System.Drawing.Point(111, 396);
            this.txtSpent.Name = "txtSpent";
            this.txtSpent.Size = new System.Drawing.Size(136, 26);
            this.txtSpent.TabIndex = 9;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelProgress.Location = new System.Drawing.Point(350, 545);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 32);
            this.labelProgress.TabIndex = 10;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.taskLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.taskLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taskLabel.Location = new System.Drawing.Point(150, 106);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(72, 32);
            this.taskLabel.TabIndex = 11;
            this.taskLabel.Text = "Task";
            // 
            // completionLabel
            // 
            this.completionLabel.AutoSize = true;
            this.completionLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.completionLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.completionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.completionLabel.Location = new System.Drawing.Point(105, 193);
            this.completionLabel.Name = "completionLabel";
            this.completionLabel.Size = new System.Drawing.Size(231, 32);
            this.completionLabel.TabIndex = 12;
            this.completionLabel.Text = "Completion Time";
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dueLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.dueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dueLabel.Location = new System.Drawing.Point(156, 275);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(66, 32);
            this.dueLabel.TabIndex = 13;
            this.dueLabel.Text = "Due";
            // 
            // spendLabel
            // 
            this.spendLabel.AutoSize = true;
            this.spendLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.spendLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.spendLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.spendLabel.Location = new System.Drawing.Point(114, 361);
            this.spendLabel.Name = "spendLabel";
            this.spendLabel.Size = new System.Drawing.Size(200, 32);
            this.spendLabel.TabIndex = 14;
            this.spendLabel.Text = "Available Time";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(753, 591);
            this.Controls.Add(this.spendLabel);
            this.Controls.Add(this.dueLabel);
            this.Controls.Add(this.completionLabel);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.checkedListTasks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSpent);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.taskProgress);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label descTxt;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtSpent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ProgressBar taskProgress;
        private System.Windows.Forms.CheckedListBox checkedListTasks;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label completionLabel;
        private System.Windows.Forms.Label dueLabel;
        private System.Windows.Forms.Label spendLabel;
    }
}

