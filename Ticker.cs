using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientSimulator
{
    public class Ticker
    {
        private double m_globalTick;
        public double GlobalTick
        {
            get { return m_globalTick; }
            set { m_globalTick = value; }
        }
    }
}
