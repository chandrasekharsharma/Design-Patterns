using InterfaceCustomer;
using InterfaceDAL;
using System.Data.Entity;

namespace EfDAL
{
    public abstract class EfAbstractDAL<T> : DbContext, IDAL<T> where T : class
    {
        public EfAbstractDAL():base("name = con")
        {            
        }
        public void Add(T obj)
        {
            Set<T>().Add(obj);
        }

        public void Save(T obj)
        {
            SaveChanges();
        }

        public List<T> Search()
        {
            return Set<T>().AsQueryable<T>().ToList<T>();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
    public class EfDALCustomer : EfAbstractDAL<CustomerBase>
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerBase>().ToTable("tblCustomer");
            //modelBuilder.Entity<CustomerBase>()
            //    .Map<Customer>(x => x.Requires("CustomerType").HasValue("Customer"))
            //    .Map<Lead>(x => x.Requires("CustomerType").HasValue("Lead"));
            //modelBuilder.Entity<CustomerBase>().Ignore(x => x.CustomerType);
        }
    }
}
