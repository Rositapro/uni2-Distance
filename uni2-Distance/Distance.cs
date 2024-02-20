using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni2_Distance
{
    internal class Distance
    {
        double speed;
        double time;
        double distance;

        //constructor
        public Distance (double speed, double time)
        {
            this.speed = speed;
            this.time = time;
            distance = 0;
            operacion();
        }
        public override string ToString()
        {
            return "the distance is: " + distance.ToString();
        }

        public void operacion()
        {
            distance = (speed * time);
        }

    }
}

