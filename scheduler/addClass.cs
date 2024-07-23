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
            cla.Insert(className.Text, classType.Text, (int) teacherId.Value, studentsList.SelectedValue);
            
            this.Close();
        }
    }
}
