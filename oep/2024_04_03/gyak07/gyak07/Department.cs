﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak07
{
    public class Department
    {
        public List<Item> supply;

        public Department()
        {
            supply = new List<Item>();
        }
    }
}