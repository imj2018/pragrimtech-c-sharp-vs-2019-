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


/// <summary>
///  unlikely to use any time soon, relearn and comment when needed
/// 
/// 
/// </summary>
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            Thread workerThread = new Thread(DoTimeConsumingWork);
            workerThread.Start();
            //DoTimeConsumingWork();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;


        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
