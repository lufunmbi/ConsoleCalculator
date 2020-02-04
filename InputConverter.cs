﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class InputConverter
    {
        public double ConvertToNumeric(string argTextInput)
        {
            double convertedNumber;

            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value.");

            return convertedNumber;
        }
    }
}
