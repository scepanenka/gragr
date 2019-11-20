using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace GrAGR.Entities
{
    public class Position : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}
