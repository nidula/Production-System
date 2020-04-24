using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_structure
{
    class Qr
    {
        private double actpro;
        private double rwork;
        private double defect;
        private double samples;

        public void set_actpro(double actual_production)
        {
            actpro = actual_production;
        }
        public double get_actpro()
        {
            return actpro;
        }

        public void set_rwork(double rework)
        {
            rwork = rework;
        }
        public double get_rwork()
        {
            return rwork;
        }

        public void set_defect(double defects)
        {
            defect = defects;
        }
        public double get_defect()
        {
            return defect;
        }

        public void set_samples(double sample)
        {
            samples = sample;
        }
        public double get_samples()
        {
            return samples;
        }

        public double total_rejections()
        {
            double totrej;
            totrej = get_rwork() + get_defect() + get_samples() ;
            return totrej;
        }

        public double actual_output(double totrej)
        {
            double actout;
            actout = get_actpro() - totrej;
            return actout;
        }

        public double quality_rate(double actout)
        {
            double qrate;
            qrate = (actout / get_actpro())*100;
            return qrate;
        }
    }
}
