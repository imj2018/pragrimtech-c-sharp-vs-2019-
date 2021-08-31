using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader = 
                new StreamReader(@"C:\Users\miral\source\repos\pragrimtech-c-sharp-vs-2019-\WinFormsApp3\WinFormsApp3\Data.ts.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        int characterCount = 0;


        //  "asynchronous implmentation is very with Task compared with Thread"
        // 
        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            //int count = 0;
            Thread thread = new Thread(() => {
                characterCount = CountCharacters();

                //  "the thread that has created the control should only
                //  be modifying it's properties"
                //lblCount.Text = count.ToString() + " characters in file";

                //  BeginInvoke will ask the UI thread to execute asynchronously
                //Action action = () => lblCount.Text = count.ToString() + " characters in file";
                //this.BeginInvoke(action);

                //  re-write as a delegate, that may be easier to read
                Action action = new Action(SetLabelTextProperty);
                this.BeginInvoke(action);


            });
            thread.Start();

            lblCount.Text = "Processing File. Please wait...";
            //thread.Join();
            
        }

        private void SetLabelTextProperty()
        {
            lblCount.Text = characterCount.ToString() + " characters in file";
        }
    }
}
