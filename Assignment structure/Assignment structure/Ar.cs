using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_structure
{
    class Ar
    {
        public double mc;
        public double chpro;
        public double chreel;
        public double batchco;
        public double lesswo;
        public double materialiss;
        public double tacrashing;
        public double stuptime;
        public double cleaning;
        public double misc;
        

        public void set_mc(double mc_bd)
        {
            mc = mc_bd;
        }
        public double get_mc()
        {
            return mc;
        }
        public void set_chpro(double changeover_production)
        {
            chpro = changeover_production;
        }
        public double get_chpro()
        {
            return chpro;
        }
        public void set_chreel(double changeover_reel)
        {
            chreel = changeover_reel;
        }
        public double get_chreel()
        {
            return chreel;
        }
        public void set_batchco(double batch_co)
        {
            batchco = batch_co;
        }
        public double get_batchco()
        {
            return batchco;
        }
        public void set_lesswo(double less_workers)
        {
            lesswo = less_workers;
        }
        public double get_lesswo()
        {
            return lesswo;
        }
        public void set_materialiss(double material_issues)
        {
            materialiss = material_issues;
        }
        public double get_materialiss()
        {
            return materialiss;
        }
        public void set_tacrashing(double tablet_crashing)
        {
            tacrashing = tablet_crashing;
        }
        public double get_tacrashing()
        {
            return tacrashing;
        }
        public void set_stuptime(double start_up_timing)
        {
            stuptime = start_up_timing;
        }
        public double get_stuptime()
        {
            return stuptime;
        }
        public void set_cleaning(double clean)
        {
            cleaning = clean;
        }
        public double get_cleaning()
        {
            return cleaning;
        }
        public void set_misc(double mis)
        {
            misc = mis;
        }
        public double get_misc()
        {
            return cleaning;
        }

        
        public double total_downtime()
        {
            double totdown;
            totdown = get_mc() + get_chpro() + get_chreel() + get_batchco() + get_lesswo() + get_materialiss() + get_tacrashing() + get_stuptime ()+ get_cleaning() + get_misc();
            return totdown;
        }
        public double total_hours_work_byhrs(double totmin)
        {
            double tothrs;
            tothrs = totmin / 60;
            return tothrs;
        }

        public double total_min_for_production(double totmin, double totdown)
        {
            double totminpro;
            totminpro = totmin - totdown;
            return totminpro;
        }

        public double availability_rate(double totmin, double totminpro)
        {
            double arate;
            arate = (totminpro / totmin) * 100;
            return arate;
        }
    }
}
