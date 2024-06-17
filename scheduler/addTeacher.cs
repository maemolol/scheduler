using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scheduler
{
    public partial class addTeacher : Form
    {
        public addTeacher()
        {
            InitializeComponent();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            schedulerDataSetTableAdapters.teachersTableAdapter teach =
                new schedulerDataSetTableAdapters.teachersTableAdapter();

            teach.Insert((int) teacherIdNumericUpDown.Value, teacherNameTextBox.Text, teacherSurnameTextBox.Text, teacherEmailTextBox.Text);
        }
    }
}
