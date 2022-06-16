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
    public partial class EnrollmentForm : Form
    {
        public EnrollmentModel Enrollment { get; set; } = new EnrollmentModel();
        public EnrollmentForm()
        {
            InitializeComponent();
        }
        private bool CheckEnrolled(int ID)
        {
            List<StudentModel> enrolledStudents = new List<StudentModel>();
            bool AlreadyEnrolled = false;
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                enrolledStudents = db.GetEnrolled();
            }
            foreach (StudentModel enrolledStudent in enrolledStudents)
            {
                if (enrolledStudent.ID == ID)
                {
                    AlreadyEnrolled = true;
                }
            }
            return AlreadyEnrolled;
        }
        private void LoadForm()
        {
            if (Enrollment.Student != null)
            {
                student.Text = Enrollment.Student.Fullname;
                studentID.Text = $"{Enrollment.Student.ID}-{Enrollment.Student.StudentID}";
                if (CheckEnrolled(Enrollment.Student.ID))
                {
                    foreach (IDataConnection db in GlobalConfig.Connections)
                    {
                        Enrollment = db.GetEnrollmentByStudent(Enrollment.Student.ID);
                        Reload();
                    }
                    section.Text = Enrollment.Section.SectionName;
                    updateButton.Enabled = true;
                    enrollButton.Enabled = false;
                }
                else
                {
                    updateButton.Enabled = false;
                    enrollButton.Enabled = true;
                }
            }
        }
        private void Reload()
        {
            subjectsOfStudentList.DataSource = null;
            subjectsOfStudentList.DataSource = Enrollment.Subjects;
            subjectsOfStudentList.DisplayMember = "FullSubject";
        }
        private void darkButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.IsDark = !GlobalConfig.IsDark;
            GlobalConfig.UseImmersiveDarkMode(Handle, GlobalConfig.IsDark);
            if (GlobalConfig.IsDark)
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                this.BackColor = Color.White;
            }
            this.Refresh();
        }
        private void studentID_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog(this);
            LoadForm();
        }
        private void student_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog(this);
            LoadForm();
        }

        private void section_Click(object sender, EventArgs e)
        {
            SectionForm sectionForm = new SectionForm();
            sectionForm.ShowDialog(this);
            if(Enrollment.Section != null)
            {
                section.Text = Enrollment.Section.SectionName;
            }
            
        }

        private void addSubject_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog(this);
            Reload();
        }
        private void removeSubject_Click(object sender, EventArgs e)
        {
            SubjectModel sub = (SubjectModel)subjectsOfStudentList.SelectedItem;
            Enrollment.Subjects.Remove(sub);
            Reload();
        }
        private void workloadButton_Click(object sender, EventArgs e)
        {
            WorkloadForm workloadForm = new WorkloadForm();
            workloadForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (Enrollment.Student == null)
            {
                StudentForm studentForm = new StudentForm();
                studentForm.UpdateForm = true;
                studentForm.ShowDialog(this);
                LoadForm();
            }
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            if(Enrollment.Student == null)
            {
                MessageBox.Show("Select the student you want to enroll","Student Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else if(Enrollment.Section == null)
            {
                MessageBox.Show($"Choose a section for {Enrollment.Student.Fullname}", "Blank section", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateEnrollment(Enrollment);
                }
                enrollButton.Enabled = false;
                updateButton.Enabled = true;
                MessageBox.Show($"Successfully enrolled {Enrollment.Student.Fullname} to {Enrollment.Section.SectionName}", "New record found!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }

        }
    }
}
