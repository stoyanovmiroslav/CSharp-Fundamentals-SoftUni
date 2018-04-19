﻿using System;
using System.Collections.Generic;
using System.Text;
using _03.DependencyInversion.Contracts;

namespace _03.DependencyInversion.Core
{
    public class MultiplicationStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
