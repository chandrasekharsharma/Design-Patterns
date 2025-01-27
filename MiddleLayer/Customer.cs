using InterfaceCustomer;

namespace MiddleLayer
{    
    public class Customer : CustomerBase
    {
        public Customer()
        {
            CustomerType = "Customer";
        }
        public Customer(IValidation<ICustomer> obj) : base(obj)
        {
            CustomerType = "Customer";
        }
        //public override void Validate()
        //{
        //if (CustomerName.Length == 0)
        //{
        //    throw new Exception("Customer Name is required");
        //}
        //if (PhoneNumber.Length == 0)
        //{
        //    throw new Exception("Phone Number is required");
        //}
        //if (Address.Length == 0)
        //{
        //    throw new Exception("Address is required");
        //}
        //if (BillAmount == 0)
        //{
        //    throw new Exception("Bill Amount is required");
        //}
        //if (BillDate >= DateTime.Now)
        //{
        //    throw new Exception("Bill Date is not proper");
        //}
        //}

    }
    public class Lead : CustomerBase
    {
        public Lead()
        {
            CustomerType = "Lead";
        }
        public Lead(IValidation<ICustomer> obj) : base(obj)
        {
            CustomerType = "Lead";
        }
        //public override void Validate()
        //{
        //    if (CustomerName.Length == 0)
        //    {
        //        throw new Exception("Customer Name is required");
        //    }
        //    if (PhoneNumber.Length == 0)
        //    {
        //        throw new Exception("Phone Number is required");
        //    }
        //}
    }
}
