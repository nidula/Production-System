using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_structure
{
    class Main
    {
        private double st;
        private double et;
        private double nopro;
        private double devetime;
        private double plandown;

        public void set_st(double start_time)
        {
            st= start_time;
        }
        public double get_st()
        {
            return st;
        }
        public void set_et(double end_time)
        {
            et = end_time;
        }
        public double get_et()
        {
            return et;
        }
        public void set_nopro(double no_of_production)
        {
            nopro = no_of_production;
        }
        public double get_nopro()
        {
            return nopro;
        }
        public void set_devetime(double developement_time)
        {
            devetime = developement_time;
        }
        public double get_devetime()
        {
            return devetime;
        }
        public void set_plandown(double plan_downtime)
        {
            plandown = plan_downtime;
        }
        public double get_plandown()
        {
            return plandown;
        }

        public double total_hours_work_bymin()
        {
            double totmin;
            totmin = ((get_et() - get_st()) * 60 - (get_nopro() + get_devetime() + get_plandown()));
            return totmin;
        }
    }
}
