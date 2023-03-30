using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StopWatch
{
    public class Class
    {
        
        public double weight;
        public int ID;
        Random random = new Random();

        public Class(){

            weight = random.NextDouble();
            ID = random.Next();
        }
        public Class(double Weight,int Id)
        {
            
            weight = Weight;
            ID = Id;

        }
        public Class(int Id)
        {
            ID = Id;
            weight = random.NextDouble();

        }
        public Class(double Weight)
        {
            weight = Weight;
            ID = random.Next();

        }



    }
}
