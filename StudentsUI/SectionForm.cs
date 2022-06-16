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
    public partial class SectionForm : Form
    {
        private List<SectionModel> Sections = new List<SectionModel>();
        public SectionForm()
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
            foreach (Control control in sectionPanel.Controls)
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
                Sections = db.GetAllSections();
                sectionsList.DataSource = Sections;
                sectionsList.DisplayMember = "FullSection";
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            sectionPanel.Visible = !sectionPanel.Visible;
            editButton.Enabled = !editButton.Enabled;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SectionModel section = new SectionModel();
                section.SectionName = name.Text;
                section.SectionSize = int.Parse(size.Value.ToString());
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateSection(section);
                }
                name.Text = "";
                size.Value = 0;
                sectionPanel.Visible = !sectionPanel.Visible;
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

        private void sectionsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EnrollmentForm enrollmentForm = (EnrollmentForm)this.Owner;
            SectionModel section = (SectionModel)sectionsList.SelectedItem;
            enrollmentForm.Enrollment.Section = section;
            Close();
        }
    }
}
