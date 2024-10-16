using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_EntityFramewordDbFirstProductProject
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        Entities db = new Entities();

        void ProductList()
        {
            var values = db.TblProduct
                .Join(db.TblCategory,
                p => p.CategoryId,
                c => c.CategoryId,
                (p, c) => new
                {
                    productid = p.ProductId,
                    productname = p.ProductName,
                    categoryname = c.CategoryName,
                    price = p.ProductPrice,
                    stock = p.ProductStock,
                    categoryId = p.CategoryId
                }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            
            ProductList();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            TblProduct tblProduct = new TblProduct();
            tblProduct.ProductName = txt_productName.Text;
            tblProduct.ProductPrice = decimal.Parse(txt_productPrice.Text);
            tblProduct.ProductStock = int.Parse(txt_productStock.Text);
            tblProduct.CategoryId = int.Parse(cmb_category.SelectedValue.ToString());
            db.TblProduct.Add(tblProduct);
            db.SaveChanges();
            ProductList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txt_productId.Text));
            db.TblProduct.Remove(value);
            db.SaveChanges();
            ProductList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txt_productId.Text));
            value.ProductName = txt_productName.Text;
            value.ProductPrice = decimal.Parse(txt_productPrice.Text);
            value.ProductStock = int.Parse(txt_productStock.Text);
            value.CategoryId = int.Parse(cmb_category.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = db.TblCategory.ToList();
            cmb_category.DisplayMember = "CategoryName";
            cmb_category.ValueMember = "CategoryId";
            cmb_category.DataSource = values;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var values = db.TblProduct.Where(x => x.ProductName == txt_productName.Text).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
