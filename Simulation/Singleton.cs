using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Troschuetz.Random; //http://www.codeproject.com/KB/recipes/Random.aspx

namespace PatientSimulator
{
    public class Singleton
    {
        public NormalDistribution n;
        private static Singleton Instance;
        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }
        protected Singleton()
        {
            n = new NormalDistribution();
        }
    }
}
