namespace ADO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_name = new TextBox();
            label1 = new Label();
            b_register = new Button();
            label2 = new Label();
            tb_age = new TextBox();
            tb_pass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_email = new TextBox();
            b_login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_name
            // 
            tb_name.Location = new Point(642, 85);
            tb_name.Margin = new Padding(5, 4, 5, 4);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(201, 34);
            tb_name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(440, 90);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // b_register
            // 
            b_register.Location = new Point(487, 440);
            b_register.Margin = new Padding(5, 4, 5, 4);
            b_register.Name = "b_register";
            b_register.Size = new Size(153, 41);
            b_register.TabIndex = 2;
            b_register.Text = "Register";
            b_register.UseVisualStyleBackColor = true;
            b_register.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 164);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 3;
            label2.Text = "Age";
            label2.Click += label2_Click;
            // 
            // tb_age
            // 
            tb_age.Location = new Point(642, 161);
            tb_age.Margin = new Padding(5, 4, 5, 4);
            tb_age.Name = "tb_age";
            tb_age.Size = new Size(201, 34);
            tb_age.TabIndex = 4;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(642, 323);
            tb_pass.Margin = new Padding(5, 4, 5, 4);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(201, 34);
            tb_pass.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 329);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(440, 256);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 6;
            label4.Text = "email";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(642, 241);
            tb_email.Margin = new Padding(5, 4, 5, 4);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(201, 34);
            tb_email.TabIndex = 5;
            // 
            // b_login
            // 
            b_login.Location = new Point(669, 440);
            b_login.Margin = new Padding(5, 4, 5, 4);
            b_login.Name = "b_login";
            b_login.Size = new Size(153, 41);
            b_login.TabIndex = 9;
            b_login.Text = "Login";
            b_login.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(75, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 303);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 630);
            Controls.Add(pictureBox1);
            Controls.Add(b_login);
            Controls.Add(tb_pass);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(tb_email);
            Controls.Add(tb_age);
            Controls.Add(label2);
            Controls.Add(b_register);
            Controls.Add(label1);
            Controls.Add(tb_name);
            Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_name;
        private Label label1;
        private Button b_register;
        private Label label2;
        private TextBox tb_age;
        private TextBox tb_pass;
        private Label label3;
        private Label label4;
        private TextBox tb_email;
        private Button b_login;
        private PictureBox pictureBox1;
    }
}
