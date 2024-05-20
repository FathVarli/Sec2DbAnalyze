using System;
using Sec2DbAnalyze.Domain.Abstract;

namespace Sec2DbAnalyze.Domain.Concrete
{
    public class Log : IEntity
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public long TotalTimeMs { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}