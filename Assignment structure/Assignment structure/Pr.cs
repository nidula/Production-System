using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_structure
{
    class Pr
    {
        public double target_output_shift(double totminpro)
        {
            double targetout;
            targetout = totminpro * 280;
            return targetout;
        }

        public double perfomence_rate(double actout, double targetout)
        {
            double prate;
            prate = (actout / targetout)*100;
            return prate;
        } 
        
    }
}
