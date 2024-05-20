using System;

namespace Sec2DbAnalyze.Dto.Concrete
{
    public class UserFilterDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Guid AccountId { get; set; }
    }
}