using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stenographer.Presentation
{
    public partial class PleaseWaitDialog : Form
    {
        private static PleaseWaitDialog dialog;
        private static BackgroundWorker worker;

        private PleaseWaitDialog()
        {
            InitializeComponent();
        }

        public static void Show(MethodInvoker operation, string message)
        {
            dialog = new PleaseWaitDialog();
            dialog.lblLoadInfo.Text = message;

            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += (_, __) => operation();
            worker.RunWorkerCompleted += (_, __) =>
            {
                dialog.Close();
                worker.Dispose();
            };

            worker.RunWorkerAsync();
            dialog.ShowDialog();
        }

        public static void Cancel()
        {
            if (dialog != null)
            {
                dialog.lblLoadInfo.Text = "Cancelling";
                worker.CancelAsync();
            }
        }
    }
}
