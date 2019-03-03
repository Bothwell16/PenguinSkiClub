using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PenguinComparison.Models
{
    public class Compare
    {
        public int NumAdults { get; set; }
        public int NumStudents { get; set; }
        public int NumChildren { get; set; }
        public int NumVacationNights { get; set; }
        public int NumWeekendNights { get; set; }
        public double CostPerPerson { get; set; }   
    }
}