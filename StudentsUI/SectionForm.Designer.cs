namespace StudentsUI
{
    partial class SectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionForm));
            this.reloadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.sectionsList = new System.Windows.Forms.ListBox();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.sectionPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            this.sectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reloadButton.Location = new System.Drawing.Point(255, 34);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(80, 23);
            this.reloadButton.TabIndex = 4;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.Location = new System.Drawing.Point(174, 34);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editButton.Location = new System.Drawing.Point(93, 34);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Location = new System.Drawing.Point(12, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sectionsList
            // 
            this.sectionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionsList.FormattingEnabled = true;
            this.sectionsList.IntegralHeight = false;
            this.sectionsList.ItemHeight = 17;
            this.sectionsList.Location = new System.Drawing.Point(12, 93);
            this.sectionsList.Name = "sectionsList";
            this.sectionsList.Size = new System.Drawing.Size(323, 254);
            this.sectionsList.TabIndex = 8;
            this.sectionsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sectionsList_MouseDoubleClick);
            // 
            // studentsLabel
            // 
            this.studentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Location = new System.Drawing.Point(88, 9);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(168, 17);
            this.studentsLabel.TabIndex = 0;
            this.studentsLabel.Text = "List of sections";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(66, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(72, 24);
            this.name.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(2, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(144, 3);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(58, 17);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "Size:";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(208, 0);
            this.size.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(54, 24);
            this.size.TabIndex = 6;
            this.size.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(268, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sectionPanel
            // 
            this.sectionPanel.Controls.Add(this.nameLabel);
            this.sectionPanel.Controls.Add(this.saveButton);
            this.sectionPanel.Controls.Add(this.name);
            this.sectionPanel.Controls.Add(this.sizeLabel);
            this.sectionPanel.Controls.Add(this.size);
            this.sectionPanel.Location = new System.Drawing.Point(12, 63);
            this.sectionPanel.Name = "sectionPanel";
            this.sectionPanel.Size = new System.Drawing.Size(323, 24);
            this.sectionPanel.TabIndex = 9;
            this.sectionPanel.Visible = false;
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 368);
            this.Controls.Add(this.sectionPanel);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sectionsList);
            this.Controls.Add(this.studentsLabel);
            this.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(363, 144);
            this.Name = "SectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sections Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            this.sectionPanel.ResumeLayout(false);
            this.sectionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox sectionsList;
        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel sectionPanel;
    }
}