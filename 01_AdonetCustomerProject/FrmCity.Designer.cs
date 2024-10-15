namespace _01_AdonetCustomerProject
{
    partial class FrmCity
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cityId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_list = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cityName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_countryName = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir Id: ";
            // 
            // txt_cityId
            // 
            this.txt_cityId.Location = new System.Drawing.Point(109, 28);
            this.txt_cityId.Name = "txt_cityId";
            this.txt_cityId.Size = new System.Drawing.Size(167, 20);
            this.txt_cityId.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 301);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(109, 148);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(167, 23);
            this.btn_list.TabIndex = 3;
            this.btn_list.Text = "Listele";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şehir Adı: ";
            // 
            // txt_cityName
            // 
            this.txt_cityName.Location = new System.Drawing.Point(109, 67);
            this.txt_cityName.Name = "txt_cityName";
            this.txt_cityName.Size = new System.Drawing.Size(167, 20);
            this.txt_cityName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ülke: ";
            // 
            // txt_countryName
            // 
            this.txt_countryName.Location = new System.Drawing.Point(109, 107);
            this.txt_countryName.Name = "txt_countryName";
            this.txt_countryName.Size = new System.Drawing.Size(167, 20);
            this.txt_countryName.TabIndex = 1;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(109, 188);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(167, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Ekle";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(109, 226);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(167, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Sil";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(109, 265);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(167, 23);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(109, 306);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(167, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Ara";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // FrmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1021, 356);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_countryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cityId);
            this.Controls.Add(this.label1);
            this.Name = "FrmCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şehir Bilgi Formu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cityId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cityName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_countryName;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
    }
}

