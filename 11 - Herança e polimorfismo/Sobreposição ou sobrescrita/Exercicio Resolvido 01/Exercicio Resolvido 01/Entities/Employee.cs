using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Resolvido_01.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public double ValueTot { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
            ValueTot = Payment();
        }

        public virtual double Payment() {

            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Employee employees in Employees)
            {
                sb.AppendLine(employees.Name + " - " + "$ " + employees.ValueTot.ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();

            


        }

    }
}
