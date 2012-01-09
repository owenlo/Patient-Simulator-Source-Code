using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Troschuetz.Random; //http://www.codeproject.com/KB/recipes/Random.aspx

namespace PatientSimulator
{
    public class BloodPressure : VitalSign
    {
        public NormalDistribution n = Singleton.GetInstance().n;

        public override double Simulate(double standard_deviation, double mean)
        {
            // median
            n.Mu = mean;
            // standard deviation
            n.Sigma = standard_deviation;

            int i = 0;
            int sample = 20;
            double total = 0;
            while (i < sample)
            {
                double value = n.NextDouble();
                total += value;
                i++;
            }

           return (total / sample);            
        }
    }
}
