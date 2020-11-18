﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOPSLab3Service.Models
{
    public class Service
    {
        [Key]
        public string ServiceName { get; set; }
        public virtual List<Method> AvailableMethods { get; set; }
    }
}
