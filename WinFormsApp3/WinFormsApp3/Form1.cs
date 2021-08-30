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

        //  blocking i.e during execution we cannot see the status message, move
        //  the text box around etc 
        // 
        //private void btnProcessFile_Click(object sender, EventArgs e)

        //  non blocking i.e async to call the method asynchronously  
        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            //  Task to offload the CountCharacters which will execute the method
            // 
            Task<int> task = new Task<int>(CountCharacters);
            task.Start(); 

            lblCount.Text = "Processing File. Please wait...";

            //int count = CountCharacters();

            //  await as we need to wait for the task to complete at this points
            //  then return
            // 
            //  "await keyword specifies a suspension point, the await operator signals
            //  that the async method can't continue passed that point until the awaited
            //  process is complete. In the meantime control returns to caller of the async
            //  method"
            // 
            int count = await task;

            lblCount.Text = count.ToString() + " characters in file";
        }
    }
}
