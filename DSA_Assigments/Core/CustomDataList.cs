using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using DSA_Assigments.Entities;
using System.IO;
using System.Windows.Forms;

namespace DSA_Assigments.Core
{
    public class CustomDataList
    {

        private Student[] students = {};
        private int dataindex = 0;
        private int count;


        public int Lenght;
        public Student First;
        public Student Last;
        public static IEnumerable<T> ReadSequenceOfElements<T>() where T : IComparable
        {


            var numbers = new List<T>();
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                T number = (T)Convert.ChangeType(input, typeof(T));
                numbers.Add(number);

                input = Console.ReadLine();
            }

            return numbers;
        }


        public void PopulateWithSampleData()
        {
            
#if DEBUG                       
            Console.SetIn(new System.IO.StreamReader("../../../DSA_Assigments/SampleData.txt"));

#endif
            var elements = ReadSequenceOfElements<string>().ToList();
            count = elements.Count;
            int len = count;
            students = new Student[len];
            char[] separators = new char[] { ',', ' ', };

            for (int i = 0; i < len; ++i)
            {
                string[] student_1 = elements[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                float Avr = float.Parse(student_1[3], CultureInfo.InvariantCulture.NumberFormat);
                students[i] = new Student
                {
                    FirstName = student_1[0],
                    LastName = student_1[1],
                    StudentNumber = student_1[2],
                    AverageScore = Avr
                };
                dataindex++;
            }
            Lenght = students.Length;

            First = students[0];
            Last = students[students.Length - 1];


        }



        public Student[] DisplayList()
        {
            return students;
        }
        public void Add(Student newStudent)
        {
            IncreaseCapacity();
            students[dataindex] = newStudent;
            Last = students[dataindex];
            dataindex++;
            Lenght = dataindex;
        }
        public Student GetElement(int index)
        {

            if (index < 0 || index >= dataindex)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid data index: " + dataindex);
            }
            return students[index];
        }
        public Student RemoveByIndex(int index)
        {
            Student rems = students[index];
            if (index < 0 || index >= dataindex)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid data index: " + dataindex);
            }

            for (int i = index; i < dataindex - 1; i++)
            {
                students[i] = students[i + 1];
            }

            students[dataindex - 1] = null;

            dataindex--;
            Lenght = dataindex;
            Last = students[dataindex - 1];
            return rems;
            ///Console.WriteLine($"Removed student is: {rems}");
        }
        public Student RemoveFirst()
        {
            Student rems = students[0];
            students[0] = null;
            for (int i = 0; i < students.Length - 1; ++i)
            {
                students[i] = students[i + 1];
            }
            First = students[0];
            students[dataindex - 1] = null;
            dataindex--;
            Lenght = dataindex;
            Last = students[dataindex - 1];
            return rems;
            ///Console.WriteLine($"Removed student is: {rems}");
        }
        public Student RemoveLast()
        {
            Student rems = students[dataindex - 1];


            for (int i = students.Length - 1; i < dataindex - 1; i++)
            {
                students[i] = students[i + 1];
            }

            students[dataindex - 1] = null;

            dataindex--;
            Lenght = dataindex;
            Last = students[dataindex - 1];
            return rems;
            ///Console.WriteLine($"Removed student is: {rems}");

        }
        public void IncreaseCapacity()
        {
            if (dataindex >= students.Length)
            {
                Student[] resizedArray = new Student[students.Length + 1];

                Array.Copy(students, 0, resizedArray, 0, students.Length);

                students = resizedArray;
                Lenght = students.Length;

            }
        }
        public enum SortDirection
        {
            FirstName,
            LastName,
            Number,
            Score
        }
        public enum SortWay
        {
            Ascending,
            Descending
        }
        public Student[] Sort(SortDirection sortDirection, SortWay sortway)
        {
            if (sortDirection.ToString() == "FirstName" && sortway.ToString() == "Ascending")
            {
                for (int i = 0; i < students.Length; ++i)
                {
                    for (int j = 0; j < students.Length - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].FirstName, students[j + 1].FirstName) > 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (sortDirection.ToString() == "FirstName" && sortway.ToString() == "Descending")
            {
                for (int i = 0; i < students.Length; ++i)
                {
                    for (int j = 0; j < students.Length - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].FirstName, students[j + 1].FirstName) < 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (sortDirection.ToString() == "LastName" && sortway.ToString() == "Ascending")
            {
                for (int i = 0; i < students.Length; ++i)
                {
                    for (int j = 0; j < students.Length - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].LastName, students[j + 1].LastName) > 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (sortDirection.ToString() == "LastName" && sortway.ToString() == "Descending")
            {
                for (int i = 0; i < students.Length; ++i)
                {
                    for (int j = 0; j < students.Length - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].LastName, students[j + 1].LastName) < 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (sortDirection.ToString() == "Number" && sortway.ToString() == "Ascending")
            {
                for (int i = 0; i < students.Length; ++i)
                {
                    for (int j = 0; j < students.Length - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].StudentNumber, students[j + 1].StudentNumber) > 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (sortDirection.ToString() == "Number" && sortway.ToString() == "Descending")
            {
                for (int i = 0; i < students.Length; ++i)
                {
                    for (int j = 0; j < students.Length - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (String.Compare(students[j].StudentNumber, students[j + 1].StudentNumber) < 0)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (sortDirection.ToString() == "Score" && sortway.ToString() == "Ascending")
            {
                for (int i = 0; i < students.Length; ++i)
                {
                    for (int j = 0; j < students.Length - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (students[j].AverageScore > students[j + 1].AverageScore)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            if (sortDirection.ToString() == "Score" && sortway.ToString() == "Descending")
            {
                for (int i = 0; i < students.Length; ++i)
                {
                    for (int j = 0; j < students.Length - 1; ++j)
                    {
                        if (students[j + 1] != null)
                        {
                            if (students[j].AverageScore < students[j + 1].AverageScore)
                            {
                                var temp = students[j];
                                students[j] = students[j + 1];
                                students[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            First = students[0];
            Last = students[dataindex - 1];
            return students;

        }
        public Student GetMaxElement()
        {
            Student max = new Student();
            for (int i = 0; i < students.Length; i++)
            { if (students[i] != null)
                {
                    if (max.AverageScore < students[i].AverageScore)
                    {
                        max = students[i];
                    }
                }
            }
            return max;
        }
        public Student GetMinElement()
        {
            Student min = new Student { AverageScore = 5 };
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    if (min.AverageScore > students[i].AverageScore)
                    {
                        min = students[i];
                    }
                }
            }
            return min;
        }
    }
}
