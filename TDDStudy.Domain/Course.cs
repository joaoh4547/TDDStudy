using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDStudy.Domain
{
    public class Course
    {
        public string Name { get; private set; }
        public double Workload { get; set; }
        public string TargetAdience { get; set; }
        public decimal Value { get; set; }

        public Course(string name, double workload, string targetAdience, decimal value)
        {
            Name = name;
            Workload = workload;
            TargetAdience = targetAdience;
            Value = value;
        }

    }
}
