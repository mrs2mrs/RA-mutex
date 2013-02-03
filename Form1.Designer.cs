namespace RicartAgrawala2
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
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.SponsorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sponsorPortTextBox = new System.Windows.Forms.TextBox();
            this.sponsorIPTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.csReqButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.uniqueNameTextBox = new System.Windows.Forms.TextBox();
            this.setNameButton = new System.Windows.Forms.Button();
            this.deadButton = new System.Windows.Forms.Button();
            this.ForceIdle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.delayTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.csTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.availableIPTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nodeListextBox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(18, 105);
            this.IPTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(179, 22);
            this.IPTextBox.TabIndex = 1;
            this.IPTextBox.Text = "127.0.0.1";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(229, 105);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(97, 22);
            this.portTextBox.TabIndex = 2;
            this.portTextBox.Text = "50000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "port";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(349, 100);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(87, 30);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SponsorButton
            // 
            this.SponsorButton.Location = new System.Drawing.Point(349, 295);
            this.SponsorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SponsorButton.Name = "SponsorButton";
            this.SponsorButton.Size = new System.Drawing.Size(85, 30);
            this.SponsorButton.TabIndex = 10;
            this.SponsorButton.Text = "establish";
            this.SponsorButton.UseVisualStyleBackColor = true;
            this.SponsorButton.Click += new System.EventHandler(this.SponsorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP address";
            // 
            // sponsorPortTextBox
            // 
            this.sponsorPortTextBox.Location = new System.Drawing.Point(230, 295);
            this.sponsorPortTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sponsorPortTextBox.Name = "sponsorPortTextBox";
            this.sponsorPortTextBox.Size = new System.Drawing.Size(97, 22);
            this.sponsorPortTextBox.TabIndex = 7;
            this.sponsorPortTextBox.Text = "50001";
            // 
            // sponsorIPTextBox
            // 
            this.sponsorIPTextBox.Location = new System.Drawing.Point(18, 295);
            this.sponsorIPTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sponsorIPTextBox.Name = "sponsorIPTextBox";
            this.sponsorIPTextBox.Size = new System.Drawing.Size(179, 22);
            this.sponsorIPTextBox.TabIndex = 6;
            this.sponsorIPTextBox.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(14, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "sponsor";
            // 
            // csReqButton
            // 
            this.csReqButton.Location = new System.Drawing.Point(466, 56);
            this.csReqButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.csReqButton.Name = "csReqButton";
            this.csReqButton.Size = new System.Drawing.Size(346, 27);
            this.csReqButton.TabIndex = 12;
            this.csReqButton.Text = "request critical section";
            this.csReqButton.UseVisualStyleBackColor = true;
            this.csReqButton.Click += new System.EventHandler(this.csReqButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "unique name";
            // 
            // uniqueNameTextBox
            // 
            this.uniqueNameTextBox.Location = new System.Drawing.Point(18, 185);
            this.uniqueNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uniqueNameTextBox.Name = "uniqueNameTextBox";
            this.uniqueNameTextBox.Size = new System.Drawing.Size(179, 22);
            this.uniqueNameTextBox.TabIndex = 14;
            this.uniqueNameTextBox.Text = "Maria";
            // 
            // setNameButton
            // 
            this.setNameButton.Location = new System.Drawing.Point(349, 185);
            this.setNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setNameButton.Name = "setNameButton";
            this.setNameButton.Size = new System.Drawing.Size(87, 32);
            this.setNameButton.TabIndex = 15;
            this.setNameButton.Text = "set name";
            this.setNameButton.UseVisualStyleBackColor = true;
            this.setNameButton.Click += new System.EventHandler(this.setNameButton_Click);
            // 
            // deadButton
            // 
            this.deadButton.Location = new System.Drawing.Point(466, 98);
            this.deadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deadButton.Name = "deadButton";
            this.deadButton.Size = new System.Drawing.Size(346, 27);
            this.deadButton.TabIndex = 16;
            this.deadButton.Text = "play dead";
            this.deadButton.UseVisualStyleBackColor = true;
            this.deadButton.Click += new System.EventHandler(this.deadButton_Click);
            // 
            // ForceIdle
            // 
            this.ForceIdle.Location = new System.Drawing.Point(21, 346);
            this.ForceIdle.Margin = new System.Windows.Forms.Padding(4);
            this.ForceIdle.Name = "ForceIdle";
            this.ForceIdle.Size = new System.Drawing.Size(173, 28);
            this.ForceIdle.TabIndex = 26;
            this.ForceIdle.Text = "establish Sponsor";
            this.ForceIdle.UseVisualStyleBackColor = true;
            this.ForceIdle.Click += new System.EventHandler(this.ForceIdle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 510);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 524);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "seconds";
            // 
            // delayTextBox
            // 
            this.delayTextBox.Location = new System.Drawing.Point(17, 520);
            this.delayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(79, 22);
            this.delayTextBox.TabIndex = 21;
            this.delayTextBox.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(14, 483);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "network delay";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 437);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "seconds";
            // 
            // csTextBox
            // 
            this.csTextBox.Location = new System.Drawing.Point(18, 434);
            this.csTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.csTextBox.Name = "csTextBox";
            this.csTextBox.Size = new System.Drawing.Size(79, 22);
            this.csTextBox.TabIndex = 17;
            this.csTextBox.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(14, 399);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "critical section time slot";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(13, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "server";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(13, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "presets";
            // 
            // availableIPTextBox
            // 
            this.availableIPTextBox.Location = new System.Drawing.Point(466, 457);
            this.availableIPTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableIPTextBox.Multiline = true;
            this.availableIPTextBox.Name = "availableIPTextBox";
            this.availableIPTextBox.ReadOnly = true;
            this.availableIPTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.availableIPTextBox.Size = new System.Drawing.Size(346, 115);
            this.availableIPTextBox.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(449, 430);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 25);
            this.label15.TabIndex = 19;
            this.label15.Text = "available IP";
            // 
            // nodeListextBox
            // 
            this.nodeListextBox.Location = new System.Drawing.Point(466, 265);
            this.nodeListextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nodeListextBox.Multiline = true;
            this.nodeListextBox.Name = "nodeListextBox";
            this.nodeListextBox.ReadOnly = true;
            this.nodeListextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nodeListextBox.Size = new System.Drawing.Size(346, 147);
            this.nodeListextBox.TabIndex = 18;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(466, 142);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(346, 27);
            this.disconnectButton.TabIndex = 17;
            this.disconnectButton.Text = "disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(449, 222);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "node list";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(449, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "operations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 617);
            this.Controls.Add(this.availableIPTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ForceIdle);
            this.Controls.Add(this.nodeListextBox);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.deadButton);
            this.Controls.Add(this.delayTextBox);
            this.Controls.Add(this.csReqButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sponsorIPTextBox);
            this.Controls.Add(this.csTextBox);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sponsorPortTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uniqueNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setNameButton);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.SponsorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "RA Mutex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button SponsorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sponsorPortTextBox;
        private System.Windows.Forms.TextBox sponsorIPTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button csReqButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uniqueNameTextBox;
        private System.Windows.Forms.Button setNameButton;
        private System.Windows.Forms.Button deadButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox delayTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox csTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button ForceIdle;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox nodeListextBox;
        public System.Windows.Forms.TextBox availableIPTextBox;
        private System.Windows.Forms.Label label15;
    }
}

