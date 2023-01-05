using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practica.Models
{
    internal class StudentList
    {
        private Student[] arr;

        public StudentList()
        {
          arr = new Student[0];

        }

        public void Add(Student stu)
        {
            Array.Resize(ref arr, arr.Length +1);
            arr[arr.Length-1] = stu;
        }


        public void GetAll()
        {
            foreach (Student student in arr)
            {
                Console.WriteLine(student.Name);
            }
        }


    }
}
