using Autofac;
using LogBase.Business.Abstract;
using LogBase.Business.Concrete;
using LogBase.DataAccess;
using LogBase.DataAccess.Abstract;
using LogBase.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerLifetimeScope();

            builder.RegisterType<ProductManager>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();

            builder.RegisterType<ProductMovementManager>().As<IProductMovementService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductMovementRepository>().As<IProductMovementRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<AppDbContext>().SingleInstance();
        }
    }
}
