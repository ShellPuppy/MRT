namespace mrt
{
    partial class MRTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MRTForm));
            this.lbHeader1 = new System.Windows.Forms.Label();
            this.lbHeader2 = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.resultsControl1 = new mrt.ResultsControl();
            this.optionsControl1 = new mrt.OptionsControl();
            this.startControl1 = new mrt.StartControl();
            this.scanControl1 = new mrt.ScanControl();
            this.SuspendLayout();
            // 
            // lbHeader1
            // 
            this.lbHeader1.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader1.Location = new System.Drawing.Point(19, 9);
            this.lbHeader1.Name = "lbHeader1";
            this.lbHeader1.Size = new System.Drawing.Size(429, 17);
            this.lbHeader1.TabIndex = 1;
            this.lbHeader1.Text = "Welcome to the Microsoft Windows Malicious Software Removal Tool";
            // 
            // lbHeader2
            // 
            this.lbHeader2.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader2.Location = new System.Drawing.Point(40, 24);
            this.lbHeader2.Name = "lbHeader2";
            this.lbHeader2.Size = new System.Drawing.Size(408, 18);
            this.lbHeader2.TabIndex = 2;
            this.lbHeader2.Text = "This tool scans for and automatically removes prevalent malicious software";
            // 
            // cmdBack
            // 
            this.cmdBack.Enabled = false;
            this.cmdBack.Location = new System.Drawing.Point(273, 404);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 23);
            this.cmdBack.TabIndex = 3;
            this.cmdBack.Text = "< &Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(348, 404);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 23);
            this.cmdNext.TabIndex = 4;
            this.cmdNext.Text = "&Next >";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(433, 404);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // resultsControl1
            // 
            this.resultsControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resultsControl1.BackgroundImage")));
            this.resultsControl1.Location = new System.Drawing.Point(0, 60);
            this.resultsControl1.MaximumSize = new System.Drawing.Size(516, 330);
            this.resultsControl1.MinimumSize = new System.Drawing.Size(516, 330);
            this.resultsControl1.Name = "resultsControl1";
            this.resultsControl1.Size = new System.Drawing.Size(516, 330);
            this.resultsControl1.TabIndex = 9;
            this.resultsControl1.Visible = false;
            // 
            // optionsControl1
            // 
            this.optionsControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionsControl1.Location = new System.Drawing.Point(0, 60);
            this.optionsControl1.MaximumSize = new System.Drawing.Size(516, 330);
            this.optionsControl1.MinimumSize = new System.Drawing.Size(516, 330);
            this.optionsControl1.Name = "optionsControl1";
            this.optionsControl1.Size = new System.Drawing.Size(516, 330);
            this.optionsControl1.TabIndex = 8;
            this.optionsControl1.Visible = false;
            // 
            // startControl1
            // 
            this.startControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startControl1.BackgroundImage")));
            this.startControl1.Location = new System.Drawing.Point(0, 60);
            this.startControl1.MaximumSize = new System.Drawing.Size(516, 330);
            this.startControl1.MinimumSize = new System.Drawing.Size(516, 330);
            this.startControl1.Name = "startControl1";
            this.startControl1.Size = new System.Drawing.Size(516, 330);
            this.startControl1.TabIndex = 7;
            // 
            // scanControl1
            // 
            this.scanControl1.Location = new System.Drawing.Point(0, 60);
            this.scanControl1.MaximumSize = new System.Drawing.Size(516, 330);
            this.scanControl1.MinimumSize = new System.Drawing.Size(516, 330);
            this.scanControl1.Name = "scanControl1";
            this.scanControl1.Size = new System.Drawing.Size(516, 330);
            this.scanControl1.TabIndex = 6;
            this.scanControl1.Visible = false;
            // 
            // MRTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mrt.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(518, 437);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.lbHeader2);
            this.Controls.Add(this.lbHeader1);
            this.Controls.Add(this.startControl1);
            this.Controls.Add(this.scanControl1);
            this.Controls.Add(this.resultsControl1);
            this.Controls.Add(this.optionsControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MRTForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Microsoft Windows Malicious Software Removal Tool - Aug. 2018";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MRTForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MRTForm_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeader1;
        private System.Windows.Forms.Label lbHeader2;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdCancel;
        private ScanControl scanControl1;
        private StartControl startControl1;
        private OptionsControl optionsControl1;
        private ResultsControl resultsControl1;
    }
}

