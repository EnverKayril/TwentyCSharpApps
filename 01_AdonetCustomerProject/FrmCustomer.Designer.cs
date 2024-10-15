namespace _01_AdonetCustomerProject
{
    partial class FrmCustomer
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_customerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_customerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.rdb_active = new System.Windows.Forms.RadioButton();
            this.rdb_passive = new System.Windows.Forms.RadioButton();
            this.btn_procedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(91, 391);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(167, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Ara";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(91, 350);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(167, 23);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(91, 311);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(167, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Sil";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(91, 273);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(167, 23);
            this.btn_create.TabIndex = 14;
            this.btn_create.Text = "Ekle";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(91, 233);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(79, 23);
            this.btn_list.TabIndex = 15;
            this.btn_list.Text = "Listele";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 402);
            this.dataGridView1.TabIndex = 10;
            // 
            // txt_customerSurname
            // 
            this.txt_customerSurname.Location = new System.Drawing.Point(91, 91);
            this.txt_customerSurname.Name = "txt_customerSurname";
            this.txt_customerSurname.Size = new System.Drawing.Size(167, 20);
            this.txt_customerSurname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri Soyadı: ";
            // 
            // txt_customerName
            // 
            this.txt_customerName.Location = new System.Drawing.Point(91, 51);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(167, 20);
            this.txt_customerName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri Adı: ";
            // 
            // txt_customerId
            // 
            this.txt_customerId.Location = new System.Drawing.Point(91, 12);
            this.txt_customerId.Name = "txt_customerId";
            this.txt_customerId.Size = new System.Drawing.Size(167, 20);
            this.txt_customerId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Id: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bakiye: ";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(91, 127);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(167, 20);
            this.txt_balance.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şehir: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Durum: ";
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(91, 162);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(167, 21);
            this.cmb_city.TabIndex = 16;
            // 
            // rdb_active
            // 
            this.rdb_active.AutoSize = true;
            this.rdb_active.Location = new System.Drawing.Point(114, 199);
            this.rdb_active.Name = "rdb_active";
            this.rdb_active.Size = new System.Drawing.Size(46, 17);
            this.rdb_active.TabIndex = 17;
            this.rdb_active.TabStop = true;
            this.rdb_active.Text = "Aktif";
            this.rdb_active.UseVisualStyleBackColor = true;
            // 
            // rdb_passive
            // 
            this.rdb_passive.AutoSize = true;
            this.rdb_passive.Location = new System.Drawing.Point(189, 199);
            this.rdb_passive.Name = "rdb_passive";
            this.rdb_passive.Size = new System.Drawing.Size(48, 17);
            this.rdb_passive.TabIndex = 17;
            this.rdb_passive.TabStop = true;
            this.rdb_passive.Text = "Pasif";
            this.rdb_passive.UseVisualStyleBackColor = true;
            // 
            // btn_procedure
            // 
            this.btn_procedure.Location = new System.Drawing.Point(179, 233);
            this.btn_procedure.Name = "btn_procedure";
            this.btn_procedure.Size = new System.Drawing.Size(79, 23);
            this.btn_procedure.TabIndex = 15;
            this.btn_procedure.Text = "Prosedür";
            this.btn_procedure.UseVisualStyleBackColor = true;
            this.btn_procedure.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(968, 429);
            this.Controls.Add(this.rdb_passive);
            this.Controls.Add(this.rdb_active);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_procedure);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_customerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_customerId);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Formu";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_customerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_customerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.RadioButton rdb_active;
        private System.Windows.Forms.RadioButton rdb_passive;
        private System.Windows.Forms.Button btn_procedure;
    }
}