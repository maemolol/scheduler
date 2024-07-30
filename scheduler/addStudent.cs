using scheduler.schedulerDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

            stud.GetData();
            schedulerDataSet.studentsDataTable studTable;
            studTable = stud.GetData();
            int studentId = 0;
            studentId = ((int) studTable.Select().Count<DataRow>()) + 1;

            stud.Insert(studentId, studentName.Text, studentYear.SelectedText, studentGroup.SelectedText);
            this.Close();
        }

        
    }
}
