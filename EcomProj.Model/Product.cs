﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomProj.Model
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Expiry { get; set; }
    }
}
