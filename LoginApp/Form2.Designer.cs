namespace LoginApp
{
    partial class Form2
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.IdTextBox = new System.Windows.Forms.TextBox();
      this.NameTextBox = new System.Windows.Forms.TextBox();
      this.FnameTextBox = new System.Windows.Forms.TextBox();
      this.AgeTextBox = new System.Windows.Forms.TextBox();
      this.SemesterTextBox = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button4 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 21);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(16, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 54);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "Name";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 85);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "Fathe Name";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 120);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(27, 12);
      this.label4.TabIndex = 3;
      this.label4.Text = "Age";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 153);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(59, 12);
      this.label5.TabIndex = 4;
      this.label5.Text = "Semester";
      // 
      // IdTextBox
      // 
      this.IdTextBox.Location = new System.Drawing.Point(188, 18);
      this.IdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.IdTextBox.Name = "IdTextBox";
      this.IdTextBox.Size = new System.Drawing.Size(116, 21);
      this.IdTextBox.TabIndex = 5;
      // 
      // NameTextBox
      // 
      this.NameTextBox.Location = new System.Drawing.Point(188, 52);
      this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.NameTextBox.Name = "NameTextBox";
      this.NameTextBox.Size = new System.Drawing.Size(116, 21);
      this.NameTextBox.TabIndex = 6;
      // 
      // FnameTextBox
      // 
      this.FnameTextBox.Location = new System.Drawing.Point(188, 85);
      this.FnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.FnameTextBox.Name = "FnameTextBox";
      this.FnameTextBox.Size = new System.Drawing.Size(116, 21);
      this.FnameTextBox.TabIndex = 7;
      // 
      // AgeTextBox
      // 
      this.AgeTextBox.Location = new System.Drawing.Point(188, 117);
      this.AgeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.AgeTextBox.Name = "AgeTextBox";
      this.AgeTextBox.Size = new System.Drawing.Size(116, 21);
      this.AgeTextBox.TabIndex = 8;
      // 
      // SemesterTextBox
      // 
      this.SemesterTextBox.Location = new System.Drawing.Point(188, 150);
      this.SemesterTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.SemesterTextBox.Name = "SemesterTextBox";
      this.SemesterTextBox.Size = new System.Drawing.Size(116, 21);
      this.SemesterTextBox.TabIndex = 9;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(7, 14);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(106, 21);
      this.button1.TabIndex = 10;
      this.button1.Text = "Save Data";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.Location = new System.Drawing.Point(120, 14);
      this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(106, 21);
      this.button2.TabIndex = 11;
      this.button2.Text = "Update Data";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(7, 66);
      this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(106, 21);
      this.button3.TabIndex = 12;
      this.button3.Text = "Delete Data";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(495, 69);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(636, 312);
      this.dataGridView1.TabIndex = 13;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(120, 66);
      this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(106, 21);
      this.button4.TabIndex = 14;
      this.button4.Text = "Show Data";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.AgeTextBox);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.SemesterTextBox);
      this.groupBox1.Controls.Add(this.IdTextBox);
      this.groupBox1.Controls.Add(this.NameTextBox);
      this.groupBox1.Controls.Add(this.FnameTextBox);
      this.groupBox1.Location = new System.Drawing.Point(40, 69);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.groupBox1.Size = new System.Drawing.Size(326, 183);
      this.groupBox1.TabIndex = 15;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add Student Data";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.button4);
      this.groupBox2.Controls.Add(this.button1);
      this.groupBox2.Controls.Add(this.button2);
      this.groupBox2.Controls.Add(this.button3);
      this.groupBox2.Location = new System.Drawing.Point(40, 289);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.groupBox2.Size = new System.Drawing.Size(233, 92);
      this.groupBox2.TabIndex = 16;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Choice";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.Violet;
      this.label6.Location = new System.Drawing.Point(40, 30);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(192, 31);
      this.label6.TabIndex = 17;
      this.label6.Text = "Adding Section";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.Violet;
      this.label7.Location = new System.Drawing.Point(673, 30);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(241, 31);
      this.label7.TabIndex = 18;
      this.label7.Text = "Student Information";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(1167, 414);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dataGridView1);
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "Form2";
      this.Text = "UOG-Database";
      this.Load += new System.EventHandler(this.Form2_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox SemesterTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}