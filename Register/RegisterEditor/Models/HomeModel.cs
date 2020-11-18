using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3Register.Models
{
    public class HomeModel
    {
        public List<KeyValuePair<string, List<string>>> methods { get; set; } = new List<KeyValuePair<string, List<string>>>();

    }
}
