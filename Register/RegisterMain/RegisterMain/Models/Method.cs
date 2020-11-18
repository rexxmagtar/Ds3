using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOPSLab3Service.Models
{
    public class Method
    {
        [Key]
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string MethodName { get; set; }
    }
}
