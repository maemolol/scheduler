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

            room.GetData();
            schedulerDataSet.roomsDataTable roomTable;
            roomTable = room.GetData();
            int roomId = 0;
            roomId = ((int) roomTable.Select().Count<DataRow>()) + 1;

            room.Insert(roomId, roomName.Text, classType.Text, (int) capacity.Value, roomFeatures.SelectedText);
            this.Close();
        }
    }
}
