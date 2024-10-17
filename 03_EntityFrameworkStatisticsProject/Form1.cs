using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_EntityFrameworkStatisticsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Entities db = new Entities();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Toplam kategori sayısı
            int categoryCount = db.TblCategory.Count();
            lbl_categoryCount.Text = categoryCount.ToString();

            // Toplam ürün sayısı
            int productCount = db.TblProduct.Count();
            lbl_productCount.Text = productCount.ToString();

            // Müşteri sayısı
            int customerCount = db.TblCustomer.Count();
            lbl_customerCount.Text = customerCount.ToString();

            // Toplam sipariş sayısı
            int orderCount = db.TblOrder.Count();
            lbl_orderCount.Text = orderCount.ToString();

            // Toplam stok sayısı
            var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            lbl_productTotalStock.Text = totalProductStockCount.ToString();

            // Ortalama ürün fiyatı
            var averageProductPrice = db.TblProduct.Average(x => (decimal)x.ProductDecimal);
            lbl_productAvaragePrice.Text = averageProductPrice.ToString("F2") + " ₺";

            // Toplam meyve sayısı
            var fruitCount = db.TblProduct.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
            lbl_productTotalFruitCount.Text = fruitCount.ToString();

            // Gazoz ürün * fiyat
            var sodaProduct = db.TblProduct.Where(x => x.ProductId == 5).FirstOrDefault();
            lbl_totalPriceOfSoda.Text = ((decimal)sodaProduct.ProductStock * (decimal)sodaProduct.ProductDecimal).ToString("F2") + " ₺";

            // Stok sayısı 100'den az olan ürünlerün sayısı
            var productStockLessThan100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
            lvl_productStockSmallerThan100.Text = productStockLessThan100.ToString();

            // Aktif sebze sayısı
            var categoryId = db.TblCategory.FirstOrDefault(x => x.CategoryName == "Meyve").CategoryId;
            var activeVegetableCount = db.TblProduct.Where(x => x.CategoryId == categoryId && x.ProductStatus == true).Sum(y => y.ProductStock);
            lbl_activeFruitCount.Text = activeVegetableCount.ToString();

            // Türkiye'den yapılan siparişlerin toplam tutarı
            var customerId = db.TblCustomer.Where(x => x.CustomerCountry == "Türkiye").Select(y => y.CustomerId).ToList();
            var totalOrderPriceFromTurkey = db.TblOrder.Where(x => customerId.Contains((int)x.CustomerId)).Sum(y => (int)y.TotalPrice);
            lbl_OrderCountByTurkiye.Text = totalOrderPriceFromTurkey.ToString("F2") + " ₺";

            // Toplam Meyve satışından elde edilen gelir
            var fruitCategoryId = db.TblCategory.FirstOrDefault(x => x.CategoryName == "Meyve").CategoryId;
            var totalFruitIncome = db.TblOrder.Where(x => x.TblProduct.CategoryId == fruitCategoryId).Sum(y => (decimal)y.TotalPrice);
            lbl_totalFruitOrder.Text = totalFruitIncome.ToString("F2") + " ₺";

            // Son eklenen ürün
            var lastAddedProduct = db.TblProduct.OrderByDescending(x => x.ProductId).FirstOrDefault();
            lbl_lastAddedProductName.Text = lastAddedProduct.ProductName;

            // Son eklenen ürünün kategorisi
            var lastAddedProductCategory = db.TblCategory.FirstOrDefault(x => x.CategoryId == lastAddedProduct.CategoryId);
            lbl_lastAddedProductCategory.Text = lastAddedProductCategory.CategoryName;

            // Aktif ürün sayısı
            var activeProductCount = db.TblProduct.Where(x => x.ProductStatus == true).Count();
            lbl_activeProductCount.Text = activeProductCount.ToString();

            // Stoktaki kolanın toplam getirisi
            var cola = db.TblProduct.FirstOrDefault(x => x.ProductName == "Kola");
            var totalIncome = (int)cola.ProductStock * (decimal)cola.ProductDecimal;
            lbl_cokeTotalAmount.Text = totalIncome.ToString("F2") + " ₺";

            // Son eklenen müşteri
            var customer = db.TblCustomer.OrderByDescending(x => x.CustomerId).FirstOrDefault();
            lbl_lastCustomerName.Text = customer.CustomerName;

            // Son sipariş veren müşteri
            var customerOrder = db.TblOrder.OrderByDescending(x => x.OrderId).FirstOrDefault();
            lbl_lastOrderingCustomer.Text = customerOrder.TblCustomer.CustomerName;

            // Müşterilerin ülke sayısı
            var countryCount = db.TblCustomer.Select(x => x.CustomerCountry).Distinct().Count();
            lbl_differentCountryCount.Text = countryCount.ToString();

            // En çok ürün satın alan müşteri
            var mostProductOrderingCustomer = db.TblOrder.GroupBy(x => x.CustomerId).OrderByDescending(y => y.Count()).FirstOrDefault().FirstOrDefault().TblCustomer;
            lbl_mostProductOrderingCustomer.Text = mostProductOrderingCustomer.CustomerName;
        }
    }
}
