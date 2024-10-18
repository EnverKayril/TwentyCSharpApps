namespace _08_RapidApiCurrency
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
            this.lbl_dolarAlis = new System.Windows.Forms.Label();
            this.lbl_euroAlis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_unitPrice = new System.Windows.Forms.TextBox();
            this.rdb_dolar = new System.Windows.Forms.RadioButton();
            this.rdb_euro = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_dolarAlis
            // 
            this.lbl_dolarAlis.AutoSize = true;
            this.lbl_dolarAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dolarAlis.Location = new System.Drawing.Point(52, 38);
            this.lbl_dolarAlis.Name = "lbl_dolarAlis";
            this.lbl_dolarAlis.Size = new System.Drawing.Size(46, 18);
            this.lbl_dolarAlis.TabIndex = 0;
            this.lbl_dolarAlis.Text = "label1";
            // 
            // lbl_euroAlis
            // 
            this.lbl_euroAlis.AutoSize = true;
            this.lbl_euroAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_euroAlis.Location = new System.Drawing.Point(288, 38);
            this.lbl_euroAlis.Name = "lbl_euroAlis";
            this.lbl_euroAlis.Size = new System.Drawing.Size(46, 18);
            this.lbl_euroAlis.TabIndex = 2;
            this.lbl_euroAlis.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Tutar:";
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Location = new System.Drawing.Point(142, 149);
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(231, 20);
            this.txt_unitPrice.TabIndex = 5;
            // 
            // rdb_dolar
            // 
            this.rdb_dolar.AutoSize = true;
            this.rdb_dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_dolar.Location = new System.Drawing.Point(119, 95);
            this.rdb_dolar.Name = "rdb_dolar";
            this.rdb_dolar.Size = new System.Drawing.Size(62, 22);
            this.rdb_dolar.TabIndex = 6;
            this.rdb_dolar.TabStop = true;
            this.rdb_dolar.Text = "Dolar";
            this.rdb_dolar.UseVisualStyleBackColor = true;
            this.rdb_dolar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_euro
            // 
            this.rdb_euro.AutoSize = true;
            this.rdb_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_euro.Location = new System.Drawing.Point(225, 95);
            this.rdb_euro.Name = "rdb_euro";
            this.rdb_euro.Size = new System.Drawing.Size(58, 22);
            this.rdb_euro.TabIndex = 6;
            this.rdb_euro.TabStop = true;
            this.rdb_euro.Text = "Euro";
            this.rdb_euro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(119, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "İşlemi Gerçekleştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ödenecek Tutar:";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(142, 179);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(231, 20);
            this.txt_result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdb_euro);
            this.Controls.Add(this.rdb_dolar);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_unitPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_euroAlis);
            this.Controls.Add(this.lbl_dolarAlis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dolarAlis;
        private System.Windows.Forms.Label lbl_euroAlis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_unitPrice;
        private System.Windows.Forms.RadioButton rdb_dolar;
        private System.Windows.Forms.RadioButton rdb_euro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_result;
    }
}

