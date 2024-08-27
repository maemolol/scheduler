using scheduler.main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scheduler.algo;
using System.Runtime.InteropServices.ComTypes;
using System.Data.SqlClient;

namespace scheduler.main
{
    public partial class main : Form
    {
        private readonly string conStr = "Server=SLINKYFOX;Database=scheduler;User Id=schedacc;Password=scheduleraccount";

        public main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStudent addS = new addStudent();
            addS.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTeacher addT = new addTeacher();
            addT.Show();
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSchedule addG = new addSchedule();
            addG.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about abW = new about();
            abW.Show();
        }

        private void addClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRoom addR = new addRoom();
            addR.Show();
        }

        private void addStudentLabel_Click(object sender, EventArgs e)
        {
            addStudent addS = new addStudent();
            addS.Show();
        }

        private void addTeacherLabel_Click(object sender, EventArgs e)
        {
            addTeacher addT = new addTeacher();
            addT.Show();
        }

        private void addGroupLabel_Click(object sender, EventArgs e)
        {
            addSchedule addG = new addSchedule();
            addG.Show();
        }

        private void addClassroomLabel_Click(object sender, EventArgs e)
        {
            addRoom addR = new addRoom();
            addR.Show();
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClass addC = new addClass();
            addC.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            addClass addC = new addClass();
            addC.Show();
        }

        private void startSql()
        {
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);

            registerNotification();
        }

        private void registerNotification()
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("select [id], [class_id], [room_id], [teacher_id], [start_time], [end_time] from [scheduler].[schedules]", connection))
                {
                    SqlDependency dependency = new SqlDependency(command);

                    dependency.OnChange += new OnChangeEventHandler(onChange);

                    command.ExecuteReader();
                }
            }
        }

        private void onChange(object sender, SqlNotificationEventArgs e)
        {
            // Get details about the change
            string changeDetails = getDetails();

            // Show a balloon tip notification with change details
            showNotification("Change detected in schedules table: " + changeDetails);

            // Re-register notification
            registerNotification();
        }

        private string getDetails()
        {
            string changeDetails = "No recent changes detected.";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "select top 1 [id], [class_id], [room_id], [teacher_id], [start_time], [end_time] from [dbo].[schedules] order by [id] desc";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int classId = reader.GetInt32(1);
                            int roomId = reader.GetInt32(2);
                            int teacherId = reader.GetInt32(3);
                            DateTime startTime = reader.GetDateTime(4);
                            DateTime endTime = reader.GetDateTime(5);

                            changeDetails = string.Format("ID: {0}, Class: {1}, Room: {2}, Teacher: {3}, Start: {4}, End: {5}",
                                                          id, classId, roomId, teacherId, startTime, endTime);
                        }
                    }
                }
            }

            return changeDetails;
        }

        private void showNotification(string message)
        {
            schChange.BalloonTipText = message;
            schChange.ShowBalloonTip(5000);
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulerDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.schedulerDataSet.classes);
            // TODO: This line of code loads data into the 'schedulerDataSet.schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.schedulerDataSet.schedules);
            startSql();
            //algo.Program sched_algo = new algo.Program();
            //sched_algo();
            string deadline = DateTime.Now.ToString();

            foreach (DataGridViewRow dr in dataGridView1.Rows)
                // runs foreach loop if startdate and enddate are valid
            {
                DateTime startSchedule = (DateTime) dr.Cells["schStartTimeColumn"].Value;
                DateTime endSchedule = (DateTime)dr.Cells["schEndTimeColumn"].Value;
                CurrencyManager schedCurrency = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                if (startSchedule <= endSchedule)// loops through rows of datagridview
                {
                    DateTime deadlineRow = Convert.ToDateTime(deadline); // converts deadline string to datetime and stores in deadlineRow variable

                    if (startSchedule <= deadlineRow && deadlineRow <= endSchedule) // filters deadlines that are => startDate and <= endDate
                    {
                        dr.Visible = true; // display filtered rows here.
                    }
                    else
                    {
                        schedCurrency.SuspendBinding();
                        dr.Visible = false; // hide rows that are not beteen start and end date.
                        schedCurrency.ResumeBinding();
                    }

                }
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlDependency.Stop(conStr);
            schChange.Dispose();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
