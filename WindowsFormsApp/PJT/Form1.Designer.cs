namespace WindowsFormsApp.PJT
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
            this.EnrollNo = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Enroll = new System.Windows.Forms.TextBox();
            this.Sage = new System.Windows.Forms.TextBox();
            this.Scity = new System.Windows.Forms.TextBox();
            this.Sname = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnrollNo
            // 
            this.EnrollNo.AutoSize = true;
            this.EnrollNo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EnrollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollNo.Location = new System.Drawing.Point(196, 93);
            this.EnrollNo.Name = "EnrollNo";
            this.EnrollNo.Size = new System.Drawing.Size(70, 17);
            this.EnrollNo.TabIndex = 0;
            this.EnrollNo.Text = "Enroll No.";
            this.EnrollNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(196, 277);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(31, 17);
            this.City.TabIndex = 1;
            this.City.Text = "City";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(196, 213);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(33, 17);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(196, 158);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Form";
            // 
            // Enroll
            // 
            this.Enroll.Location = new System.Drawing.Point(284, 93);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(198, 20);
            this.Enroll.TabIndex = 5;
            this.Enroll.TextChanged += new System.EventHandler(this.Enroll_TextChanged);
            // 
            // Sage
            // 
            this.Sage.Location = new System.Drawing.Point(284, 213);
            this.Sage.Name = "Sage";
            this.Sage.Size = new System.Drawing.Size(198, 20);
            this.Sage.TabIndex = 6;
            this.Sage.TextChanged += new System.EventHandler(this.Sage_TextChanged);
            // 
            // Scity
            // 
            this.Scity.Location = new System.Drawing.Point(284, 277);
            this.Scity.Name = "Scity";
            this.Scity.Size = new System.Drawing.Size(198, 20);
            this.Scity.TabIndex = 7;
            this.Scity.TextChanged += new System.EventHandler(this.Scity_TextChanged);
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(284, 158);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(198, 20);
            this.Sname.TabIndex = 8;
            this.Sname.TextChanged += new System.EventHandler(this.Sname_TextChanged);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(154, 353);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(85, 28);
            this.Insert.TabIndex = 9;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(473, 353);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(85, 28);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(369, 353);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(85, 28);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(269, 353);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(85, 28);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Scity);
            this.Controls.Add(this.Sage);
            this.Controls.Add(this.Enroll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.City);
            this.Controls.Add(this.EnrollNo);
           
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnrollNo;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Age;
        //private System.Windows.Forms.Label Name;
        private new System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Enroll;
        private System.Windows.Forms.TextBox Sage;
        private System.Windows.Forms.TextBox Scity;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Delete;
        //private System.Windows.Forms.Button Update;
        private new System.Windows.Forms.Button Update;
    }
}