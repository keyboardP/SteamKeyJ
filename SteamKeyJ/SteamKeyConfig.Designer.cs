namespace SteamKeyJ
{
    partial class SteamKeyConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteamKeyConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlayPause = new System.Windows.Forms.TextBox();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.tbNext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrevious = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVolumeUp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVolumeDown = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tbShuffle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.tbRepeat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play/Pause ";
            // 
            // tbPlayPause
            // 
            this.tbPlayPause.Location = new System.Drawing.Point(91, 46);
            this.tbPlayPause.Name = "tbPlayPause";
            this.tbPlayPause.ReadOnly = true;
            this.tbPlayPause.Size = new System.Drawing.Size(155, 20);
            this.tbPlayPause.TabIndex = 1;
            this.tbPlayPause.Tag = "playpause";
            this.tbPlayPause.Enter += new System.EventHandler(this.textBox_Focus);
            this.tbPlayPause.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Location = new System.Drawing.Point(12, 9);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(0, 13);
            this.lblExplanation.TabIndex = 4;
            // 
            // tbNext
            // 
            this.tbNext.Location = new System.Drawing.Point(91, 72);
            this.tbNext.Name = "tbNext";
            this.tbNext.ReadOnly = true;
            this.tbNext.Size = new System.Drawing.Size(155, 20);
            this.tbNext.TabIndex = 7;
            this.tbNext.Tag = "next";
            this.tbNext.Enter += new System.EventHandler(this.textBox_Focus);
            this.tbNext.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Next";
            // 
            // tbPrevious
            // 
            this.tbPrevious.Location = new System.Drawing.Point(91, 101);
            this.tbPrevious.Name = "tbPrevious";
            this.tbPrevious.ReadOnly = true;
            this.tbPrevious.Size = new System.Drawing.Size(155, 20);
            this.tbPrevious.TabIndex = 9;
            this.tbPrevious.Tag = "previous";
            this.tbPrevious.Enter += new System.EventHandler(this.textBox_Focus);
            this.tbPrevious.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Previous ";
            // 
            // tbVolumeUp
            // 
            this.tbVolumeUp.Location = new System.Drawing.Point(91, 127);
            this.tbVolumeUp.Name = "tbVolumeUp";
            this.tbVolumeUp.ReadOnly = true;
            this.tbVolumeUp.Size = new System.Drawing.Size(155, 20);
            this.tbVolumeUp.TabIndex = 11;
            this.tbVolumeUp.Tag = "volumeup";
            this.tbVolumeUp.Enter += new System.EventHandler(this.textBox_Focus);
            this.tbVolumeUp.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Volume Up";
            // 
            // tbVolumeDown
            // 
            this.tbVolumeDown.Location = new System.Drawing.Point(91, 153);
            this.tbVolumeDown.Name = "tbVolumeDown";
            this.tbVolumeDown.ReadOnly = true;
            this.tbVolumeDown.Size = new System.Drawing.Size(155, 20);
            this.tbVolumeDown.TabIndex = 13;
            this.tbVolumeDown.Tag = "volumedown";
            this.tbVolumeDown.Enter += new System.EventHandler(this.textBox_Focus);
            this.tbVolumeDown.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Volume Down";
            // 
            // tbMute
            // 
            this.tbMute.Location = new System.Drawing.Point(91, 179);
            this.tbMute.Name = "tbMute";
            this.tbMute.ReadOnly = true;
            this.tbMute.Size = new System.Drawing.Size(155, 20);
            this.tbMute.TabIndex = 15;
            this.tbMute.Tag = "mute";
            this.tbMute.Enter += new System.EventHandler(this.textBox_Focus);
            this.tbMute.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mute";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 18;
            this.button1.Tag = "delplaypause";
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 21);
            this.button3.TabIndex = 20;
            this.button3.Tag = "delnext";
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 23);
            this.button4.TabIndex = 21;
            this.button4.Tag = "delprevious";
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(253, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 23);
            this.button5.TabIndex = 22;
            this.button5.Tag = "delvolumeup";
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(253, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 23);
            this.button6.TabIndex = 23;
            this.button6.Tag = "delvolumedown";
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(253, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 23);
            this.button7.TabIndex = 24;
            this.button7.Tag = "delmute";
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(253, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 23);
            this.button8.TabIndex = 27;
            this.button8.Tag = "delshuffle";
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // tbShuffle
            // 
            this.tbShuffle.Location = new System.Drawing.Point(91, 205);
            this.tbShuffle.Name = "tbShuffle";
            this.tbShuffle.ReadOnly = true;
            this.tbShuffle.Size = new System.Drawing.Size(155, 20);
            this.tbShuffle.TabIndex = 26;
            this.tbShuffle.Tag = "shuffle";
            this.tbShuffle.Enter += new System.EventHandler(this.textBox_Focus);
            this.tbShuffle.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Shuffle";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(253, 229);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 23);
            this.button9.TabIndex = 30;
            this.button9.Tag = "delrepeat";
            this.button9.Text = "X";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // tbRepeat
            // 
            this.tbRepeat.Location = new System.Drawing.Point(91, 231);
            this.tbRepeat.Name = "tbRepeat";
            this.tbRepeat.ReadOnly = true;
            this.tbRepeat.Size = new System.Drawing.Size(155, 20);
            this.tbRepeat.TabIndex = 29;
            this.tbRepeat.Tag = "repeat";
            this.tbRepeat.Enter += new System.EventHandler(this.textBox_Focus);
            this.tbRepeat.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Repeat";
            // 
            // SteamKeyConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 300);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tbRepeat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.tbShuffle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbVolumeDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVolumeUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrevious);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.tbPlayPause);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SteamKeyConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SteamKeyJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlayPause;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.TextBox tbNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrevious;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVolumeUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVolumeDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbShuffle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox tbRepeat;
        private System.Windows.Forms.Label label9;
    }
}

