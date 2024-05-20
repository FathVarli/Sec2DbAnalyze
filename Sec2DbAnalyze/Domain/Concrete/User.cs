using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sec2DbAnalyze.Domain.Abstract;

namespace Sec2DbAnalyze.Domain.Concrete
{
    public class User : IEntity, IAuditEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobilePhone { get; set; }
        public Guid ApiKey { get; set; }
        public bool IsActive { get; set; }
        public Guid AccountId { get; set; }
        public Guid UserProfileId { get; set; }
        public Guid UserSectionId { get; set; }
        public string Unit { get; set; }
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
        public virtual Account Account { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual UserSection UserSection { get; set; }
        public virtual ICollection<Identity> Identities { get; set; }
    }
}