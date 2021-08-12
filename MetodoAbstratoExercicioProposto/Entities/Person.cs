using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbstratoExercicioProposto.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();
    }
}
