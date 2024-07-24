using scheduler.schedulerDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace scheduler.Properties
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedulerDataSetTableAdapters.studentsTableAdapter stud =
                new schedulerDataSetTableAdapters.studentsTableAdapter();

            stud.Insert((int) idNumericUpDown.Value, studentNameTextBox.Text, studentSurnameTextBox.Text, emailTextBox.Text, year.SelectedText);
            this.Close();
        }

        
    }
}
