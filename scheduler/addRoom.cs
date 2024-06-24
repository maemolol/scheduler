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
    public partial class addRoom : Form
    {
        public addRoom()
        {
            InitializeComponent();
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            schedulerDataSetTableAdapters.roomsTableAdapter room =
                new schedulerDataSetTableAdapters.roomsTableAdapter();

            room.Insert((int) roomNumberNumericUpDown.Value);
            this.Close();
        }
    }
}
