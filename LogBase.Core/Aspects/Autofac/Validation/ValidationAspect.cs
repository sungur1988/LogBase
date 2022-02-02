using Castle.DynamicProxy;
using FluentValidation;
using LogBase.Core.CrossCuttingConcerns.Validation;
using LogBase.Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception("Bu bir doğrulama sınıfı değildir.");
            }
            _validatorType = validatorType;

        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GenericTypeArguments[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var item in entities)
            {
                ValidationTool.Validate(validator, item);
            }
            
        }
    }
}
