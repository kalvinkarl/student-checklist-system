namespace StudentsUI
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.reloadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.teachersList = new System.Windows.Forms.ListBox();
            this.teachersLabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.teacherPanel = new System.Windows.Forms.Panel();
            this.teacherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reloadButton.Location = new System.Drawing.Point(332, 34);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(80, 23);
            this.reloadButton.TabIndex = 4;
            this.reloadButton.Text = "reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.Location = new System.Drawing.Point(251, 34);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editButton.Location = new System.Drawing.Point(170, 34);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Location = new System.Drawing.Point(89, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // teachersList
            // 
            this.teachersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teachersList.FormattingEnabled = true;
            this.teachersList.IntegralHeight = false;
            this.teachersList.ItemHeight = 17;
            this.teachersList.Location = new System.Drawing.Point(12, 93);
            this.teachersList.Name = "teachersList";
            this.teachersList.Size = new System.Drawing.Size(477, 331);
            this.teachersList.TabIndex = 8;
            // 
            // teachersLabel
            // 
            this.teachersLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teachersLabel.AutoSize = true;
            this.teachersLabel.Location = new System.Drawing.Point(165, 9);
            this.teachersLabel.Name = "teachersLabel";
            this.teachersLabel.Size = new System.Drawing.Size(168, 17);
            this.teachersLabel.TabIndex = 0;
            this.teachersLabel.Text = "List of teachers";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(249, 3);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(48, 17);
            this.lastLabel.TabIndex = 0;
            this.lastLabel.Text = "Last";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(303, 0);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(112, 24);
            this.lastname.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(1, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(65, 3);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(58, 17);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "First";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(129, 0);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(114, 24);
            this.firstname.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(421, 1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // teacherPanel
            // 
            this.teacherPanel.Controls.Add(this.lastLabel);
            this.teacherPanel.Controls.Add(this.nameLabel);
            this.teacherPanel.Controls.Add(this.lastname);
            this.teacherPanel.Controls.Add(this.saveButton);
            this.teacherPanel.Controls.Add(this.firstname);
            this.teacherPanel.Controls.Add(this.firstLabel);
            this.teacherPanel.Location = new System.Drawing.Point(13, 63);
            this.teacherPanel.Name = "teacherPanel";
            this.teacherPanel.Size = new System.Drawing.Size(476, 24);
            this.teacherPanel.TabIndex = 25;
            this.teacherPanel.Visible = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 445);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.teachersList);
            this.Controls.Add(this.teachersLabel);
            this.Controls.Add(this.teacherPanel);
            this.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(517, 144);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teachers viewer";
            this.teacherPanel.ResumeLayout(false);
            this.teacherPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox teachersList;
        private System.Windows.Forms.Label teachersLabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel teacherPanel;
    }
}