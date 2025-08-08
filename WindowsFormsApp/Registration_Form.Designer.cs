namespace WindowsFormsApp
{
    partial class Registration_Form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Branch_comboBox = new System.Windows.Forms.ComboBox();
            this.City = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Male_radioButton = new System.Windows.Forms.RadioButton();
            this.Female_radioButton = new System.Windows.Forms.RadioButton();
            this.Register = new System.Windows.Forms.Button();
            this.City_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(72, 41);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 20);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Branch
            // 
            this.Branch.AutoSize = true;
            this.Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Branch.Location = new System.Drawing.Point(72, 132);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(66, 20);
            this.Branch.TabIndex = 4;
            this.Branch.Text = "Branch";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(65, 87);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 17);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // Branch_comboBox
            // 
            this.Branch_comboBox.FormattingEnabled = true;
            this.Branch_comboBox.Items.AddRange(new object[] {
            "Computer Engineering",
            "Information Technology",
            "Civil Engineering",
            "Mecanical Engineering"});
            this.Branch_comboBox.Location = new System.Drawing.Point(157, 134);
            this.Branch_comboBox.Name = "Branch_comboBox";
            this.Branch_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Branch_comboBox.TabIndex = 6;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(72, 182);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(39, 20);
            this.City.TabIndex = 7;
            this.City.Text = "City";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(69, 286);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(69, 20);
            this.Gender.TabIndex = 8;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.label2_Click);
            // 
            // Male_radioButton
            // 
            this.Male_radioButton.AutoSize = true;
            this.Male_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male_radioButton.Location = new System.Drawing.Point(157, 286);
            this.Male_radioButton.Name = "Male_radioButton";
            this.Male_radioButton.Size = new System.Drawing.Size(48, 17);
            this.Male_radioButton.TabIndex = 9;
            this.Male_radioButton.TabStop = true;
            this.Male_radioButton.Text = "Male";
            this.Male_radioButton.UseVisualStyleBackColor = true;
            // 
            // Female_radioButton
            // 
            this.Female_radioButton.AutoSize = true;
            this.Female_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female_radioButton.Location = new System.Drawing.Point(211, 286);
            this.Female_radioButton.Name = "Female_radioButton";
            this.Female_radioButton.Size = new System.Drawing.Size(59, 17);
            this.Female_radioButton.TabIndex = 10;
            this.Female_radioButton.TabStop = true;
            this.Female_radioButton.Text = "Female";
            this.Female_radioButton.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(108, 339);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(120, 31);
            this.Register.TabIndex = 11;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // City_listBox
            // 
            this.City_listBox.FormattingEnabled = true;
            this.City_listBox.Items.AddRange(new object[] {
            "Ahemdabad",
            "Rajkot",
            "Surat"});
            this.City_listBox.Location = new System.Drawing.Point(157, 182);
            this.City_listBox.Name = "City_listBox";
            this.City_listBox.Size = new System.Drawing.Size(120, 95);
            this.City_listBox.TabIndex = 12;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.City_listBox);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Female_radioButton);
            this.Controls.Add(this.Male_radioButton);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Branch_comboBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Branch);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Registration_Form";
            this.Text = "Registration_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Branch;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.ComboBox Branch_comboBox;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.RadioButton Male_radioButton;
        private System.Windows.Forms.RadioButton Female_radioButton;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.ListBox City_listBox;
    }
}