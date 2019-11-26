using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace GrAGR.Entities
{
    public class Employee : AuditedAggregateRoot<Guid>
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        [ForeignKey("Position")]
        public Guid PositionId { get; set; }
        public Position Position { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
