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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            try
            {
                Student[] students;
                if (comboBox1.Text == "First Name" && comboBox2.Text == "Ascending")
                {
                    students = Form1.StList.Sort(Core.CustomDataList.SortDirection.FirstName, Core.CustomDataList.SortWay.Ascending);
                    for (int i = 0; i < students.Length; ++i)
                    {
                        if (students[i] != null)
                        {
                            listBox1.Items.Insert(i, students[i]);
                        }
                    }
                }
                else if (comboBox1.Text == "First Name" && comboBox2.Text == "Descending")
                {
                    students = Form1.StList.Sort(Core.CustomDataList.SortDirection.FirstName, Core.CustomDataList.SortWay.Descending);
                    for (int i = 0; i < students.Length; ++i)
                    {
                        if (students[i] != null)
                        {
                            listBox1.Items.Insert(i, students[i]);
                        }
                    }
                }
                else if (comboBox1.Text == "Last Name" && comboBox2.Text == "Ascending")
                {
                    students = Form1.StList.Sort(Core.CustomDataList.SortDirection.LastName, Core.CustomDataList.SortWay.Ascending);
                    for (int i = 0; i < students.Length; ++i)
                    {
                        if (students[i] != null)
                        {
                            listBox1.Items.Insert(i, students[i]);
                        }
                    }
                }
                else if (comboBox1.Text == "Last Name" && comboBox2.Text == "Descending")
                {
                    students = Form1.StList.Sort(Core.CustomDataList.SortDirection.LastName, Core.CustomDataList.SortWay.Descending);
                    for (int i = 0; i < students.Length; ++i)
                    {
                        if (students[i] != null)
                        {
                            listBox1.Items.Insert(i, students[i]);
                        }
                    }
                }
                else if (comboBox1.Text == "Student Number" && comboBox2.Text == "Ascending")
                {
                    students = Form1.StList.Sort(Core.CustomDataList.SortDirection.Number, Core.CustomDataList.SortWay.Ascending);
                    for (int i = 0; i < students.Length; ++i)
                    {
                        if (students[i] != null)
                        {
                            listBox1.Items.Insert(i, students[i]);
                        }
                    }
                }
                else if (comboBox1.Text == "Student Number" && comboBox2.Text == "Descending")
                {
                    students = Form1.StList.Sort(Core.CustomDataList.SortDirection.Number, Core.CustomDataList.SortWay.Descending);
                    for (int i = 0; i < students.Length; ++i)
                    {
                        if (students[i] != null)
                        {
                            listBox1.Items.Insert(i, students[i]);
                        }
                    }
                }
                else if (comboBox1.Text == "Average Score" && comboBox2.Text == "Ascending")
                {
                    students = Form1.StList.Sort(Core.CustomDataList.SortDirection.Score, Core.CustomDataList.SortWay.Ascending);
                    for (int i = 0; i < students.Length; ++i)
                    {
                        if (students[i] != null)
                        {
                            listBox1.Items.Insert(i, students[i]);
                        }
                    }
                }
                else if (comboBox1.Text == "Average Score" && comboBox2.Text == "Descending")
                {
                    students = Form1.StList.Sort(Core.CustomDataList.SortDirection.Score, Core.CustomDataList.SortWay.Descending);
                    for (int i = 0; i < students.Length; ++i)
                    {
                        if (students[i] != null)
                        {
                            listBox1.Items.Insert(i, students[i]);
                        }
                    }
                }
                else
                {
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    MessageBox.Show("Fill the comboboxes");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("No Data");
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
