﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remonty.Models
{
    public class Project : ComplexProperty, IComplexProperty
    {
        public Project()
        {

        }

        public Project(string name)
        {
            Name = name;
        }
    }
}
