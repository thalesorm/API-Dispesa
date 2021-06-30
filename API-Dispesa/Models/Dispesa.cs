using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Dispesa.Models
{
    public class Dispesa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public bool Pago { get; set; }
    }
}
