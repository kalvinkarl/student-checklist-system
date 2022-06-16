namespace StudentsUI
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            this.reloadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subjectsList = new System.Windows.Forms.ListBox();
            this.subjectsLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subjectTitle = new System.Windows.Forms.TextBox();
            this.codeTitle = new System.Windows.Forms.Label();
            this.subjectCode = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.subjectPanel = new System.Windows.Forms.Panel();
            this.subjectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reloadButton.Location = new System.Drawing.Point(397, 34);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(80, 23);
            this.reloadButton.TabIndex = 4;
            this.reloadButton.Text = "reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.Location = new System.Drawing.Point(316, 34);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editButton.Location = new System.Drawing.Point(235, 34);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Location = new System.Drawing.Point(154, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subjectsList
            // 
            this.subjectsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectsList.FormattingEnabled = true;
            this.subjectsList.IntegralHeight = false;
            this.subjectsList.ItemHeight = 17;
            this.subjectsList.Location = new System.Drawing.Point(12, 93);
            this.subjectsList.Name = "subjectsList";
            this.subjectsList.Size = new System.Drawing.Size(606, 416);
            this.subjectsList.TabIndex = 8;
            this.subjectsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.subjectsList_MouseDoubleClick);
            // 
            // subjectsLabel
            // 
            this.subjectsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectsLabel.AutoSize = true;
            this.subjectsLabel.Location = new System.Drawing.Point(230, 9);
            this.subjectsLabel.Name = "subjectsLabel";
            this.subjectsLabel.Size = new System.Drawing.Size(168, 17);
            this.subjectsLabel.TabIndex = 0;
            this.subjectsLabel.Text = "List of subjects";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(146, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(68, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // subjectTitle
            // 
            this.subjectTitle.Location = new System.Drawing.Point(220, 1);
            this.subjectTitle.Name = "subjectTitle";
            this.subjectTitle.Size = new System.Drawing.Size(324, 24);
            this.subjectTitle.TabIndex = 6;
            // 
            // codeTitle
            // 
            this.codeTitle.AutoSize = true;
            this.codeTitle.Location = new System.Drawing.Point(1, 4);
            this.codeTitle.Name = "codeTitle";
            this.codeTitle.Size = new System.Drawing.Size(58, 17);
            this.codeTitle.TabIndex = 0;
            this.codeTitle.Text = "Code:";
            // 
            // subjectCode
            // 
            this.subjectCode.Location = new System.Drawing.Point(65, 1);
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.Size = new System.Drawing.Size(75, 24);
            this.subjectCode.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(550, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // subjectPanel
            // 
            this.subjectPanel.Controls.Add(this.titleLabel);
            this.subjectPanel.Controls.Add(this.codeTitle);
            this.subjectPanel.Controls.Add(this.subjectTitle);
            this.subjectPanel.Controls.Add(this.saveButton);
            this.subjectPanel.Controls.Add(this.subjectCode);
            this.subjectPanel.Location = new System.Drawing.Point(13, 62);
            this.subjectPanel.Name = "subjectPanel";
            this.subjectPanel.Size = new System.Drawing.Size(605, 25);
            this.subjectPanel.TabIndex = 22;
            this.subjectPanel.Visible = false;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 530);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subjectsList);
            this.Controls.Add(this.subjectsLabel);
            this.Controls.Add(this.subjectPanel);
            this.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(646, 144);
            this.Name = "SubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Subjects Viewer";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            this.subjectPanel.ResumeLayout(false);
            this.subjectPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox subjectsList;
        private System.Windows.Forms.Label subjectsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox subjectTitle;
        private System.Windows.Forms.Label codeTitle;
        private System.Windows.Forms.TextBox subjectCode;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel subjectPanel;
    }
}