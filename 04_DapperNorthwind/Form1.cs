using _04_DapperNorthwind.DTOs;
using Dapper;
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

namespace _04_DapperNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server = ENVER\\SQLEXPRESS01; initial catalog = 20ProjectE; integrated security = true; ");

        private async void btn_categoryList_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Categories";
            var values = await connection.QueryAsync<ResultCategoryDTO>(query);
            dataGridView1.DataSource = values;
        }

        private async void btn_addCategory_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Categories (CategoryName, Description) VALUES (@CategoryName, @Description)";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryName", txt_categoryName.Text);
            parameters.Add("@Description", txt_categoryDescription.Text);
            await connection.ExecuteAsync(query, parameters);
        }

        private async void txt_categoryDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Categories WHERE CategoryID = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryId", txt_categoryId.Text);
            await connection.ExecuteAsync(query, parameters);
        }

        private void txt_categoryUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description WHERE CategoryID = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryName", txt_categoryName.Text);
            parameters.Add("@Description", txt_categoryDescription.Text);
            parameters.Add("@CategoryId", txt_categoryId.Text);
            connection.Execute(query, parameters);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kategori Sayısı
            string query = "Select Count(*) From Categories";
            var count = connection.QueryAsync<int>(query);
            lbl_categoryCount.Text = "Toplam Kategori Sayısı: " + count.Result.FirstOrDefault().ToString();

            // Ürün Sayısı
            string query2 = "Select Count(*) From Products";
            var count2 = connection.QueryAsync<int>(query2);
            lbl_productCount.Text = "Toplam Ürün Sayısı: " + count2.Result.FirstOrDefault().ToString();

            // Ortalama Ürün Stok Sayısı
            string query3 = "Select AVG(UnitsInStock) From Products";
            var count3 = connection.QueryAsync<int>(query3);
            lbl_avarageProductInStock.Text = "Ortalama Stok Sayısı: " + count3.Result.FirstOrDefault().ToString();

            // Seafood Toplam Stok Sayısı * Fiyatı
            string query4 = "Select SUM(UnitsInStock * UnitPrice) From Products Where CategoryID = (Select CategoryId From Categories Where CategoryName = 'SeaFood')";
            var count4 = connection.QueryAsync<int>(query4);
            lbl_seafoodProductTotalPrice.Text = "Seafood Toplam Değer: " + count4.Result.FirstOrDefault().ToString();
        }
    }
}