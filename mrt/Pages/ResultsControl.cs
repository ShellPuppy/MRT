
using System.Windows.Forms;

namespace mrt
{
    public partial class ResultsControl : UserControl
    {
        public ResultsControl()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
