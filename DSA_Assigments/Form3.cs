using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DSA_Assigments.Entities;

namespace DSA_Assigments
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Surname = textBox2.Text;
            string StudentNumber = textBox3.Text;
            float Avr = 0;
            try { Avr = float.Parse(textBox4.Text, CultureInfo.InvariantCulture.NumberFormat);
                Student newst = new Student { FirstName = Name, LastName = Surname, StudentNumber = StudentNumber, AverageScore = Avr };
                Form1.StList.Add(newst);
                MessageBox.Show("Student was succesfully added");
                this.Close();
            }
            catch(Exception err) { textBox4.Text = "";
                MessageBox.Show("Enter the number");
            }
            //Student newst = new Student { FirstName = Name, LastName = Surname, StudentNumber = StudentNumber, AverageScore = Avr };
            //Form1.StList.Add(newst);
            //MessageBox.Show("Student was succesfully added");
        }
    }
}
