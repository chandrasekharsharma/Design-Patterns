

using FactoryCustomer;
using FactoryDAL;
using InterfaceCustomer;
using InterfaceDAL;

namespace WinFormsCustomer
{
    public partial class FrmCustomer : Form
    {
        CustomerBase customer = null;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void ddlCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer = Factory<CustomerBase>.Create(ddlCustomerType.Text);
        }
        void LoadGrid()
        {
            IDAL<CustomerBase> Dal = FactoryDAL<IDAL<CustomerBase>>.Create(ddlDAL.Text);
            List<CustomerBase> customers = Dal.Search();
            dataGridView1.DataSource = customers;
        }
        void SetCustomer()
        {
            customer.BillAmount = Convert.ToDecimal(txtBillAmount.Text);
            customer.CustomerName = txtCustomerName.Text;
            customer.BillDate = Convert.ToDateTime(txtBillDate.Text);
            customer.PhoneNumber = txtPhoneNumber.Text;
            customer.Address = txtAddress.Text;
        }
        void ClearCustomer()
        {
            txtBillAmount.Text = "0";
            txtCustomerName.Text = "";
            txtBillDate.Text = "1/1/2020";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }
        private void ddlDAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlDAL.Items.Clear();
            ddlDAL.Items.Add("AdoDAL");
            ddlDAL.Items.Add("EfDAL");
            ddlDAL.SelectedIndex = 0;
            LoadGrid();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                customer.Validate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IDAL<CustomerBase> Dal = FactoryDAL<IDAL<CustomerBase>>.Create(ddlDAL.Text);
                SetCustomer();
                customer.Validate();
                Dal.Add(customer);
                Dal.Save();
                LoadGrid();
                ClearCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
