using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_27
{
    struct Student
    {
        public string Name;
        public int Group;
        public int[] Ses = new int[5];

        Student(string name,int group, int[] SesArr)
        {
            Name = name;
            Group = group;
            Ses = SesArr;
        }
    }
}
