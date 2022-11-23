using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.globalization;

namespace Exercicio_Fixação_de_listas
{
    internal class Employe
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employe(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) { 
        
        }

    }
}
