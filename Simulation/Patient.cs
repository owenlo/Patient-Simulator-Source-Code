using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientSimulator
{
    public class Patient
    {
        public string title { get; set; }
        public string lName { get; set; }
        public string fName { get; set; }       
        public string patientId { get; set; }
        public DateTime dob { get; set; }
        public string gender { get; set; }
        public string bloodtype { get; set; }

        public HeartRate hr { get; set; }
        public BloodPressure bp { get; set; }
        public Temperature temp { get; set; }
        public SpO2 spo2 { get; set; }
        public Respiratory rr { get; set; }
    }
}
