﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities.Common;

namespace ECommerce.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }


    }
}
