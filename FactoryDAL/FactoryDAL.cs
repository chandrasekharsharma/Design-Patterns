using Microsoft.Practices.Unity;
using InterfaceDAL;
using InterfaceCustomer;
using AdoDotnetDAL;
using EfDAL;

namespace FactoryDAL
{
    public static class FactoryDAL<T>
    {
        static IUnityContainer DalObjects = null;
        public static T Create(string Type)
        {
            if (DalObjects is null)
            {
                DalObjects = new UnityContainer();
                DalObjects.RegisterType<IDAL<CustomerBase>, CustomerDAL>("AdoDAL");
                DalObjects.RegisterType<IDAL<CustomerBase>, EfDALCustomer>("EfDAL");
            }
            return DalObjects.Resolve<T>(Type,new ResolverOverride[]
            { 
                new ParameterOverride("_ConnectionString","user id=sa;password=123;database=designpatterns;data source=.")
            });
        }
    }
}
