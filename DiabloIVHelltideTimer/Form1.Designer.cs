namespace DiabloIVHelltideTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLastHelltideMsg = new System.Windows.Forms.Label();
            this.lblHelltideStatusMsg = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblCountdownDisplay = new System.Windows.Forms.Label();
            this.lblLastHelltideDisplay = new System.Windows.Forms.Label();
            this.lblCurrentTimeMsg = new System.Windows.Forms.Label();
            this.lblCurrentTimeDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastHelltideMsg
            // 
            this.lblLastHelltideMsg.AutoSize = true;
            this.lblLastHelltideMsg.Location = new System.Drawing.Point(67, 75);
            this.lblLastHelltideMsg.Name = "lblLastHelltideMsg";
            this.lblLastHelltideMsg.Size = new System.Drawing.Size(116, 13);
            this.lblLastHelltideMsg.TabIndex = 0;
            this.lblLastHelltideMsg.Text = "Last Helltide Start Time";
            // 
            // lblHelltideStatusMsg
            // 
            this.lblHelltideStatusMsg.AutoSize = true;
            this.lblHelltideStatusMsg.Location = new System.Drawing.Point(66, 123);
            this.lblHelltideStatusMsg.Name = "lblHelltideStatusMsg";
            this.lblHelltideStatusMsg.Size = new System.Drawing.Size(117, 13);
            this.lblHelltideStatusMsg.TabIndex = 1;
            this.lblHelltideStatusMsg.Text = "Time Until Next Helltide";
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // lblCountdownDisplay
            // 
            this.lblCountdownDisplay.AutoSize = true;
            this.lblCountdownDisplay.Location = new System.Drawing.Point(263, 122);
            this.lblCountdownDisplay.Name = "lblCountdownDisplay";
            this.lblCountdownDisplay.Size = new System.Drawing.Size(43, 13);
            this.lblCountdownDisplay.TabIndex = 2;
            this.lblCountdownDisplay.Text = "1:15:00";
            // 
            // lblLastHelltideDisplay
            // 
            this.lblLastHelltideDisplay.AutoSize = true;
            this.lblLastHelltideDisplay.Location = new System.Drawing.Point(260, 75);
            this.lblLastHelltideDisplay.Name = "lblLastHelltideDisplay";
            this.lblLastHelltideDisplay.Size = new System.Drawing.Size(49, 13);
            this.lblLastHelltideDisplay.TabIndex = 3;
            this.lblLastHelltideDisplay.Text = "00:00:00";
            // 
            // lblCurrentTimeMsg
            // 
            this.lblCurrentTimeMsg.AutoSize = true;
            this.lblCurrentTimeMsg.Location = new System.Drawing.Point(83, 35);
            this.lblCurrentTimeMsg.Name = "lblCurrentTimeMsg";
            this.lblCurrentTimeMsg.Size = new System.Drawing.Size(67, 13);
            this.lblCurrentTimeMsg.TabIndex = 4;
            this.lblCurrentTimeMsg.Text = "Current Time";
            // 
            // lblCurrentTimeDisplay
            // 
            this.lblCurrentTimeDisplay.AutoSize = true;
            this.lblCurrentTimeDisplay.Location = new System.Drawing.Point(260, 35);
            this.lblCurrentTimeDisplay.Name = "lblCurrentTimeDisplay";
            this.lblCurrentTimeDisplay.Size = new System.Drawing.Size(49, 13);
            this.lblCurrentTimeDisplay.TabIndex = 5;
            this.lblCurrentTimeDisplay.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 369);
            this.Controls.Add(this.lblCurrentTimeDisplay);
            this.Controls.Add(this.lblCurrentTimeMsg);
            this.Controls.Add(this.lblLastHelltideDisplay);
            this.Controls.Add(this.lblCountdownDisplay);
            this.Controls.Add(this.lblHelltideStatusMsg);
            this.Controls.Add(this.lblLastHelltideMsg);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Diablo IV Helltide Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastHelltideMsg;
        private System.Windows.Forms.Label lblHelltideStatusMsg;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblCountdownDisplay;
        private System.Windows.Forms.Label lblLastHelltideDisplay;
        private System.Windows.Forms.Label lblCurrentTimeMsg;
        private System.Windows.Forms.Label lblCurrentTimeDisplay;
    }
}

