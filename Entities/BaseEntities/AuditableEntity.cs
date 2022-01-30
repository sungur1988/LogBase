using LogBase.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Entities.BaseEntities
{
    public class AuditableEntity : BaseEntity, ICreatedEntity
    {
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
