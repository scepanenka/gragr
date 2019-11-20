using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace GrAGR.Entities
{
    public class ClientOrders : AuditedAggregateRoot<Guid>
    {
        [ForeignKey("Client")]
        public Guid IdClient { get; set; }
        [ForeignKey("Order")]
        public Guid IdOrder { get; set; }

        public Client Client { get; set; }
        public Order Order { get; set; }

    }
}
