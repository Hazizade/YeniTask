using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12._05
{
    internal class Group
    {
        public string Nomer;
        public int Limit;
        public Student[] students = new Student[0];


        public Group(string nomer, int limit, )
        {
            Nomer =nomer;
            Limit = limit;
            

        }

        public void AddStudent() 
        {
            Student[] student = new Student[0];

        }

    }
}
