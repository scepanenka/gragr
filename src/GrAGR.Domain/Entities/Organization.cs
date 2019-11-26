using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace GrAGR.Entities
{
    public class Organization : AuditedAggregateRoot<int>
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
