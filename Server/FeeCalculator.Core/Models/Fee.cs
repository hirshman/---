using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeeCalculator.Core.Models
{
    public class Fee
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MeasureType { get; set; }
        public int AmountPerUnit { get; set; }
    }
}
