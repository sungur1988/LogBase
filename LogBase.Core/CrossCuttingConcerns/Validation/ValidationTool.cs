using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static  void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var results = validator.Validate(context);

            if (!results.IsValid)
            {
                throw new ValidationException(results.Errors);
            }
        }
    }
}
