namespace StudentManagementApp
{
    partial class AddMarksForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.TextBox textBoxMarks;
        private System.Windows.Forms.Button buttonAddMarks;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelMarks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.textBoxMarks = new System.Windows.Forms.TextBox();
            this.buttonAddMarks = new System.Windows.Forms.Button();
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelMarks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(336, 200);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(200, 24);
            this.comboBoxStudent.TabIndex = 0;
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // textBoxMarks
            // 
            this.textBoxMarks.Location = new System.Drawing.Point(336, 290);
            this.textBoxMarks.Name = "textBoxMarks";
            this.textBoxMarks.Size = new System.Drawing.Size(100, 22);
            this.textBoxMarks.TabIndex = 1;
            // 
            // buttonAddMarks
            // 
            this.buttonAddMarks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMarks.Location = new System.Drawing.Point(235, 394);
            this.buttonAddMarks.Name = "buttonAddMarks";
            this.buttonAddMarks.Size = new System.Drawing.Size(129, 64);
            this.buttonAddMarks.TabIndex = 2;
            this.buttonAddMarks.Text = "Add Marks";
            this.buttonAddMarks.UseVisualStyleBackColor = false;
            this.buttonAddMarks.Click += new System.EventHandler(this.buttonAddMarks_Click);
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudent.Location = new System.Drawing.Point(199, 198);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(79, 22);
            this.labelStudent.TabIndex = 3;
            this.labelStudent.Text = "Student";
            // 
            // labelMarks
            // 
            this.labelMarks.AutoSize = true;
            this.labelMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarks.Location = new System.Drawing.Point(199, 288);
            this.labelMarks.Name = "labelMarks";
            this.labelMarks.Size = new System.Drawing.Size(63, 22);
            this.labelMarks.TabIndex = 4;
            this.labelMarks.Text = "Marks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Marks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject";
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "Python",
            "Android",
            "Data Mining",
            "TOC",
            "Accountancy",
            "Information Security"});
            this.cbSubject.Location = new System.Drawing.Point(336, 248);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(200, 24);
            this.cbSubject.TabIndex = 7;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Go to Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMarksForm
            // 
            this.ClientSize = new System.Drawing.Size(737, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMarks);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.buttonAddMarks);
            this.Controls.Add(this.textBoxMarks);
            this.Controls.Add(this.comboBoxStudent);
            this.Name = "AddMarksForm";
            this.Text = "Add Marks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Button button1;
    }
}
