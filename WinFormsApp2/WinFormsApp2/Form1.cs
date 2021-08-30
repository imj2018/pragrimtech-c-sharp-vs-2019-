using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Text = "Click Me";

            //  EventHandler is a delegate pointing to 
            //  the button1_Click function
            //
            //button1.Click += new EventHandler(button1_Click);
            //button1.Click += delegate(object send, EventArgs eventArgs)

            //  as the parameters are not being used there is no need
            //  to use them
            //
            //button1.Click += delegate            

            //  it is automatically inferring the EventHandler delegate
            //        
            //button1.Click += (object eventSender, EventArgs EventArgs) =>

            //  input parameter types are automatically inferred
            // 
            //button1.Click += (eventSender, eventArgs) =>
            
            //  unlike anonymous methods, it won't accept no parameters with lambdas
            //  whether they are omitted in the body or not
            //button1.Click += () =>
            button1.Click += (eventSender, eventArgs) =>
            {
                MessageBox.Show("Hello, you just clicked me");
            };

            Controls.Add(button1);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, you just clicked me");
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hello, you just clicked me");
        //}
    }
}
