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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string index = textBox1.Text;
                int intIndex = Convert.ToInt32(index);
                intIndex = intIndex - 1;
                Student rs = Form1.StList.RemoveByIndex(intIndex);
                MessageBox.Show($"Student: {rs} was succesfully removed");
                this.Close();



            }
            catch (Exception err)
            {
                int len = Form1.StList.Lenght;
                textBox1.Text = "";
                MessageBox.Show($"Please enter the number beetween 1 - {len}");
            }
        }
    }
}
