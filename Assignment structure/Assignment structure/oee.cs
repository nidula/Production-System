using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_structure
{
    class oee
    {
        private double actpro;
        public void set_actpro(double actual_production)
        {
            actpro = actual_production;
        }
        public double get_actpro()
        {
            return actpro;
        }
        public double calculate_oee(double availability,double quality, double performence )
        {
            double oee;
            oee = (availability + quality + performence)/3;
            return oee;
        }
    }
}
