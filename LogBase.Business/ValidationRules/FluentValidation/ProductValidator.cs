using FluentValidation;
using LogBase.Entities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotNull();
            RuleFor(p => p.ProductName).NotNull().MaximumLength(100);
            RuleFor(p => p.Price).GreaterThan(0).NotNull();
            RuleFor(p => p.CreatedUserId).NotNull();
            RuleFor(p => p.CreatedDate).NotNull();
        }
    }
}
