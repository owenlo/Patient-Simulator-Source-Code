using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientSimulator
{
    public abstract class VitalSign : Patient
    {
        public abstract double Simulate(double standard_deviation, double mean);
    }
}
