using System;

namespace Sec2DbAnalyze.Dto.Concrete
{
    public class IdentityFilterDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ServiceId { get; set; }
    }
}