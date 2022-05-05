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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();            
            Student[] students = Form1.StList.DisplayList();
            for(int i = 0; i < students.Length; ++i)
            {
                if(students[i] != null)
                {
                    listBox1.Items.Insert(i, students[i]);
                }
            }
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
