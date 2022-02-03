using LogBase.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Core.EntityLayer.Concrete.BaseEntities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
