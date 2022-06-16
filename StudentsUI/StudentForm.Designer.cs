namespace StudentsUI
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.studentsLabel = new System.Windows.Forms.Label();
            this.studentsList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.firstLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.middleLabel = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.TextBox();
            this.lastLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.enrolledCheckbox = new System.Windows.Forms.CheckBox();
            this.unenrolledCheckbox = new System.Windows.Forms.CheckBox();
            this.studentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsLabel
            // 
            this.studentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Location = new System.Drawing.Point(273, 9);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(168, 17);
            this.studentsLabel.TabIndex = 0;
            this.studentsLabel.Text = "List of students";
            // 
            // studentsList
            // 
            this.studentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsList.FormattingEnabled = true;
            this.studentsList.IntegralHeight = false;
            this.studentsList.ItemHeight = 17;
            this.studentsList.Location = new System.Drawing.Point(12, 93);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(692, 503);
            this.studentsList.TabIndex = 9;
            this.studentsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentsList_MouseDoubleClick);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Location = new System.Drawing.Point(197, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editButton.Location = new System.Drawing.Point(278, 34);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.Location = new System.Drawing.Point(359, 34);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reloadButton.Location = new System.Drawing.Point(440, 34);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(80, 23);
            this.reloadButton.TabIndex = 4;
            this.reloadButton.Text = "reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(64, 6);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(58, 17);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "First";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(128, 3);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(114, 24);
            this.firstName.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(634, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // middleLabel
            // 
            this.middleLabel.AutoSize = true;
            this.middleLabel.Location = new System.Drawing.Point(248, 6);
            this.middleLabel.Name = "middleLabel";
            this.middleLabel.Size = new System.Drawing.Size(68, 17);
            this.middleLabel.TabIndex = 0;
            this.middleLabel.Text = "Middle";
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(322, 3);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(134, 24);
            this.middleName.TabIndex = 6;
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(462, 6);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(48, 17);
            this.lastLabel.TabIndex = 0;
            this.lastLabel.Text = "Last";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(516, 3);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(112, 24);
            this.lastName.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(0, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.middleName);
            this.studentPanel.Controls.Add(this.lastLabel);
            this.studentPanel.Controls.Add(this.saveButton);
            this.studentPanel.Controls.Add(this.lastName);
            this.studentPanel.Controls.Add(this.firstName);
            this.studentPanel.Controls.Add(this.middleLabel);
            this.studentPanel.Controls.Add(this.firstLabel);
            this.studentPanel.Controls.Add(this.nameLabel);
            this.studentPanel.Location = new System.Drawing.Point(12, 60);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(692, 31);
            this.studentPanel.TabIndex = 17;
            this.studentPanel.Visible = false;
            // 
            // enrolledCheckbox
            // 
            this.enrolledCheckbox.AutoSize = true;
            this.enrolledCheckbox.Checked = true;
            this.enrolledCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enrolledCheckbox.Location = new System.Drawing.Point(12, 9);
            this.enrolledCheckbox.Name = "enrolledCheckbox";
            this.enrolledCheckbox.Size = new System.Drawing.Size(107, 21);
            this.enrolledCheckbox.TabIndex = 18;
            this.enrolledCheckbox.Text = "Enrolled";
            this.enrolledCheckbox.UseVisualStyleBackColor = true;
            this.enrolledCheckbox.CheckedChanged += new System.EventHandler(this.enrolledCheckbox_CheckedChanged);
            // 
            // unenrolledCheckbox
            // 
            this.unenrolledCheckbox.AutoSize = true;
            this.unenrolledCheckbox.Checked = true;
            this.unenrolledCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.unenrolledCheckbox.Location = new System.Drawing.Point(12, 36);
            this.unenrolledCheckbox.Name = "unenrolledCheckbox";
            this.unenrolledCheckbox.Size = new System.Drawing.Size(127, 21);
            this.unenrolledCheckbox.TabIndex = 18;
            this.unenrolledCheckbox.Text = "Unenrolled";
            this.unenrolledCheckbox.UseVisualStyleBackColor = true;
            this.unenrolledCheckbox.CheckedChanged += new System.EventHandler(this.unenrolledCheckbox_CheckedChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 617);
            this.Controls.Add(this.unenrolledCheckbox);
            this.Controls.Add(this.enrolledCheckbox);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.studentsLabel);
            this.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(732, 144);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Students Viewer";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label middleLabel;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.CheckBox enrolledCheckbox;
        private System.Windows.Forms.CheckBox unenrolledCheckbox;
    }
}

