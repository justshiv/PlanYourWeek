﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remonty.Models
{
    public class Context : ComplexProperty, IComplexProperty
    {
        public Context()
        {

        }

        public Context(string name)
        {
            Name = name;
        }
    }
}
