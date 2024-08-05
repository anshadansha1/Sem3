namespace StudentManagementApp
{
    partial class ViewMarksForm
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
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.listBoxMarks = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(229, 149);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(230, 22);
            this.textBoxStudentName.TabIndex = 0;
            // 
            // btnFetch
            // 
            this.btnFetch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.Location = new System.Drawing.Point(465, 141);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(150, 52);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch Marks";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.buttonFetchMarks_Click);
            // 
            // listBoxMarks
            // 
            this.listBoxMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMarks.FormattingEnabled = true;
            this.listBoxMarks.ItemHeight = 25;
            this.listBoxMarks.Location = new System.Drawing.Point(204, 217);
            this.listBoxMarks.Name = "listBoxMarks";
            this.listBoxMarks.Size = new System.Drawing.Size(449, 329);
            this.listBoxMarks.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(630, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewMarksForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(821, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxMarks);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.textBoxStudentName);
            this.Name = "ViewMarksForm";
            this.Text = "View Marks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.ListBox listBoxMarks;
        private System.Windows.Forms.Button button1;
    }
}
