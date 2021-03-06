﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tematis.Resto.Domain
{
    public class Department
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
