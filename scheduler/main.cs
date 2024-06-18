using scheduler.Properties;
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
            addGroup addG = new addGroup();
            addG.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about abW = new about();
            abW.Show();
        }
    }
}
