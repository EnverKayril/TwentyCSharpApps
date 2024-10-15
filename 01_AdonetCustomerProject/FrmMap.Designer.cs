namespace _01_AdonetCustomerProject
{
    partial class FrmMap
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
            this.btn_openCityForm = new System.Windows.Forms.Button();
            this.btn_openCustomerForm = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_openCityForm
            // 
            this.btn_openCityForm.Location = new System.Drawing.Point(36, 21);
            this.btn_openCityForm.Name = "btn_openCityForm";
            this.btn_openCityForm.Size = new System.Drawing.Size(139, 54);
            this.btn_openCityForm.TabIndex = 0;
            this.btn_openCityForm.Text = "Şehir İşlemleri";
            this.btn_openCityForm.UseVisualStyleBackColor = true;
            this.btn_openCityForm.Click += new System.EventHandler(this.btn_openCityForm_Click);
            // 
            // btn_openCustomerForm
            // 
            this.btn_openCustomerForm.Location = new System.Drawing.Point(36, 81);
            this.btn_openCustomerForm.Name = "btn_openCustomerForm";
            this.btn_openCustomerForm.Size = new System.Drawing.Size(139, 54);
            this.btn_openCustomerForm.TabIndex = 0;
            this.btn_openCustomerForm.Text = "Müşteri İşlemleri";
            this.btn_openCustomerForm.UseVisualStyleBackColor = true;
            this.btn_openCustomerForm.Click += new System.EventHandler(this.btn_openCustomerForm_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(36, 141);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(139, 54);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Çıkış Yap";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(209, 214);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_openCustomerForm);
            this.Controls.Add(this.btn_openCityForm);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_openCityForm;
        private System.Windows.Forms.Button btn_openCustomerForm;
        private System.Windows.Forms.Button btn_exit;
    }
}