namespace AM_Monitor
{
    partial class AM_Monitor
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MysqlStatus = new System.Windows.Forms.Label();
            this.ApacheStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApacheStart = new System.Windows.Forms.Button();
            this.ApacheStop = new System.Windows.Forms.Button();
            this.MysqlStart = new System.Windows.Forms.Button();
            this.MysqlStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MysqlStatus
            // 
            this.MysqlStatus.AutoSize = true;
            this.MysqlStatus.Location = new System.Drawing.Point(62, 39);
            this.MysqlStatus.Name = "MysqlStatus";
            this.MysqlStatus.Size = new System.Drawing.Size(35, 13);
            this.MysqlStatus.TabIndex = 0;
            this.MysqlStatus.Text = "label1";
            // 
            // ApacheStatus
            // 
            this.ApacheStatus.AutoSize = true;
            this.ApacheStatus.Location = new System.Drawing.Point(62, 9);
            this.ApacheStatus.Name = "ApacheStatus";
            this.ApacheStatus.Size = new System.Drawing.Size(35, 13);
            this.ApacheStatus.TabIndex = 1;
            this.ApacheStatus.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apache";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mysql";
            // 
            // ApacheStart
            // 
            this.ApacheStart.Location = new System.Drawing.Point(120, 4);
            this.ApacheStart.Name = "ApacheStart";
            this.ApacheStart.Size = new System.Drawing.Size(38, 22);
            this.ApacheStart.TabIndex = 4;
            this.ApacheStart.Text = "Start";
            this.ApacheStart.UseVisualStyleBackColor = true;
            this.ApacheStart.Click += new System.EventHandler(this.ApacheStart_Click);
            // 
            // ApacheStop
            // 
            this.ApacheStop.Location = new System.Drawing.Point(164, 4);
            this.ApacheStop.Name = "ApacheStop";
            this.ApacheStop.Size = new System.Drawing.Size(38, 22);
            this.ApacheStop.TabIndex = 5;
            this.ApacheStop.Text = "Stop";
            this.ApacheStop.UseVisualStyleBackColor = true;
            this.ApacheStop.Click += new System.EventHandler(this.ApacheStop_Click);
            // 
            // MysqlStart
            // 
            this.MysqlStart.Location = new System.Drawing.Point(120, 34);
            this.MysqlStart.Name = "MysqlStart";
            this.MysqlStart.Size = new System.Drawing.Size(38, 22);
            this.MysqlStart.TabIndex = 6;
            this.MysqlStart.Text = "Start";
            this.MysqlStart.UseVisualStyleBackColor = true;
            this.MysqlStart.Click += new System.EventHandler(this.MysqlStart_Click);
            // 
            // MysqlStop
            // 
            this.MysqlStop.Location = new System.Drawing.Point(164, 34);
            this.MysqlStop.Name = "MysqlStop";
            this.MysqlStop.Size = new System.Drawing.Size(38, 22);
            this.MysqlStop.TabIndex = 7;
            this.MysqlStop.Text = "Stop";
            this.MysqlStop.UseVisualStyleBackColor = true;
            this.MysqlStop.Click += new System.EventHandler(this.MysqlStop_Click);
            // 
            // AM_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 64);
            this.Controls.Add(this.MysqlStop);
            this.Controls.Add(this.MysqlStart);
            this.Controls.Add(this.ApacheStop);
            this.Controls.Add(this.ApacheStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApacheStatus);
            this.Controls.Add(this.MysqlStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AM_Monitor";
            this.ShowIcon = false;
            this.Text = "AM Monitor";
            this.Load += new System.EventHandler(this.AM_Monitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MysqlStatus;
        private System.Windows.Forms.Label ApacheStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApacheStart;
        private System.Windows.Forms.Button ApacheStop;
        private System.Windows.Forms.Button MysqlStart;
        private System.Windows.Forms.Button MysqlStop;
    }
}

