namespace _04_DapperNorthwind
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_categoryList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_categoryName = new System.Windows.Forms.TextBox();
            this.txt_categoryDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.txt_categoryId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_categoryDelete = new System.Windows.Forms.Button();
            this.txt_categoryUpdate = new System.Windows.Forms.Button();
            this.lbl_categoryCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_productCount = new System.Windows.Forms.Label();
            this.lbl_avarageProductInStock = new System.Windows.Forms.Label();
            this.lbl_seafoodProductTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_categoryList
            // 
            this.btn_categoryList.Location = new System.Drawing.Point(397, 10);
            this.btn_categoryList.Name = "btn_categoryList";
            this.btn_categoryList.Size = new System.Drawing.Size(117, 23);
            this.btn_categoryList.TabIndex = 0;
            this.btn_categoryList.Text = "Kategori Listesi";
            this.btn_categoryList.UseVisualStyleBackColor = true;
            this.btn_categoryList.Click += new System.EventHandler(this.btn_categoryList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 322);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt_categoryName
            // 
            this.txt_categoryName.Location = new System.Drawing.Point(120, 38);
            this.txt_categoryName.Name = "txt_categoryName";
            this.txt_categoryName.Size = new System.Drawing.Size(261, 20);
            this.txt_categoryName.TabIndex = 2;
            // 
            // txt_categoryDescription
            // 
            this.txt_categoryDescription.Location = new System.Drawing.Point(120, 64);
            this.txt_categoryDescription.Multiline = true;
            this.txt_categoryDescription.Name = "txt_categoryDescription";
            this.txt_categoryDescription.Size = new System.Drawing.Size(261, 46);
            this.txt_categoryDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Açıklaması: ";
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(397, 36);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(117, 23);
            this.btn_addCategory.TabIndex = 4;
            this.btn_addCategory.Text = "Kategori Ekle";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // txt_categoryId
            // 
            this.txt_categoryId.Location = new System.Drawing.Point(120, 12);
            this.txt_categoryId.Name = "txt_categoryId";
            this.txt_categoryId.Size = new System.Drawing.Size(261, 20);
            this.txt_categoryId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori Id: ";
            // 
            // txt_categoryDelete
            // 
            this.txt_categoryDelete.Location = new System.Drawing.Point(397, 62);
            this.txt_categoryDelete.Name = "txt_categoryDelete";
            this.txt_categoryDelete.Size = new System.Drawing.Size(117, 23);
            this.txt_categoryDelete.TabIndex = 5;
            this.txt_categoryDelete.Text = "Kategori Sil";
            this.txt_categoryDelete.UseVisualStyleBackColor = true;
            this.txt_categoryDelete.Click += new System.EventHandler(this.txt_categoryDelete_Click);
            // 
            // txt_categoryUpdate
            // 
            this.txt_categoryUpdate.Location = new System.Drawing.Point(397, 87);
            this.txt_categoryUpdate.Name = "txt_categoryUpdate";
            this.txt_categoryUpdate.Size = new System.Drawing.Size(117, 23);
            this.txt_categoryUpdate.TabIndex = 6;
            this.txt_categoryUpdate.Text = "Kategori Güncelle";
            this.txt_categoryUpdate.UseVisualStyleBackColor = true;
            this.txt_categoryUpdate.Click += new System.EventHandler(this.txt_categoryUpdate_Click);
            // 
            // lbl_categoryCount
            // 
            this.lbl_categoryCount.AutoSize = true;
            this.lbl_categoryCount.Location = new System.Drawing.Point(6, 26);
            this.lbl_categoryCount.Name = "lbl_categoryCount";
            this.lbl_categoryCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_categoryCount.TabIndex = 7;
            this.lbl_categoryCount.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.lbl_seafoodProductTotalPrice);
            this.groupBox1.Controls.Add(this.lbl_avarageProductInStock);
            this.groupBox1.Controls.Add(this.lbl_productCount);
            this.groupBox1.Controls.Add(this.lbl_categoryCount);
            this.groupBox1.Location = new System.Drawing.Point(520, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 428);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dapper İstatistikler";
            // 
            // lbl_productCount
            // 
            this.lbl_productCount.AutoSize = true;
            this.lbl_productCount.Location = new System.Drawing.Point(6, 52);
            this.lbl_productCount.Name = "lbl_productCount";
            this.lbl_productCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_productCount.TabIndex = 8;
            this.lbl_productCount.Text = "label4";
            // 
            // lbl_avarageProductInStock
            // 
            this.lbl_avarageProductInStock.AutoSize = true;
            this.lbl_avarageProductInStock.Location = new System.Drawing.Point(6, 77);
            this.lbl_avarageProductInStock.Name = "lbl_avarageProductInStock";
            this.lbl_avarageProductInStock.Size = new System.Drawing.Size(35, 13);
            this.lbl_avarageProductInStock.TabIndex = 9;
            this.lbl_avarageProductInStock.Text = "label5";
            // 
            // lbl_seafoodProductTotalPrice
            // 
            this.lbl_seafoodProductTotalPrice.AutoSize = true;
            this.lbl_seafoodProductTotalPrice.Location = new System.Drawing.Point(6, 103);
            this.lbl_seafoodProductTotalPrice.Name = "lbl_seafoodProductTotalPrice";
            this.lbl_seafoodProductTotalPrice.Size = new System.Drawing.Size(35, 13);
            this.lbl_seafoodProductTotalPrice.TabIndex = 10;
            this.lbl_seafoodProductTotalPrice.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_categoryUpdate);
            this.Controls.Add(this.txt_categoryDelete);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_categoryDescription);
            this.Controls.Add(this.txt_categoryId);
            this.Controls.Add(this.txt_categoryName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_categoryList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_categoryList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_categoryName;
        private System.Windows.Forms.TextBox txt_categoryDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.TextBox txt_categoryId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txt_categoryDelete;
        private System.Windows.Forms.Button txt_categoryUpdate;
        private System.Windows.Forms.Label lbl_categoryCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_seafoodProductTotalPrice;
        private System.Windows.Forms.Label lbl_avarageProductInStock;
        private System.Windows.Forms.Label lbl_productCount;
    }
}

