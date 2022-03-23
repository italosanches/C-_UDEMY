using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SalarioFuncionarios
{
    internal class Funcionario
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary (double porcent)
        {
            Salary = (Salary * porcent) /100 + Salary;
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
