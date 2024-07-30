using scheduler.schedulerDataSetTableAdapters;
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
    public partial class addSchedule : Form
    {
        public addSchedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedulerDataSetTableAdapters.schedulesTableAdapter sch =
                new schedulerDataSetTableAdapters.schedulesTableAdapter();
            sch.GetData();
            schedulerDataSet.schedulesDataTable schTable;
            schTable = sch.GetData();
            int schedID = 0;
            schedID = ((int)schTable.Select().Count<DataRow>()) + 1;

            sch.Insert(schedID, (int) studentComboBox.SelectedValue, (int) roomId.Value, (int) teacherId.SelectedValue, startTime.Value.TimeOfDay, endTime.Value.TimeOfDay);
            this.Close();
        }
    }
}
