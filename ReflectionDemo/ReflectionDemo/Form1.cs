using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeName = textBox1.Text;

            Type T = Type.GetType(TypeName);

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            if (T == null)
            {
                return;
            }
            
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                //listBox1.Items.Add(method);
                listBox1.Items.Add(method.ReturnType.Name + " " + method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                listBox2.Items.Add(property.PropertyType + " " + property.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                listBox3.Items.Add(constructor.ToString());
            }

        }
    }
}
