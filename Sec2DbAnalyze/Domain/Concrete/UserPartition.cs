using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sec2DbAnalyze.Domain.Abstract;

namespace Sec2DbAnalyze.Domain.Concrete
{
    [Index(nameof(Email))]
    public class UserPartition : IEntity
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
        public string Column15 { get; set; }
        public string Column16 { get; set; }
        public string Column17 { get; set; }
        public string Column18 { get; set; }
        public string Column19 { get; set; }
        public string Column20 { get; set; }
        public string Column21 { get; set; }
        public string Column22 { get; set; }
        public string Column23 { get; set; }
        public string Column24 { get; set; }
        public string Column25 { get; set; }
        public string Column26 { get; set; }
        public string Column27 { get; set; }
        public string Column28 { get; set; }
        public string Column29 { get; set; }
        public string Column30 { get; set; }
        public string Column31 { get; set; }
        public string Column32 { get; set; }
        public string Column33 { get; set; }
        public string Column34 { get; set; }
        public string Column35 { get; set; }
        public string Column36 { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Account Account { get; set; } 
        public virtual ICollection<IdentityPartition> Identities { get; set; }
    }
}