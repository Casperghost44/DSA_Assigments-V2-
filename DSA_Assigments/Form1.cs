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
using DSA_Assigments.Core;

namespace DSA_Assigments
{
    
    public partial class Form1 : Form
    {
        public static CustomDataList StList = new CustomDataList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///CustomDataList StList = new CustomDataList();
            StList.PopulateWithSampleData();
            MessageBox.Show("Data was successfully populated.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Student rs = Form1.StList.RemoveFirst();
                MessageBox.Show($"Student: {rs} was succesfully removed.");
            }
            catch(Exception err)
            {
                MessageBox.Show("No Data");

            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Student rs = Form1.StList.RemoveLast();
                MessageBox.Show($"Student: {rs} was succesfully removed.");
            }
            catch (Exception err)
            {
                MessageBox.Show("No Data");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Form1.StList.GetMaxElement();
                MessageBox.Show($"{student} is a student with the best score.");
            }
            catch (Exception err)
            {
                MessageBox.Show("No Data");

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Form1.StList.GetMinElement();
                MessageBox.Show($"{student} is a student with the worst score.");
            }
            catch (Exception err)
            {
                MessageBox.Show("No Data");

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Form1.StList.First;
                MessageBox.Show($"{student} is the first student in the list.");
            }
            catch (Exception err)
            {
                MessageBox.Show("No Data");

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Form1.StList.Last;
                MessageBox.Show($"{student} is the last student in the list.");
            }
            catch (Exception err)
            {
                MessageBox.Show("No Data");

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int len = Form1.StList.Lenght;
            MessageBox.Show($"{len} is a number of students.");
        }
    }
}
