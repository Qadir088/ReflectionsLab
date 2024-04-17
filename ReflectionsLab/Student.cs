using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsLab
{
    public class Student : Person
    {
        public Student()
        {
            lastAge++;
            Age = lastAge;
        }
    }
}