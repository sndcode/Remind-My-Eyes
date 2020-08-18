namespace RemindMyEyes
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.lbl_TimeLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Seconds_Duration = new System.Windows.Forms.TextBox();
            this.txt_Minutes_Duration = new System.Windows.Forms.TextBox();
            this.lbl_Minutes = new System.Windows.Forms.Label();
            this.lbl_Seconds = new System.Windows.Forms.Label();
            this.txt_Seconds_BreakTime = new System.Windows.Forms.TextBox();
            this.lbl_DurationTime = new System.Windows.Forms.Label();
            this.txt_Minutes_BreakTime = new System.Windows.Forms.TextBox();
            this.lbl_BreakTime = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRemindMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.lbl_TimeLeft);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.txt_Seconds_Duration);
            this.grpSettings.Controls.Add(this.txt_Minutes_Duration);
            this.grpSettings.Controls.Add(this.lbl_Minutes);
            this.grpSettings.Controls.Add(this.lbl_Seconds);
            this.grpSettings.Controls.Add(this.txt_Seconds_BreakTime);
            this.grpSettings.Controls.Add(this.lbl_DurationTime);
            this.grpSettings.Controls.Add(this.txt_Minutes_BreakTime);
            this.grpSettings.Controls.Add(this.lbl_BreakTime);
            this.grpSettings.Location = new System.Drawing.Point(12, 33);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(345, 121);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // lbl_TimeLeft
            // 
            this.lbl_TimeLeft.AutoSize = true;
            this.lbl_TimeLeft.Location = new System.Drawing.Point(176, 96);
            this.lbl_TimeLeft.Name = "lbl_TimeLeft";
            this.lbl_TimeLeft.Size = new System.Drawing.Size(31, 13);
            this.lbl_TimeLeft.TabIndex = 8;
            this.lbl_TimeLeft.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time left until next pause :";
            // 
            // txt_Seconds_Duration
            // 
            this.txt_Seconds_Duration.Location = new System.Drawing.Point(241, 35);
            this.txt_Seconds_Duration.Name = "txt_Seconds_Duration";
            this.txt_Seconds_Duration.Size = new System.Drawing.Size(45, 20);
            this.txt_Seconds_Duration.TabIndex = 6;
            this.txt_Seconds_Duration.Text = "10";
            // 
            // txt_Minutes_Duration
            // 
            this.txt_Minutes_Duration.Location = new System.Drawing.Point(179, 35);
            this.txt_Minutes_Duration.Name = "txt_Minutes_Duration";
            this.txt_Minutes_Duration.Size = new System.Drawing.Size(45, 20);
            this.txt_Minutes_Duration.TabIndex = 6;
            this.txt_Minutes_Duration.Text = "0";
            // 
            // lbl_Minutes
            // 
            this.lbl_Minutes.AutoSize = true;
            this.lbl_Minutes.Location = new System.Drawing.Point(176, 16);
            this.lbl_Minutes.Name = "lbl_Minutes";
            this.lbl_Minutes.Size = new System.Drawing.Size(44, 13);
            this.lbl_Minutes.TabIndex = 5;
            this.lbl_Minutes.Text = "Minutes";
            // 
            // lbl_Seconds
            // 
            this.lbl_Seconds.AutoSize = true;
            this.lbl_Seconds.Location = new System.Drawing.Point(237, 16);
            this.lbl_Seconds.Name = "lbl_Seconds";
            this.lbl_Seconds.Size = new System.Drawing.Size(49, 13);
            this.lbl_Seconds.TabIndex = 4;
            this.lbl_Seconds.Text = "Seconds";
            // 
            // txt_Seconds_BreakTime
            // 
            this.txt_Seconds_BreakTime.Location = new System.Drawing.Point(241, 64);
            this.txt_Seconds_BreakTime.Name = "txt_Seconds_BreakTime";
            this.txt_Seconds_BreakTime.Size = new System.Drawing.Size(45, 20);
            this.txt_Seconds_BreakTime.TabIndex = 3;
            this.txt_Seconds_BreakTime.Text = "20";
            // 
            // lbl_DurationTime
            // 
            this.lbl_DurationTime.AutoSize = true;
            this.lbl_DurationTime.Location = new System.Drawing.Point(26, 64);
            this.lbl_DurationTime.Name = "lbl_DurationTime";
            this.lbl_DurationTime.Size = new System.Drawing.Size(106, 13);
            this.lbl_DurationTime.TabIndex = 2;
            this.lbl_DurationTime.Text = "Length of the break :\r\n";
            // 
            // txt_Minutes_BreakTime
            // 
            this.txt_Minutes_BreakTime.Location = new System.Drawing.Point(179, 64);
            this.txt_Minutes_BreakTime.Name = "txt_Minutes_BreakTime";
            this.txt_Minutes_BreakTime.Size = new System.Drawing.Size(45, 20);
            this.txt_Minutes_BreakTime.TabIndex = 1;
            this.txt_Minutes_BreakTime.Text = "0";
            // 
            // lbl_BreakTime
            // 
            this.lbl_BreakTime.AutoSize = true;
            this.lbl_BreakTime.Location = new System.Drawing.Point(26, 38);
            this.lbl_BreakTime.Name = "lbl_BreakTime";
            this.lbl_BreakTime.Size = new System.Drawing.Size(104, 13);
            this.lbl_BreakTime.TabIndex = 0;
            this.lbl_BreakTime.Text = "Take a break after : ";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(93, 160);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 160);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(282, 160);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(201, 160);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.aboutRemindMeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutRemindMeToolStripMenuItem
            // 
            this.aboutRemindMeToolStripMenuItem.Name = "aboutRemindMeToolStripMenuItem";
            this.aboutRemindMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutRemindMeToolStripMenuItem.Text = "About RemindMe";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 200);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Remind Me - Settings";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.TextBox txt_Seconds_Duration;
        private System.Windows.Forms.TextBox txt_Minutes_Duration;
        private System.Windows.Forms.Label lbl_Minutes;
        private System.Windows.Forms.Label lbl_Seconds;
        private System.Windows.Forms.TextBox txt_Seconds_BreakTime;
        private System.Windows.Forms.Label lbl_DurationTime;
        private System.Windows.Forms.TextBox txt_Minutes_BreakTime;
        private System.Windows.Forms.Label lbl_BreakTime;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TimeLeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRemindMeToolStripMenuItem;
    }
}

