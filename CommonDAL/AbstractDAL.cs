using InterfaceDAL;

namespace CommonDAL
{
    public abstract class AbstractDAL<T> : IDAL<T>
    {
        protected string ConnectionString = "";
        public AbstractDAL(string _ConnectionString)
        {
            ConnectionString = _ConnectionString;
        }
        protected List<T> anyTypes=new List<T>();
        public virtual void Add(T obj)
        {
            anyTypes.Add(obj);
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public virtual List<T> Search()
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
