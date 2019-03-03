using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PenguinComparison.Models
{
    public class Lodging
    {
 /*       public int NumAdults { get; set; }
        public int NumStudents { get; set; }
        public int NumChildren { get; set; }
        public int NumVacationNights { get; set; }
        public int NumWeekendNights { get; set; }
        public double CostPerPerson { get; set; }
*/
        private string name;
        public Compare guestInfo;

        public Lodging(string name)
        {
            this.name = name;
        }
        internal void LoadReservation(Compare r)
        {
            //TODO : create a seasonal Lodging flag for penguin
            //       that gets set if the data was loaded

            this.guestInfo = r;
        }

        internal void LoadMemberRates(int v1, int v2, int v3, int v4)
        {
            //TODO : create a seasonal Lodging flag for penguin
            //       that gets set if the data was loaded

            //throw new NotImplementedException();
        }

        internal void LoadGuestRates(int v1, int v2)
        {
            //throw new NotImplementedException();
        }

        internal void LoadGuestRates(int v1, double v2)
        {
            //throw new NotImplementedException();
        }
    }
}