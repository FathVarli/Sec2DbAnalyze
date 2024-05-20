using System;
using Sec2DbAnalyze.Dto.Abstract;

namespace Sec2DbAnalyze.Dto
{
    public class UserDto : IDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid UserProfileId { get; set; }
        public string Column35 { get; set; }
        public string Column36 { get; set; }
        public Guid UserSectionId { get; set; }
        public string Column27 { get; set; }
        public string Column28 { get; set; }
    }
}