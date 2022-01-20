namespace LoginApp
{
    partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.UserTextBox = new System.Windows.Forms.TextBox();
      this.PassTextBox = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 26);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "Username";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 78);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password";
      // 
      // UserTextBox
      // 
      this.UserTextBox.Location = new System.Drawing.Point(126, 23);
      this.UserTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.UserTextBox.Name = "UserTextBox";
      this.UserTextBox.Size = new System.Drawing.Size(116, 21);
      this.UserTextBox.TabIndex = 2;
      this.UserTextBox.Text = "test";
      // 
      // PassTextBox
      // 
      this.PassTextBox.Location = new System.Drawing.Point(126, 76);
      this.PassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.PassTextBox.Name = "PassTextBox";
      this.PassTextBox.Size = new System.Drawing.Size(116, 21);
      this.PassTextBox.TabIndex = 3;
      this.PassTextBox.Text = "1234";
      // 
      // button1
      // 
      this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
      this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button1.Location = new System.Drawing.Point(155, 124);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(88, 31);
      this.button1.TabIndex = 4;
      this.button1.Text = "       Login";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.PassTextBox);
      this.groupBox1.Controls.Add(this.UserTextBox);
      this.groupBox1.Location = new System.Drawing.Point(316, 120);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.groupBox1.Size = new System.Drawing.Size(258, 161);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Admin";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(14, 106);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(200, 200);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label3.Location = new System.Drawing.Point(130, 8);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(272, 31);
      this.label3.TabIndex = 7;
      this.label3.Text = "University Of Gujrat";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label4.Location = new System.Drawing.Point(237, 46);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(112, 25);
      this.label4.TabIndex = 8;
      this.label4.Text = "Database";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(596, 307);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.groupBox1);
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "Form1";
      this.Text = "UOG-Database";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

