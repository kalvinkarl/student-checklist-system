namespace StudentsUI
{
    partial class EnrollmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollmentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Label();
            this.addSubject = new System.Windows.Forms.Label();
            this.subjectsOfStudentList = new System.Windows.Forms.ListBox();
            this.section = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enrollButton = new System.Windows.Forms.Button();
            this.sectionAuto = new System.Windows.Forms.CheckBox();
            this.workloadButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.studentID = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.removeSubject = new System.Windows.Forms.Label();
            this.darkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section:";
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(103, 35);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(188, 17);
            this.student.TabIndex = 3;
            this.student.Text = "<Choose a Student>";
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // addSubject
            // 
            this.addSubject.AutoSize = true;
            this.addSubject.Location = new System.Drawing.Point(103, 92);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(138, 17);
            this.addSubject.TabIndex = 4;
            this.addSubject.Text = "<Add Subject>";
            this.addSubject.Click += new System.EventHandler(this.addSubject_Click);
            // 
            // subjectsOfStudentList
            // 
            this.subjectsOfStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectsOfStudentList.ForeColor = System.Drawing.Color.Black;
            this.subjectsOfStudentList.FormattingEnabled = true;
            this.subjectsOfStudentList.IntegralHeight = false;
            this.subjectsOfStudentList.ItemHeight = 17;
            this.subjectsOfStudentList.Location = new System.Drawing.Point(12, 123);
            this.subjectsOfStudentList.Name = "subjectsOfStudentList";
            this.subjectsOfStudentList.Size = new System.Drawing.Size(306, 303);
            this.subjectsOfStudentList.TabIndex = 5;
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Location = new System.Drawing.Point(103, 64);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(98, 17);
            this.section.TabIndex = 6;
            this.section.Text = "<Section>";
            this.section.Click += new System.EventHandler(this.section_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject:";
            // 
            // enrollButton
            // 
            this.enrollButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enrollButton.Enabled = false;
            this.enrollButton.Location = new System.Drawing.Point(240, 432);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(78, 23);
            this.enrollButton.TabIndex = 8;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // sectionAuto
            // 
            this.sectionAuto.AutoSize = true;
            this.sectionAuto.Location = new System.Drawing.Point(221, 63);
            this.sectionAuto.Name = "sectionAuto";
            this.sectionAuto.Size = new System.Drawing.Size(107, 21);
            this.sectionAuto.TabIndex = 9;
            this.sectionAuto.Text = "Autofill";
            this.sectionAuto.UseVisualStyleBackColor = true;
            // 
            // workloadButton
            // 
            this.workloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.workloadButton.Location = new System.Drawing.Point(12, 432);
            this.workloadButton.Name = "workloadButton";
            this.workloadButton.Size = new System.Drawing.Size(107, 23);
            this.workloadButton.TabIndex = 10;
            this.workloadButton.Text = "Workloads";
            this.workloadButton.UseVisualStyleBackColor = true;
            this.workloadButton.Click += new System.EventHandler(this.workloadButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(156, 432);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(78, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.Location = new System.Drawing.Point(122, 9);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(48, 17);
            this.studentID.TabIndex = 13;
            this.studentID.Text = "<ID>";
            this.studentID.Click += new System.EventHandler(this.studentID_Click);
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(8, 9);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(108, 17);
            this.studentIdLabel.TabIndex = 12;
            this.studentIdLabel.Text = "StudentID:";
            // 
            // removeSubject
            // 
            this.removeSubject.AutoSize = true;
            this.removeSubject.ForeColor = System.Drawing.Color.Red;
            this.removeSubject.Location = new System.Drawing.Point(239, 92);
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(88, 17);
            this.removeSubject.TabIndex = 14;
            this.removeSubject.Text = "<Remove>";
            this.removeSubject.Click += new System.EventHandler(this.removeSubject_Click);
            // 
            // darkButton
            // 
            this.darkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton.Location = new System.Drawing.Point(124, 432);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(26, 23);
            this.darkButton.TabIndex = 15;
            this.darkButton.Text = "🌙";
            this.darkButton.UseVisualStyleBackColor = true;
            this.darkButton.Click += new System.EventHandler(this.darkButton_Click);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 467);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.removeSubject);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.workloadButton);
            this.Controls.Add(this.sectionAuto);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.section);
            this.Controls.Add(this.subjectsOfStudentList);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.student);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(344, 187);
            this.Name = "EnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label student;
        private System.Windows.Forms.Label addSubject;
        private System.Windows.Forms.ListBox subjectsOfStudentList;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.CheckBox sectionAuto;
        private System.Windows.Forms.Button workloadButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label removeSubject;
        private System.Windows.Forms.Button darkButton;
    }
}