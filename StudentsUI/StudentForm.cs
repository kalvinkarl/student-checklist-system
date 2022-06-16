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
    public partial class StudentForm : Form
    {
        public bool UpdateForm { get; set; }
        private List<StudentModel> ListStudents = new List<StudentModel>();
        public StudentForm()
        {
            InitializeComponent();
            //GlobalConfig.IsDark = !GlobalConfig.IsDark;
            GlobalConfig.UseImmersiveDarkMode(Handle, GlobalConfig.IsDark);
            if (GlobalConfig.IsDark)
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                this.BackColor = Color.White;
            }
            Reload();
        }
        private bool ValidateForm()
        {
            bool output = true;
            foreach (Control control in studentPanel.Controls)
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
        private void Reload()
        {
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                if (enrolledCheckbox.Checked && unenrolledCheckbox.Checked)
                {
                    ListStudents = db.GetAllStudents();
                    studentsList.DataSource = ListStudents;
                    studentsList.DisplayMember = "Fullname";
                }
                else if (enrolledCheckbox.Checked)
                {
                    ListStudents = db.GetEnrolled();
                    studentsList.DataSource = ListStudents;
                    studentsList.DisplayMember = "Fullname";
                }
                else if (unenrolledCheckbox.Checked)
                {
                    ListStudents = db.GetUnenrolled();
                    studentsList.DataSource = ListStudents;
                    studentsList.DisplayMember = "Fullname";
                }
                else
                {
                    studentsList.DataSource = null;
                }
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            studentPanel.Visible = !studentPanel.Visible;
            editButton.Enabled = !editButton.Enabled;
        }
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            if (UpdateForm == true)
            {
                addButton.Enabled = false;
                editButton.Enabled = false;
                unenrolledCheckbox.Checked = false;
                unenrolledCheckbox.Visible = false;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StudentModel student = new StudentModel();
                student.StudentID = DateTime.Now.ToString("yyMMdd");
                student.FirstName = firstName.Text;
                student.MiddleName = middleName.Text;
                student.LastName = lastName.Text;
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateStudent(student);
                }
                firstName.Text = "";
                middleName.Text = "";
                lastName.Text = "";
                studentPanel.Visible = !studentPanel.Visible;
                editButton.Enabled = !editButton.Enabled;
                Reload();
            }
            else
            {
                MessageBox.Show("Invalid! try again.");
            }
        }
        private void reloadButton_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void enrolledCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }
        private void unenrolledCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }
        private void studentsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(studentsList.SelectedItems.Count > 0)
            {
                EnrollmentForm enrollmentForm = (EnrollmentForm)this.Owner;
                StudentModel student = (StudentModel)studentsList.SelectedItem;
                enrollmentForm.Enrollment.Student = student;
                Close();
            }
        }

    }
}
