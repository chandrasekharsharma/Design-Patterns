namespace InterfaceDAL
{
    //Design Pattern:- Generic Repository pattern
    public interface IDAL<T>
    {
        void Add(T obj);
        void Update(T obj);
        List<T> Search();
        void Save(T obj);
    }
}
