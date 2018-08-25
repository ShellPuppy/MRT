using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Concurrent;

namespace mrt
{
    public partial class MRTForm : Form
    {

        private int CurrentPage { get; set; }

        private void SetPage(int PageNumber)
        {
            //Limit CurrentPage 
            CurrentPage = Math.Min(3, Math.Max(0, PageNumber));

            //Hide all pages
            startControl1.Visible = false;
            optionsControl1.Visible = false;
            scanControl1.Visible = false;
            resultsControl1.Visible = false;

            //Enable all buttons
            cmdBack.Enabled = true;
            cmdNext.Enabled = true;
            cmdCancel.Enabled = true;

            //Show desired page
            switch (CurrentPage)
            {
                //Start Page
                case 0:
                    cmdBack.Enabled = false;
                    startControl1.Visible = true;
                    lbHeader1.Text = "Welcome to the Microsoft Windows Malicious Software Removal Tool";
                    lbHeader2.Text = "This tool scans for and automatically removes prevalent malicious software";
                    break;
                //Options Page
                case 1:
                    optionsControl1.Visible = true;
                    lbHeader1.Text = "Scan type";
                    lbHeader2.Text = "";
                    break;
                //Scan Page
                case 2:
                    cmdNext.Enabled = false;
                    cmdBack.Enabled = false;
                    scanControl1.Visible = true;
                    lbHeader1.Text = "Scamming your computer";
                    lbHeader2.Text = "";

                    //NormalScan();
                    //ForeverScan();
                    //SuperSlowScan();
                    SuperInfectedScan();
                    //FastScan();

                    break;
                //Results Page
                case 3:
                    cmdCancel.Text = "Finished";
                    cmdNext.Enabled = false;
                    resultsControl1.Visible = true;
                    lbHeader1.Text = "Scan results";
                    lbHeader2.Text = "";
                    break;
            }

        }

        //Next button
        private void cmdNext_Click(object sender, EventArgs e) => SetPage(CurrentPage + 1);

        //Back Button
        private void cmdBack_Click(object sender, EventArgs e) => SetPage(CurrentPage - 1);

        //Cancel/Finish Button
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cancelling Scan. Just Wait A Moment!",
                "Cancel Scan",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }

        //Thread safe collection to store files
        private ConcurrentQueue<string> FilesToScan = new ConcurrentQueue<string>();
        private bool ScanCompleted;

        private void GetFiles(string path = "", int MaxFileCount = 100000, int depth = 0)
        {
            //Search entire c drive
            if (string.IsNullOrEmpty(path)) path = @"c:\";

            try
            {
                foreach (string st in Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly))
                {
                    FilesToScan.Enqueue(st);
                    if (FilesToScan.Count() >= MaxFileCount) return;
                }

                foreach (var directory in Directory.GetDirectories(path))
                {
                    GetFiles(directory, MaxFileCount, depth + 1);
                }

            }
            catch (UnauthorizedAccessException) { }

