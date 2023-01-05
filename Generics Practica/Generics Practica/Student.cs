using Generics_Practica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practica
{
    internal  class Student : IStudent
    {
        public   int Id { get; set; }
        public string Name { get; set; }
        public Student(string name)
        {

        }
    }
}
