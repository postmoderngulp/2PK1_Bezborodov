using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    struct Struct
    {

        public double weight;
        public int ID;
        Random random = new Random();

        public Struct()
        {
            weight = random.NextDouble();
            ID = random.Next();
        }
        public Struct(double Weight, int Id)
        {

            weight = Weight;
            ID = Id;

        }
        public Struct(int Id)
        {
            ID = Id;
            weight = random.NextDouble();

        }
        public Struct(double Weight)
        {
            weight = Weight;
            ID = random.Next();

        }
    }
}
