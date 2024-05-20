using System;
using Sec2DbAnalyze.Domain.Abstract;

namespace Sec2DbAnalyze.Domain.Concrete
{
    public class Identity : IEntity,IAuditEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid IdentitySectionId { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }
        public string Column8 { get; set; }
        public string Column9 { get; set; }
        public string Column10 { get; set; }
        public string Column11 { get; set; }
        public string Column12 { get; set; }
        public string Column13 { get; set; }
        public string Column14 { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual IdentitySection IdentitySection { get; set; }
        public virtual User User { get; set; }
        public virtual Service Service { get; set; }

    }
}