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
    public partial class TeacherForm : Form
    {
        private List<TeacherModel> Teachers = new List<TeacherModel>();
        public TeacherForm()
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
            Reload();
        }
        private bool ValidateForm()
        {
            bool output = true;
            foreach (Control control in teacherPanel.Controls)
            {
                if (control is TextBox textbox)
                {
                    if (textbox.Text == "")
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
                Teachers = db.GetAllTeachers();
                teachersList.DataSource = Teachers;
                teachersList.DisplayMember = "FullName";
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            teacherPanel.Visible = !teacherPanel.Visible;
            editButton.Enabled = !editButton.Enabled;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TeacherModel teacher = new TeacherModel();
                teacher.FirstName = firstname.Text;
                teacher.LastName = lastname.Text;
                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateTeacher(teacher);
                }
                firstname.Text = "";
                lastname.Text = "";
                teacherPanel.Visible = !teacherPanel.Visible;
                editButton.Enabled = !editButton.Enabled;
                Reload();
            }
            else
            {
                MessageBox.Show("Invalid! Try again.");
            }

        }
    }
}
