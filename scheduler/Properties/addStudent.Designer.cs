namespace scheduler.Properties
{
    partial class addStudent
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            studentNameTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            studentSurnameTextBox = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(studentNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(studentSurnameTextBox, 3, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(530, 107);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 19);
            label1.TabIndex = 0;
            label1.Text = "Student's name:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new System.Drawing.Point(131, 3);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new System.Drawing.Size(115, 26);
            studentNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(276, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 19);
            label2.TabIndex = 2;
            label2.Text = "Student's surname:";
            // 
            // studentSurnameTextBox
            // 
            studentSurnameTextBox.Location = new System.Drawing.Point(408, 3);
            studentSurnameTextBox.Name = "studentSurnameTextBox";
            studentSurnameTextBox.Size = new System.Drawing.Size(115, 26);
            studentSurnameTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(131, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(139, 27);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 39);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(122, 19);
            label3.TabIndex = 5;
            label3.Text = "Student's class(es):";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(295, 39);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 19);
            label4.TabIndex = 6;
            label4.Text = "Student's ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(408, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(115, 26);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(button1, 4);
            button1.Location = new System.Drawing.Point(217, 71);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(95, 29);
            button1.TabIndex = 8;
            button1.Text = "Add student";
            button1.UseVisualStyleBackColor = true;
            // 
            // addStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(530, 107);
            Controls.Add(tableLayoutPanel1);
            Name = "addStudent";
            Text = "Add student";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentSurnameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}