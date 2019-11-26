using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace GrAGR.Entities
{
    public class Order : AuditedAggregateRoot<Guid>
    {
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        [ForeignKey("Receptionist")]
        public Guid ReceptionistId { get; set; }
        public DateTime DateReceipt { get; set; }
        public DateTime DateExecution { get; set; }
        public string Number { get; set; }

        public Employee Receptionist { get; set; }
        public Organization Organization { get; set; }
        public ICollection<ClientOrders> ClientOrders { get; set; }
    }

}
