using StudentsLibrary;
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
    public partial class WorkloadForm : Form
    {
        public WorkloadForm()
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
        }

        private void teacherLabel_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.ShowDialog();
        }

        private void subjectLabel_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
