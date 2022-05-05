using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSA_Assigments.Entities;

namespace DSA_Assigments
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                if(listBox1.Items.Count > 0)
                {
                    listBox1.Items.Clear();
                }
                string index = textBox1.Text;
                int intIndex = Convert.ToInt32(index);
                intIndex = intIndex - 1;
                Student GETS = Form1.StList.GetElement(intIndex);
                listBox1.Items.Insert(0, GETS);
                
            
            }
            catch(Exception err)
            {
                int len = Form1.StList.Lenght;
                textBox1.Text = "";
                MessageBox.Show($"Please enter the number beetween 1 - {len}");
            }

        }
    }
}
