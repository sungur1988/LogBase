using LogBase.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Entities.Dtos
{
    public class CategoryDto : IDto
    {
        public string CategoryName { get; set; }
    }
}
