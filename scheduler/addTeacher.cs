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

            teach.GetData();
            schedulerDataSet.teachersDataTable teachTable;
            teachTable = teach.GetData();
            int teacherId = 0;
            teacherId = ((int) teachTable.Select().Count<DataRow>()) + 1;

            teach.Insert(teacherId, teacherName.Text, teacherAvailability.Value.TimeOfDay, teacherSpec.Text);
            this.Close();
        }
    }
}
