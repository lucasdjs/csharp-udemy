using System;

namespace EXERCICIO_01_RESOLVIDO.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public HourContract()
        {

        }

        public double TotalValue() {
            return ValuePerHour * Hours;
        }
    }
}
