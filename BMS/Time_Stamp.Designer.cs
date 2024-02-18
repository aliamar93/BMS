namespace BMS
{
    partial class Time_Stamp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time_Stamp));
            this.TimeStamp = new System.Windows.Forms.PictureBox();
            this.DCLabel = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValidateLoop = new System.Windows.Forms.Timer(this.components);
            this.HDlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStamp)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeStamp
            // 
            this.TimeStamp.InitialImage = ((System.Drawing.Image)(resources.GetObject("TimeStamp.InitialImage")));
            this.TimeStamp.Location = new System.Drawing.Point(43, 87);
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Size = new System.Drawing.Size(304, 319);
            this.TimeStamp.TabIndex = 0;
            this.TimeStamp.TabStop = false;
            // 
            // DCLabel
            // 
            this.DCLabel.AutoSize = true;
            this.DCLabel.Location = new System.Drawing.Point(568, 209);
            this.DCLabel.Name = "DCLabel";
            this.DCLabel.Size = new System.Drawing.Size(38, 16);
            this.DCLabel.TabIndex = 1;
            this.DCLabel.Text = "Time";
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(529, 157);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(50, 16);
            this.FName.TabIndex = 2;
            this.FName.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // ValidateLoop
            // 
            this.ValidateLoop.Tick += new System.EventHandler(this.ValidateLoop_Tick);
            // 
            // HDlabel
            // 
            this.HDlabel.AutoSize = true;
            this.HDlabel.Location = new System.Drawing.Point(40, 19);
            this.HDlabel.Name = "HDlabel";
            this.HDlabel.Size = new System.Drawing.Size(75, 16);
            this.HDlabel.TabIndex = 4;
            this.HDlabel.Text = "Time In/Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "....";
            // 
            // Time_Stamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HDlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.DCLabel);
            this.Controls.Add(this.TimeStamp);
            this.Name = "Time_Stamp";
            this.Text = "Time_Stamp";
            this.Load += new System.EventHandler(this.Time_Stamp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeStamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TimeStamp;
        private System.Windows.Forms.Label DCLabel;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer ValidateLoop;
        private System.Windows.Forms.Label HDlabel;
        private System.Windows.Forms.Label label1;
    }
}