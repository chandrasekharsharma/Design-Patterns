using System.ComponentModel.DataAnnotations;

namespace InterfaceCustomer
{
    public interface ICustomer
    {
        int Id { get; set; }
        string CustomerType { get; set; }
        string CustomerName { get; set; }
        string Address { get; set; }
        string PhoneNumber {  get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        void Validate();
    }
    //Design Pattern:- Stratergy Pattern
    public interface IValidation<T>
    {
        void Validate(T value);
    }
    public  class CustomerBase : ICustomer
    {
        public CustomerBase()
        {            
        }
        private IValidation<ICustomer> validation = null;
        public CustomerBase(IValidation<ICustomer> _Validation)
        {
            validation = _Validation;
        }
        [Key]
        public int Id { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime BillDate { get; set; }
        public decimal BillAmount { get; set; }
        public virtual void Validate()
        {
            // throw new Exception("Not Implemented");
            validation.Validate(this);
        }
    }
}
