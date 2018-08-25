namespace mrt
{
    partial class ScanControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFileCount = new System.Windows.Forms.Label();
            this.lbInfectionCount = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbElapsedTime = new System.Windows.Forms.Label();
            this.lbCurrentFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "The tool is scanning your computer for prevalent malicious software, and removing" +
    " any that is found.";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "After this operation completes, the tool will provide you with a report of the ma" +
    "licious software that was detected and removed.";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(43, 105);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(433, 22);
            this.pBar.Step = 1;
            this.pBar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Currently scanning:";
            // 
            // lbFileCount
            // 
            this.lbFileCount.BackColor = System.Drawing.Color.Transparent;
            this.lbFileCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileCount.Location = new System.Drawing.Point(40, 196);
            this.lbFileCount.Name = "lbFileCount";
            this.lbFileCount.Size = new System.Drawing.Size(429, 16);
            this.lbFileCount.TabIndex = 4;
            this.lbFileCount.Text = "Files Scanned:";
            // 
            // lbInfectionCount
            // 
            this.lbInfectionCount.BackColor = System.Drawing.Color.Transparent;
            this.lbInfectionCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfectionCount.Location = new System.Drawing.Point(40, 222);
            this.lbInfectionCount.Name = "lbInfectionCount";
            this.lbInfectionCount.Size = new System.Drawing.Size(429, 16);
            this.lbInfectionCount.TabIndex = 5;
            this.lbInfectionCount.Text = "Files Infected: 0";
            // 
            // lbStartTime
            // 
            this.lbStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lbStartTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartTime.Location = new System.Drawing.Point(40, 248);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(429, 16);
            this.lbStartTime.TabIndex = 6;
            this.lbStartTime.Text = "Start time: 7:20 PM";
            // 
            // lbElapsedTime
            // 
            this.lbElapsedTime.BackColor = System.Drawing.Color.Transparent;
            this.lbElapsedTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElapsedTime.Location = new System.Drawing.Point(40, 274);
            this.lbElapsedTime.Name = "lbElapsedTime";
            this.lbElapsedTime.Size = new System.Drawing.Size(429, 16);
            this.lbElapsedTime.TabIndex = 7;
            this.lbElapsedTime.Text = "Time elapsed: 00:00:14";
            // 
            // lbCurrentFile
            // 
            this.lbCurrentFile.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrentFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentFile.Location = new System.Drawing.Point(40, 170);
            this.lbCurrentFile.Name = "lbCurrentFile";
            this.lbCurrentFile.Size = new System.Drawing.Size(429, 16);
            this.lbCurrentFile.TabIndex = 8;
            this.lbCurrentFile.Text = "C:\\Program Files\\";
            // 
            // ScanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCurrentFile);
            this.Controls.Add(this.lbElapsedTime);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.lbInfectionCount);
            this.Controls.Add(this.lbFileCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(516, 330);
            this.MinimumSize = new System.Drawing.Size(516, 330);
            this.Name = "ScanControl";
            this.Size = new System.Drawing.Size(516, 330);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ProgressBar pBar;
        public System.Windows.Forms.Label lbFileCount;
        public System.Windows.Forms.Label lbInfectionCount;
        public System.Windows.Forms.Label lbStartTime;
        public System.Windows.Forms.Label lbElapsedTime;
        public System.Windows.Forms.Label lbCurrentFile;
    }
}
