using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAria.Data
{
    public partial class TableTestsR2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FileTypeId { get; set; }
        public int? TableTestR1Id { get; set; }
        public virtual TableTestsR1 TableTestR1 { get; set; }
    }
}
