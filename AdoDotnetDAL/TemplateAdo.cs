using CommonDAL;
using FactoryCustomer;
using InterfaceCustomer;
using System.Data.SqlClient;

namespace AdoDotnetDAL
{
    public abstract class TemplateAdo<T> : AbstractDAL<T>
    {
        protected SqlConnection con = null;
        protected SqlCommand cmd = null;
        public TemplateAdo(string _ConnectionString) : base(_ConnectionString)
        {
        }
        public abstract void ExecuteCommand(T obj); //child classes can override
        public abstract List<T> ExecuteCommand(); //child classes can override
        private void Open()
        {
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
        }
        //Design Pattern:- Template pattern
        private void Execute(T obj) //Fixed sequence for insert
        {
            Open();
            ExecuteCommand(obj);
            Close();
        }

        //Design Pattern:- Template pattern
        public List<T> Execute()//Fixed Sequence for fetch
        {
            Open();
            List<T> anyTypes = ExecuteCommand();
            Close();
            return anyTypes;
        }
        private void Close()
        {
            con.Close();
        }
        public override void Save()
        {
            foreach (T anyType in anyTypes)
            {
                Execute(anyType);
            }
        }
        public override List<T> Search()
        {
            return Execute ();
        }
    }
    public class CustomerDAL : TemplateAdo<CustomerBase>
    {
        public CustomerDAL(string _ConnectionString) : base(_ConnectionString)
        {
        }
        public override void ExecuteCommand(CustomerBase obj)
        {
            cmd.CommandText = $"Insert into tblCustomer" +
                $"(CustomerType,CustomerName,BillAmount,BillDate,PhoneNumber,Address)" +
                $"values('{obj.CustomerType}','{obj.CustomerName}',{obj.BillAmount},'{obj.BillDate}','{obj.PhoneNumber}','{obj.Address}')";
            cmd.ExecuteNonQuery();
        }
        public override List<CustomerBase> ExecuteCommand()
        {
            List<CustomerBase> customers = new List<CustomerBase>();
            cmd.CommandText = "select * from tblcustomer";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CustomerBase customer = Factory<CustomerBase>.Create("Customer");
                customer.Id = Convert.ToInt32(dr["Id"]);
                customer.CustomerType = dr["CustomerType"]?.ToString();
                customer.CustomerName = dr["Customername"]?.ToString();
                customer.PhoneNumber = dr["phoneNumbER"]?.ToString();
                customer.BillDate = Convert.ToDateTime(dr["billDATE"]);
                customer.BillAmount=Convert.ToDecimal( dr["BILLAmount"]);
                customer.Address = dr["address"]?.ToString();
                customers.Add(customer);
            }
            return customers;
        }
    }
}
