namespace BMS
{
    partial class Admin_Interface
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
            this.CreateStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateStudent
            // 
            this.CreateStudent.Location = new System.Drawing.Point(22, 26);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(269, 121);
            this.CreateStudent.TabIndex = 0;
            this.CreateStudent.Text = "New Student";
            this.CreateStudent.UseVisualStyleBackColor = true;
            this.CreateStudent.Click += new System.EventHandler(this.CreateStudent_Click);
            // 
            // Admin_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateStudent);
            this.Name = "Admin_Interface";
            this.Text = "Admin GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateStudent;
    }
}