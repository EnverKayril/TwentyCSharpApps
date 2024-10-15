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
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server = ENVER\\SQLEXPRESS01; initial catalog = 20ProjeA; integrated security = true; ");

        private void btn_list_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCity", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCity (CityName, Country) values (@cityName, @country)", connection);
            command.Parameters.AddWithValue("@cityName", txt_cityName.Text);
            command.Parameters.AddWithValue("@country", txt_countryName.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde eklendi.");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from TblCity where CityId = @cityId", connection);
            command.Parameters.AddWithValue("@cityId", txt_cityId.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde silindi.");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TblCity Set CityName = @cityName, Country = @country where CityId = @cityId", connection);
            command.Parameters.AddWithValue("@cityName", txt_cityName.Text);
            command.Parameters.AddWithValue("@country", txt_countryName.Text);
            command.Parameters.AddWithValue("@cityId", txt_cityId.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde güncellendi.");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCity where CityName = @cityName", connection);
            command.Parameters.AddWithValue("@cityName", txt_cityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
