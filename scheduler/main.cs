﻿using scheduler.Properties;
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
    public partial class main : Form
    {
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

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulerDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.schedulerDataSet.classes);
            // TODO: This line of code loads data into the 'schedulerDataSet.schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.schedulerDataSet.schedules);


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
