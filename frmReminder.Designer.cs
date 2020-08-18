namespace RemindMyEyes
{
    partial class frmReminder
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
            this.lbl_TimeRemaining = new System.Windows.Forms.Label();
            this.pb_TimeRemaining = new System.Windows.Forms.ProgressBar();
            this.btn_CancelBreak = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_TimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TimeRemaining
            // 
            this.lbl_TimeRemaining.AutoSize = true;
            this.lbl_TimeRemaining.Location = new System.Drawing.Point(12, 86);
            this.lbl_TimeRemaining.Name = "lbl_TimeRemaining";
            this.lbl_TimeRemaining.Size = new System.Drawing.Size(146, 13);
            this.lbl_TimeRemaining.TabIndex = 0;
            this.lbl_TimeRemaining.Text = "Time remaining of your break ";
            // 
            // pb_TimeRemaining
            // 
            this.pb_TimeRemaining.Location = new System.Drawing.Point(12, 102);
            this.pb_TimeRemaining.Name = "pb_TimeRemaining";
            this.pb_TimeRemaining.Size = new System.Drawing.Size(479, 23);
            this.pb_TimeRemaining.TabIndex = 1;
            this.pb_TimeRemaining.Value = 70;
            // 
            // btn_CancelBreak
            // 
            this.btn_CancelBreak.Location = new System.Drawing.Point(12, 131);
            this.btn_CancelBreak.Name = "btn_CancelBreak";
            this.btn_CancelBreak.Size = new System.Drawing.Size(479, 23);
            this.btn_CancelBreak.TabIndex = 2;
            this.btn_CancelBreak.Text = "Cancel Break";
            this.btn_CancelBreak.UseVisualStyleBackColor = true;
            this.btn_CancelBreak.Click += new System.EventHandler(this.btn_CancelBreak_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_TimeLeft
            // 
            this.lbl_TimeLeft.AutoSize = true;
            this.lbl_TimeLeft.Location = new System.Drawing.Point(164, 86);
            this.lbl_TimeLeft.Name = "lbl_TimeLeft";
            this.lbl_TimeLeft.Size = new System.Drawing.Size(10, 13);
            this.lbl_TimeLeft.TabIndex = 3;
            this.lbl_TimeLeft.Text = "-";
            // 
            // frmReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 233);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_TimeLeft);
            this.Controls.Add(this.btn_CancelBreak);
            this.Controls.Add(this.pb_TimeRemaining);
            this.Controls.Add(this.lbl_TimeRemaining);
            this.Name = "frmReminder";
            this.Text = "Please take a break from your screen now";
            this.Load += new System.EventHandler(this.frmReminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TimeRemaining;
        private System.Windows.Forms.ProgressBar pb_TimeRemaining;
        private System.Windows.Forms.Button btn_CancelBreak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_TimeLeft;
    }
}