using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAria.Data
{
    public partial class TableTestsR1
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public virtual ICollection<TableTestsR2> TableTestsR2 { get; set; }
    }
}
