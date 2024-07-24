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
    public partial class addClass : Form
    {
        public addClass()
        {
            InitializeComponent();
        }

        private void addClass_Load(object sender, EventArgs e)
        {
            

        }

        private void addClassB_Click(object sender, EventArgs e)
        {
            schedulerDataSetTableAdapters.classesTableAdapter cla =
                new schedulerDataSetTableAdapters.classesTableAdapter();
            cla.GetData();
            schedulerDataSet.classesDataTable claTable;
            claTable = cla.GetData();
            int classID = 0;
            classID = ((int) claTable.Select().Count<DataRow>()) + 1;


            cla.Insert(classID, className.Text, classType.Text, (int) teacherId.Value, (int) studentsList.SelectedValue);
            
            this.Close();
        }
    }
}
