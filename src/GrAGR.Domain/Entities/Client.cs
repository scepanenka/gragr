using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace GrAGR.Entities
{
    public class Client : AuditedAggregateRoot<Guid>
    {

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public string Address { get; set; }

        public string PersonalNumber { get; set; }

        public string PhoneNumber { get; set; }
        public int? ClientTypeId { get; set; }

        public string Unn { get; set; }

        public DateTime? BothDate { get; set; }

        public string Information { get; set; }
    }

}
