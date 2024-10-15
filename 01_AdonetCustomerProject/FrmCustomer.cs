using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_AdonetCustomerProject
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server = ENVER\\SQLEXPRESS01; initial catalog = 20ProjeA; integrated security = true; ");

        private void btn_list_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select CustomerId, Name, Surname, Balance, Status, CityName From TblCustomers\r\nInner Join TblCity On TblCity.CityId = TblCustomers.CustomerCityId", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btn_procedure_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("CustomerListWithCity", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCity", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmb_city.ValueMember = "CityId";
            cmb_city.DisplayMember = "CityName";
            cmb_city.DataSource = dataTable;
            connection.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert Into TblCustomers (Name, Surname, Balance, Status, CustomerCityId) values (@name, @surname, @balance, @status, @city)", connection);
            command.Parameters.AddWithValue("@name", txt_customerName.Text);
            command.Parameters.AddWithValue("@surname", txt_customerSurname.Text);
            command.Parameters.AddWithValue("@balance", txt_balance.Text);
            command.Parameters.AddWithValue("@city", cmb_city.SelectedValue);
            if (rdb_active.Checked)
            {
                command.Parameters.AddWithValue("@status", true);
            }
            if (rdb_passive.Checked)
            {
                command.Parameters.AddWithValue("@status", false);
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde eklendi.");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from TblCustomers where CustomerId = @customerId", connection);
            command.Parameters.AddWithValue("@customerId", txt_customerId.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde silindi.");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TblCustomers Set Name = @name, Surname = @surname, CustomerCityId = @cityId, Balance = @balance, Status = @status where CustomerId = @customerId", connection);
            command.Parameters.AddWithValue("@name", txt_customerName.Text);
            command.Parameters.AddWithValue("@surname", txt_customerSurname.Text);
            command.Parameters.AddWithValue("@cityId", cmb_city.SelectedValue);
            command.Parameters.AddWithValue("@balance", txt_balance.Text);
            if (rdb_active.Checked)
            {
                command.Parameters.AddWithValue("@status", true);
            }
            if (rdb_passive.Checked)
            {
                command.Parameters.AddWithValue("@status", false);
            }
            command.Parameters.AddWithValue("@customerId", txt_customerId.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde güncellendi.");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select CustomerId, Name, Surname, Balance, Status, CityName From TblCustomers\r\nInner Join TblCity On TblCity.CityId = TblCustomers.CustomerCityId Where CustomerId = @customerId", connection);
            command.Parameters.AddWithValue("@customerId", txt_customerId.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
