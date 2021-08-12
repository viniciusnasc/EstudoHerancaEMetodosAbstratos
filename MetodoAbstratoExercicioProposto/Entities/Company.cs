using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbstratoExercicioProposto.Entities
{
    class Company : Person
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Taxes()
        {
            if(NumberEmployees > 10)
            {
                return (AnualIncome * 0.14);
            }
            else
            {
                return (AnualIncome * 0.16);
            }
        }
    }
}
