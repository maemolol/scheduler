namespace scheduler
{
    partial class addClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classType = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulerDataSet = new scheduler.schedulerDataSet();
            this.addClassB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentsList = new System.Windows.Forms.ComboBox();
            this.groupsTableAdapter = new scheduler.schedulerDataSetTableAdapters.schedulesTableAdapter();
            this.teacherId = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherId)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.className, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.classType, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.addClassB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.studentsList, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.teacherId, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class name";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(80, 3);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(100, 20);
            this.className.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class type:";
            // 
            // classType
            // 
            this.classType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupsBindingSource, "groups", true));
            this.classType.FormattingEnabled = true;
            this.classType.Location = new System.Drawing.Point(253, 3);
            this.classType.Name = "classType";
            this.classType.Size = new System.Drawing.Size(121, 21);
            this.classType.TabIndex = 5;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.schedulerDataSet;
            // 
            // schedulerDataSet
            // 
            this.schedulerDataSet.DataSetName = "schedulerDataSet";
            this.schedulerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addClassB
            // 
            this.addClassB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.addClassB, 4);
            this.addClassB.Location = new System.Drawing.Point(162, 57);
            this.addClassB.Name = "addClassB";
            this.addClassB.Size = new System.Drawing.Size(75, 19);
            this.addClassB.TabIndex = 4;
            this.addClassB.Text = "Add class";
            this.addClassB.UseVisualStyleBackColor = true;
            this.addClassB.Click += new System.EventHandler(this.addClassB_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teacher\'s ID;";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Students:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentsList
            // 
            this.studentsList.FormattingEnabled = true;
            this.studentsList.Location = new System.Drawing.Point(253, 30);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(121, 21);
            this.studentsList.TabIndex = 9;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // teacherId
            // 
            this.teacherId.InterceptArrowKeys = false;
            this.teacherId.Location = new System.Drawing.Point(80, 30);
            this.teacherId.Name = "teacherId";
            this.teacherId.Size = new System.Drawing.Size(103, 20);
            this.teacherId.TabIndex = 10;
            // 
            // addClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 79);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addClass";
            this.Text = "Add class";
            this.Load += new System.EventHandler(this.addClass_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addClassB;
        private schedulerDataSet schedulerDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private schedulerDataSetTableAdapters.schedulesTableAdapter groupsTableAdapter;
        private System.Windows.Forms.ComboBox classType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox studentsList;
        private System.Windows.Forms.NumericUpDown teacherId;
    }
}