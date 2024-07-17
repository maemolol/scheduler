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
    public partial class addGroup : Form
    {
        public addGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedulerDataSetTableAdapters.groupsTableAdapter grp =
                new schedulerDataSetTableAdapters.groupsTableAdapter();

            grp.Insert((int) studentComboBox.SelectedValue, groupName.Text, (int) groupClassrooms.SelectedValue, groupClasses.Text);
            this.Close();
        }
    }
}
