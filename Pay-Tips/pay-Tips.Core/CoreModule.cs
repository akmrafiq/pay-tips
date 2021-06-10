using Autofac;
using Pay_Tips.Core.Contexts;
using Pay_Tips.Core.Repositories;
using Pay_Tips.Core.Services;
using Pay_Tips.Core.UnitOfWorks;
using System;

namespace Pay_Tips.Core
{
    public class CoreModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public CoreModule(string connectionStringName, string migrationAssemblyName)
        {
            _connectionString = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PayContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<PayUnitOfWork>().As<IPayUnitOfWork>()
                   //.WithParameter("connectionString", _connectionString)
                   //.WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PaymentClaimRepository>().As<IPaymentClaimRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SalaryRepository>().As<ISalaryRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeService>().As<IEmployeeService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
