﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExercicioResolvido
{
    public class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee()
        { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);

        }
    }
}
