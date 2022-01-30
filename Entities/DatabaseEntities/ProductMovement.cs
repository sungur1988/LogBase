using LogBase.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Entities.DatabaseEntities
{
    public class ProductMovement : AuditableEntity
    {
        public int ProductId { get; set; }
        public string MovementTypeId { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public virtual Product Product { get; set; }
        public virtual MovementType MovementType { get; set; }
    }
}
