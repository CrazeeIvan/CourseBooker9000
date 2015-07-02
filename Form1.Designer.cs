namespace Course_Booker_9000
{
    partial class frmMain
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.tspFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tspNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tspOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tspExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbxCourseWindow = new System.Windows.Forms.ListBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspFile});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(463, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // tspFile
            // 
            this.tspFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspNew,
            this.tspOpen,
            this.tspSave,
            this.tspExit});
            this.tspFile.Name = "tspFile";
            this.tspFile.Size = new System.Drawing.Size(94, 20);
            this.tspFile.Text = "File";
            // 
            // tspNew
            // 
            this.tspNew.Name = "tspNew";
            this.tspNew.Size = new System.Drawing.Size(152, 22);
            this.tspNew.Text = "New";
            // 
            // tspOpen
            // 
            this.tspOpen.Name = "tspOpen";
            this.tspOpen.Size = new System.Drawing.Size(152, 22);
            this.tspOpen.Text = "Open";
            this.tspOpen.Click += new System.EventHandler(this.tspOpen_Click);
            // 
            // tspSave
            // 
            this.tspSave.Name = "tspSave";
            this.tspSave.Size = new System.Drawing.Size(152, 22);
            this.tspSave.Text = "Save";
            this.tspSave.Click += new System.EventHandler(this.tspSave_Click);
            // 
            // tspExit
            // 
            this.tspExit.Name = "tspExit";
            this.tspExit.Size = new System.Drawing.Size(152, 22);
            this.tspExit.Text = "Exit";
            this.tspExit.Click += new System.EventHandler(this.tspExit_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(12, 231);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtCourseName.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 283);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbxCourseWindow
            // 
            this.lbxCourseWindow.FormattingEnabled = true;
            this.lbxCourseWindow.Location = new System.Drawing.Point(12, 27);
            this.lbxCourseWindow.Name = "lbxCourseWindow";
            this.lbxCourseWindow.Size = new System.Drawing.Size(312, 186);
            this.lbxCourseWindow.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(118, 231);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 2;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(224, 231);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(224, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 341);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lbxCourseWindow);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmMain";
            this.Text = "Course Booker 9000";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem tspFile;
        private System.Windows.Forms.ToolStripMenuItem tspNew;
        private System.Windows.Forms.ToolStripMenuItem tspOpen;
        private System.Windows.Forms.ToolStripMenuItem tspSave;
        private System.Windows.Forms.ToolStripMenuItem tspExit;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox lbxCourseWindow;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnUpdate;
    }
}

