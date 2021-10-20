using System;
using System.Threading;
using System.Windows.Forms;

namespace WinFormWaitDialog
{
    public delegate void MethodInvokerWithProgress(IProgress<string> progress);

    public partial class WaitDialog : Form
    {

        private readonly MethodInvokerWithProgress method;

        public WaitDialog(MethodInvokerWithProgress action)
        {
            InitializeComponent();
            method = action;
        }

        public static void InvokeAction(Control control, MethodInvoker action)
        {

            if (control.InvokeRequired)
            {
                control.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }

        private void WaitDialog_Load(object sender, EventArgs e)
        {
            var progress = new Progress<string>(value => {

                lblStatus.Text = value;
            });


            new Thread(() =>
            {
                method.Invoke(progress);
                InvokeAction(this, Dispose);

            }).Start();

        }
    }
}
