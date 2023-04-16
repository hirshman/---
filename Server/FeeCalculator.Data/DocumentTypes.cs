using System;
using System.Collections.Generic;

#nullable disable

namespace PersonalAria.Data
{
    public partial class DocumentTypes
    {
        public DocumentTypes()
        {
            Documents = new HashSet<Documents>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public int? TopDepartmentId { get; set; }
        public int? DepartmentId { get; set; }
        public int? EmployeeId { get; set; }
        public short? SortOrder { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string ClassPrefix { get; set; }
        public string BuslogicObject { get; set; }
        public string BuslogicCommand { get; set; }
        public string Code { get; set; }
        public string Path { get; set; }
        public string ApplicationCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Documents> Documents { get; set; }
    }
}
