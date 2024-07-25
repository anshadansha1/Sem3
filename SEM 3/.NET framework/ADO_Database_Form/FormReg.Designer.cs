namespace ADO_Database_Form
{
    partial class FormReg
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
            bsubmit = new Button();
            bback = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bsubmit
            // 
            bsubmit.Location = new Point(281, 274);
            bsubmit.Name = "bsubmit";
            bsubmit.Size = new Size(94, 29);
            bsubmit.TabIndex = 0;
            bsubmit.Text = "Submit";
            bsubmit.UseVisualStyleBackColor = true;
            bsubmit.Click += button1_Click;
            // 
            // bback
            // 
            bback.Location = new Point(438, 274);
            bback.Name = "bback";
            bback.Size = new Size(94, 29);
            bback.TabIndex = 1;
            bback.Text = "Back";
            bback.UseVisualStyleBackColor = true;
            bback.Click += bback_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(434, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 124);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 195);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // FormReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(bback);
            Controls.Add(bsubmit);
            Name = "FormReg";
            Text = "FormReg";
            Load += FormReg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bsubmit;
        private Button bback;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}