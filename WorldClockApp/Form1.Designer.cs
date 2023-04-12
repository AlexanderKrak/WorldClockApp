namespace WorldClockApp
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblMoscowTime = new System.Windows.Forms.Label();
            this.lblLondonTime = new System.Windows.Forms.Label();
            this.lblNewYorkTime = new System.Windows.Forms.Label();
            this.lblTokyoTime = new System.Windows.Forms.Label();
            this.lblTimeTokyo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoscow = new System.Windows.Forms.Label();
            this.lblLondon = new System.Windows.Forms.Label();
            this.lblNewYork = new System.Windows.Forms.Label();
            this.lblTokyo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblGraz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.lblGraz);
            this.splitContainer1.Panel1.Controls.Add(this.lblTimeNow);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Firebrick;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.lblMoscowTime);
            this.splitContainer1.Panel2.Controls.Add(this.lblLondonTime);
            this.splitContainer1.Panel2.Controls.Add(this.lblNewYorkTime);
            this.splitContainer1.Panel2.Controls.Add(this.lblTokyoTime);
            this.splitContainer1.Panel2.Controls.Add(this.lblTimeTokyo);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lblMoscow);
            this.splitContainer1.Panel2.Controls.Add(this.lblLondon);
            this.splitContainer1.Panel2.Controls.Add(this.lblNewYork);
            this.splitContainer1.Panel2.Controls.Add(this.lblTokyo);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeNow.Location = new System.Drawing.Point(280, 98);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(188, 49);
            this.lblTimeNow.TabIndex = 0;
            this.lblTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoscowTime
            // 
            this.lblMoscowTime.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoscowTime.Location = new System.Drawing.Point(600, 138);
            this.lblMoscowTime.Name = "lblMoscowTime";
            this.lblMoscowTime.Size = new System.Drawing.Size(188, 49);
            this.lblMoscowTime.TabIndex = 14;
            this.lblMoscowTime.Text = "MoscowTick";
            this.lblMoscowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLondonTime
            // 
            this.lblLondonTime.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLondonTime.Location = new System.Drawing.Point(9, 135);
            this.lblLondonTime.Name = "lblLondonTime";
            this.lblLondonTime.Size = new System.Drawing.Size(188, 49);
            this.lblLondonTime.TabIndex = 13;
            this.lblLondonTime.Text = "LondonTick";
            this.lblLondonTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewYorkTime
            // 
            this.lblNewYorkTime.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewYorkTime.Location = new System.Drawing.Point(600, 48);
            this.lblNewYorkTime.Name = "lblNewYorkTime";
            this.lblNewYorkTime.Size = new System.Drawing.Size(188, 49);
            this.lblNewYorkTime.TabIndex = 12;
            this.lblNewYorkTime.Text = "New YorkTick";
            this.lblNewYorkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTokyoTime
            // 
            this.lblTokyoTime.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTokyoTime.Location = new System.Drawing.Point(9, 48);
            this.lblTokyoTime.Name = "lblTokyoTime";
            this.lblTokyoTime.Size = new System.Drawing.Size(188, 49);
            this.lblTokyoTime.TabIndex = 1;
            this.lblTokyoTime.Text = "TokyoTick";
            this.lblTokyoTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeTokyo
            // 
            this.lblTimeTokyo.AutoSize = true;
            this.lblTimeTokyo.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeTokyo.Location = new System.Drawing.Point(3, 138);
            this.lblTimeTokyo.Name = "lblTimeTokyo";
            this.lblTimeTokyo.Size = new System.Drawing.Size(0, 42);
            this.lblTimeTokyo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 42);
            this.label1.TabIndex = 9;
            // 
            // lblMoscow
            // 
            this.lblMoscow.AutoSize = true;
            this.lblMoscow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoscow.Location = new System.Drawing.Point(669, 109);
            this.lblMoscow.Name = "lblMoscow";
            this.lblMoscow.Size = new System.Drawing.Size(86, 25);
            this.lblMoscow.TabIndex = 8;
            this.lblMoscow.Text = "Moscow";
            this.lblMoscow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLondon
            // 
            this.lblLondon.AutoSize = true;
            this.lblLondon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLondon.Location = new System.Drawing.Point(26, 109);
            this.lblLondon.Name = "lblLondon";
            this.lblLondon.Size = new System.Drawing.Size(82, 25);
            this.lblLondon.TabIndex = 7;
            this.lblLondon.Text = "London";
            this.lblLondon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewYork
            // 
            this.lblNewYork.AutoSize = true;
            this.lblNewYork.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewYork.Location = new System.Drawing.Point(669, 11);
            this.lblNewYork.Name = "lblNewYork";
            this.lblNewYork.Size = new System.Drawing.Size(98, 25);
            this.lblNewYork.TabIndex = 6;
            this.lblNewYork.Text = "New York";
            this.lblNewYork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTokyo
            // 
            this.lblTokyo.AutoSize = true;
            this.lblTokyo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTokyo.Location = new System.Drawing.Point(38, 11);
            this.lblTokyo.Name = "lblTokyo";
            this.lblTokyo.Size = new System.Drawing.Size(66, 25);
            this.lblTokyo.TabIndex = 5;
            this.lblTokyo.Text = "Tokyo";
            this.lblTokyo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(596, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            // 
            // lblGraz
            // 
            this.lblGraz.AutoSize = true;
            this.lblGraz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGraz.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGraz.Location = new System.Drawing.Point(359, 73);
            this.lblGraz.Name = "lblGraz";
            this.lblGraz.Size = new System.Drawing.Size(53, 25);
            this.lblGraz.TabIndex = 15;
            this.lblGraz.Text = "Graz";
            this.lblGraz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form";
            this.Text = "World Clock";
            this.Load += new System.EventHandler(this.Form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblTimeNow;
        private System.Windows.Forms.Timer timer;
        private CheckedListBox checkedListBox1;
        private Label lblMoscow;
        private Label lblLondon;
        private Label lblNewYork;
        private Label lblTokyo;
        private Label lblTimeTokyo;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label lblMoscowTime;
        private Label lblLondonTime;
        private Label lblNewYorkTime;
        private Label lblTokyoTime;
        private Label lblGraz;
    }
}