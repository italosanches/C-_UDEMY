using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Entities
{
     class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuerPerHour { get; set; }

        public int Hours { get; set; }

        public HourContract()
        {

        }
        public HourContract(DateTime date,double valuePerHour,int hours)
        {
            Date = date;
            ValuerPerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuerPerHour * Hours;
        }
    }
}
