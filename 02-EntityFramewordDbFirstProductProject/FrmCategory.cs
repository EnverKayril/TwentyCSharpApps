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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        Entities db = new Entities();

        void CategoryList()
        {
            dataGridView1.DataSource = db.TblCategory.ToList();
        }
        private void btn_list_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            TblCategory tblCategory = new TblCategory();
            tblCategory.CategoryName = txt_categoryName.Text;
            db.TblCategory.Add(tblCategory);
            db.SaveChanges();
            CategoryList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_categoryId.Text);
            var value = db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            CategoryList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_categoryId.Text);
            var value = db.TblCategory.Find(id);
            value.CategoryName = txt_categoryName.Text;
            db.SaveChanges();
            CategoryList();
        }
    }
}
