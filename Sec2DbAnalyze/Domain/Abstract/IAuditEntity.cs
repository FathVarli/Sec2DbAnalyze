using System;

namespace Sec2DbAnalyze.Domain.Abstract
{
    public interface IAuditEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}