            //File queue is compelte
            if (depth == 0) ScanCompleted = true;
        }

        private void NormalScan()
        {
            ScanCompleted = false;

            //Get a list of files to 'scan' in a new thread 
            Task.Factory.StartNew(() => GetFiles(@"C:\"));

            DateTime StartTime = DateTime.Now;

            scanControl1.lbStartTime.Text = string.Format("Start time: {0:hh:mm tt}", StartTime);

            this.Refresh();

            int FileCount = 0;

            int InfectedCount = 0;

            while (FilesToScan.Count() > 0 || !ScanCompleted)
            {
                if (FilesToScan.TryDequeue(out string filepath))
                {
                    FileCount++;

                    scanControl1.lbCurrentFile.Text = filepath;

                    scanControl1.lbFileCount.Text = string.Format("Files Scanned: {0}", FileCount);

                    scanControl1.lbInfectionCount.Text = string.Format("Files Infected: {0}", InfectedCount);

                }

                //Elapsed Timer
                scanControl1.lbElapsedTime.Text = string.Format("Time elapsed: {0:hh\\:mm\\:ss}", (StartTime - DateTime.Now));

                Application.DoEvents();

                if (FileCount % 10 == 0)
                {
                    //Refresh the progressbar less often to reduce cpu usage
                    scanControl1.pBar.Maximum = FilesToScan.Count() + FileCount + 10000;
                    scanControl1.pBar.Value = FileCount;
                    Application.DoEvents();
                }
                else { this.Refresh(); }

                //Wait a moment
                System.Threading.Thread.Sleep(10);
            }

            //Show results page
            SetPage(3);
        }

        private void ForeverScan()
        {
            DateTime StartTime = DateTime.Now;

            scanControl1.lbStartTime.Text = string.Format("Start time: {0:hh:mm tt}", StartTime);

            this.Refresh();

            long FileCount = 0;

            long InfectedCount = 0;

            while (true)
            {
                ScanCompleted = false;

                //Get a list of files to 'scan' in a new thread 
                Task.Factory.StartNew(() => GetFiles(@"C:\"));

                scanControl1.pBar.Maximum = 100;

                scanControl1.pBar.Increment(1);

                while (FilesToScan.Count() > 0 || !ScanCompleted)
                {
                    if (FilesToScan.TryDequeue(out string filepath))
                    {
                        FileCount += 1928;

                        scanControl1.lbCurrentFile.Text = filepath;

                        scanControl1.lbFileCount.Text = string.Format("Files Scanned: {0}", FileCount);

                        scanControl1.lbInfectionCount.Text = string.Format("Files Infected: {0}", InfectedCount);

                    }

                    //Elapsed Timer
                    scanControl1.lbElapsedTime.Text = string.Format("Time elapsed: {0:hh\\:mm\\:ss}", (StartTime - DateTime.Now));

                    if (FileCount % 10 == 0)
                        Application.DoEvents();
                    else
                        this.Refresh();

                    //Wait a moment
                    System.Threading.Thread.Sleep(10);
                }

            }

        }

        private void SuperSlowScan()
        {
            //Give it a few days
            Random rnd = new Random();

            ScanCompleted = false;

            //Get a list of files to 'scan' in a new thread 
            Task.Factory.StartNew(() => GetFiles(@"C:\"));

            DateTime StartTime = DateTime.Now;

            scanControl1.lbStartTime.Text = string.Format("Start time: {0:hh:mm tt}", StartTime);

            this.Refresh();

            int FileCount = 0;

            int InfectedCount = 0;

            while (FilesToScan.Count() > 0 || !ScanCompleted)
            {
                if (FilesToScan.TryDequeue(out string filepath))
                {
                    FileCount++;

                    scanControl1.lbCurrentFile.Text = filepath;

                    scanControl1.lbFileCount.Text = string.Format("Files Scanned: {0}", FileCount);

                    scanControl1.lbInfectionCount.Text = string.Format("Files Infected: {0}", InfectedCount);

                    scanControl1.pBar.Maximum = FilesToScan.Count() + FileCount + 10000;
                    scanControl1.pBar.Value = FileCount;
                }


                //Random pause
                for (int i = 0; i < (rnd.Next() % 200) + 1; i++)
                {
                    //Elapsed Timer
                    scanControl1.lbElapsedTime.Text = string.Format("Time elapsed: {0:hh\\:mm\\:ss}", (StartTime - DateTime.Now));

                    Application.DoEvents();

                    System.Threading.Thread.Sleep(10);
                }
            }

            //Show results page
            SetPage(3);
        }

        private void SuperInfectedScan()
        {
            Random rnd = new Random();

            //Countless toejams found
            ScanCompleted = false;

            //Get a list of files to 'scan' in a new thread 
            Task.Factory.StartNew(() => GetFiles(@"C:\"));

            DateTime StartTime = DateTime.Now;

            scanControl1.lbStartTime.Text = string.Format("Start time: {0:hh:mm tt}", StartTime);
 

            this.Refresh();

            int FileCount = 0;

            int InfectedCount = 0;

            while (FilesToScan.Count() > 0 || !ScanCompleted)
            {
                if (FilesToScan.TryDequeue(out string filepath))
                {
                    FileCount++;
                    if (rnd.NextDouble() > .99) InfectedCount++;

                    scanControl1.lbCurrentFile.Text = filepath;

                    scanControl1.lbFileCount.Text = string.Format("Files Scanned: {0}", FileCount);

                    scanControl1.lbInfectionCount.Text = string.Format("Files Infected: {0}", InfectedCount);
                }

                //Make the text red as soon as an infection is found
                if (InfectedCount == 1) scanControl1.lbInfectionCount.ForeColor = Color.DarkRed;

                //Elapsed Timer
                scanControl1.lbElapsedTime.Text = string.Format("Time elapsed: {0:hh\\:mm\\:ss}", (StartTime - DateTime.Now));

                if (FileCount % 10 == 0)
                {
                    //Refresh the progressbar less often to reduce cpu usage
                    scanControl1.pBar.Maximum = FilesToScan.Count() + FileCount + 10000;
                    scanControl1.pBar.Value = FileCount;
                    Application.DoEvents();
                }
                else { this.Refresh(); }

                //Wait a moment
                System.Threading.Thread.Sleep(10);
            }

            //Show results page
            SetPage(3);

        }

        private void FastScan()
        {
            ScanCompleted = false;

            //Get a list of files to 'scan' in a new thread 
            Task.Factory.StartNew(() => GetFiles(@"C:\Windows\assembly\"));

            DateTime StartTime = DateTime.Now;

            scanControl1.lbStartTime.Text = string.Format("Start time: {0:hh:mm tt}", StartTime);

            this.Refresh();

            int FileCount = 0;

            int InfectedCount = 0;

            while (FilesToScan.Count() > 0 || !ScanCompleted)
            {
                if (FilesToScan.TryDequeue(out string filepath))
                {
                    FileCount++;

                    scanControl1.lbCurrentFile.Text = filepath;

                    scanControl1.lbFileCount.Text = string.Format("Files Scanned: {0}", FileCount);

                    scanControl1.lbInfectionCount.Text = string.Format("Files Infected: {0}", InfectedCount);
                }

                //Elapsed Timer
                scanControl1.lbElapsedTime.Text = string.Format("Time elapsed: {0:hh\\:mm\\:ss}", (StartTime - DateTime.Now));

                if (FileCount % 10 == 0)
                {
                    scanControl1.pBar.Maximum = FilesToScan.Count() + FileCount;
                    scanControl1.pBar.Value = FileCount;
                    Application.DoEvents();
                }
                else
                {
                    this.Refresh();
                }

                System.Threading.Thread.Sleep(10);
            }

            //Show results page
            SetPage(3);
        }


        //User is trying to close 
        private void MRTForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(
                "Warning, cancelling scan now may cause your Windows license key to expire!",
                "Cancel Scan",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Information);

            e.Cancel = true;
        }

        //Secret abort key - PageUp instantly closes
        private void MRTForm_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp) Environment.Exit(0);
        }

        public MRTForm()
        {
            InitializeComponent();

            //Show the start page
            SetPage(0);
        }


    }
}
