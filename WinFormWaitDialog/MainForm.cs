using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWaitDialog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStatTask_Click(object sender, EventArgs e)
        {

            new WaitDialog((IProgress<string> progress) =>
            {
                LongRunningProcess(progress);

            }).ShowDialog();
        }


        private void LongRunningProcess(IProgress<string> progress ) {

            for (int i = 0; i < 100; i++)
            {
                progress.Report($"Doing something {i}");
                Thread.Sleep(100);
            }
        }


    }
}
