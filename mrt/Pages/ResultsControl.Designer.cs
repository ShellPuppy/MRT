namespace mrt
{
    partial class ResultsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.PictureGood = new System.Windows.Forms.PictureBox();
            this.PictureBad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No malicious software was detected.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(82, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View detailed results of the scan.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(82, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 92);
            this.label2.TabIndex = 4;
            this.label2.Text = "This tool is not a replacement for an anti-virus product. To help protect your co" +
    "mputer, you should use an anti-virus product. For more information, see";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel2.Location = new System.Drawing.Point(164, 96);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(100, 14);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Protect Your PC.";
            // 
            // PictureGood
            // 
            this.PictureGood.BackColor = System.Drawing.Color.Transparent;
            this.PictureGood.Image = ((System.Drawing.Image)(resources.GetObject("PictureGood.Image")));
            this.PictureGood.Location = new System.Drawing.Point(43, 20);
            this.PictureGood.Name = "PictureGood";
            this.PictureGood.Size = new System.Drawing.Size(33, 36);
            this.PictureGood.TabIndex = 1;
            this.PictureGood.TabStop = false;
            // 
            // PictureBad
            // 
            this.PictureBad.BackColor = System.Drawing.Color.Transparent;
            this.PictureBad.Image = ((System.Drawing.Image)(resources.GetObject("PictureBad.Image")));
            this.PictureBad.Location = new System.Drawing.Point(43, 20);
            this.PictureBad.Name = "PictureBad";
            this.PictureBad.Size = new System.Drawing.Size(33, 36);
            this.PictureBad.TabIndex = 0;
            this.PictureBad.TabStop = false;
            this.PictureBad.Visible = false;
            // 
            // ResultsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureGood);
            this.Controls.Add(this.PictureBad);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(516, 330);
            this.MinimumSize = new System.Drawing.Size(516, 330);
            this.Name = "ResultsControl";
            this.Size = new System.Drawing.Size(516, 330);
            ((System.ComponentModel.ISupportInitialize)(this.PictureGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBad;
        private System.Windows.Forms.PictureBox PictureGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
