using InterfaceCustomer;
using Microsoft.Practices.Unity;
using MiddleLayer;
using ValidationAlgorithms;

namespace FactoryCustomer
{
    public static class Factory<T>//Design Pattern:- Simple Factory Pattern
    {
        private static IUnityContainer objectsInOurProject = null;
        //static  Factory()
        //{
        //    customer.Add("Customer",new Customer());
        //    customer.Add("Lead",new Lead());
        //}
        public static T Create(string CustType)
        {
            //if (CustType == "Customer")
            //{
            //    return new Customer();
            //}
            //else
            //{
            //    return new Lead();
            //}

            //Design Pattern:- Lazy loading 
            if (objectsInOurProject is null)
            {
                //customer.Add("Customer",new Customer());
                //customer.Add("Lead",new Lead());
                objectsInOurProject = new UnityContainer();
                objectsInOurProject.RegisterType<CustomerBase, Lead>("Lead", new InjectionConstructor(new LeadValidation()));
                objectsInOurProject.RegisterType<CustomerBase, Customer>("Customer", new InjectionConstructor(new CustomerValidationsAll()));
                //objectsInOurProject.RegisterType<IDAL<ICustomer>, CustomerDAL>("AdoDAL");
            }
            //Design Pattern:- RIP(Replace If With Polymorphism)
            //   return customer[CustType];
            return objectsInOurProject.Resolve<T>(CustType) ;
        }
    }
}
