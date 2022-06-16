using StudentsLibrary;
using StudentsLibrary.DataAccess;
using StudentsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsUI
{
    public partial class SubjectForm : Form
    {
        public bool WorkloadForm { get; set; }
        private List<SubjectModel> Subjects = new List<SubjectModel>();
        public SubjectForm()
        {
            InitializeComponent();
            GlobalConfig.UseImmersiveDarkMode(Handle, GlobalConfig.IsDark);
            if (GlobalConfig.IsDark)
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                this.BackColor = Color.White;
            }
            LoadDatabase();
        }
        private bool ValidateForm()
        {
            bool output = true;
            foreach (Control control in subjectPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Text == "")
                    {
                        output = false;
                    }
                }
            }
            return output;
        }
        private void LoadDatabase()
        {
            foreach (IDataConnection db in GlobalConfig.Connections)
            { 
                Subjects = db.GetAllSubjects();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            subjectPanel.Visible = !subjectPanel.Visible;
            editButton.Enabled = !editButton.Enabled;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SubjectModel subject = new SubjectModel();
                subject.SubjectCode = subjectCode.Text;
                subject.SubjectTitle = subjectTitle.Text;
                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    Subjects.Add(db.CreateSubject(subject));
                }
                subjectCode.Text = "";
                subjectTitle.Text = "";
                subjectPanel.Visible = !subjectPanel.Visible;
                editButton.Enabled = !editButton.Enabled;
                subjectsList.DataSource = null;
                subjectsList.DataSource = Subjects;
                subjectsList.DisplayMember = "FullSubject";
            }
            else
            {
                MessageBox.Show("Invalid! try again.");
            }
        }

        private void subjectsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            EnrollmentForm enrollmentForm = (EnrollmentForm)this.Owner;
            SubjectModel subject = (SubjectModel)subjectsList.SelectedItem;
            enrollmentForm.Enrollment.Subjects.Add(subject);
            Close();
        }
        private void SubjectForm_Load(object sender, EventArgs e)
        {
            EnrollmentForm enrollmentForm = (EnrollmentForm)this.Owner;
            foreach (SubjectModel enrolledSubject in enrollmentForm.Enrollment.Subjects)
            {
                Subjects = Subjects.Where(subject => subject.ID != enrolledSubject.ID).ToList();
            }
            subjectsList.DataSource = null;
            subjectsList.DataSource = Subjects;
            subjectsList.DisplayMember = "FullSubject";
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            subjectsList.DataSource = null;
            subjectsList.DataSource = Subjects;
            subjectsList.DisplayMember = "FullSubject";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
        }
    }
}
