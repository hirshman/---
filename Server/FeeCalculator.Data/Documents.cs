using System;
using System.Collections.Generic;

#nullable disable

namespace PersonalAria.Data
{
    public partial class Documents
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? GovFormTempId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? StatusId { get; set; }
        public string Comments { get; set; }
        public DateTime? StatusDate { get; set; }
        public string FormContents { get; set; }
        public int? ParentId { get; set; }
        public int? PersonId { get; set; }
        public int? StatusDetailsId { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public int? DocumentConditionDocTypeId { get; set; }

        public virtual DocumentTypes Type { get; set; }
    }
}
