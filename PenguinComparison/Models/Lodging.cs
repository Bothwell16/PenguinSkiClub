using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PenguinComparison.Models
{
    public class Lodging
    {

        public string name;
        public Compare guestInfo;

        public int adultRate { get; private set; }
        public int teenRate { get; private set; }
        public int childRate { get; private set; }
        public int membershipDues { get; private set; }
        public int personCount { get; private set; }
        public int priceQuoted { get; private set; }
        public double quotedPrice { get; private set; }
        public double averagePricePerPersonPerNight { get; private set; }
        public bool member { get; private set; }
        public int annualCost { get; private set; }

        public Lodging(string name)
        {
            this.name = name;
            this.adultRate = 0;
            this.teenRate = 0;
            this.childRate = 0;
            this.membershipDues = 0;
        }
        internal void LoadReservation(Compare r, bool asMember)
        {
            //TODO : create a seasonal Lodging flag for penguin
            //       that gets set if the data was loaded

            this.guestInfo = r;

            this.member = asMember;
            CalcAverageCostPerPersonPerNight();
        }

        internal void LoadMemberRates(int adultRate, int teenRate, int childRate, int membershipDues)
        {
            this.adultRate = adultRate;
            this.teenRate = teenRate;
            this.childRate = childRate;
            this.membershipDues = membershipDues;
        }

        internal void CalcAverageCostPerPersonPerNight()
        {
            if (this.member)
            {
                this.averagePricePerPersonPerNight = this.AnnualMembershipCost() / (double)this.personCount;
            }
            else
            {
                this.averagePricePerPersonPerNight = this.quotedPrice / this.personCount;
            }
        }

        private double AnnualMembershipCost()
        {
            return
                (this.adultRate * this.guestInfo.NumAdults) +
                (this.teenRate * this.guestInfo.NumStudents) +
                (this.childRate * this.guestInfo.NumChildren);

        }

        internal void LoadGuestRates(int personCount, double quotedPrice)
        {
            this.personCount = personCount;
            this.quotedPrice = quotedPrice;
        }
    }
}