using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/latest?from=USD&to=TRY"),
                Headers =
                {
                    { "x-rapidapi-key", "ed9135e668msh190387669dd5e6bp16e6f8jsn106b64665d5a" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var euroToTRY = json["rates"]["TRY"].ToString();
                lbl_euroAlis.Text = euroToTRY;
                var parite = json["rates"]["USD"].ToString();
                var dolarToTRY = Convert.ToDouble(euroToTRY) / Convert.ToDouble(parite);
                lbl_dolarAlis.Text = dolarToTRY.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal unitPrice = decimal.Parse(txt_unitPrice.Text);
            decimal dolar = decimal.Parse(lbl_dolarAlis.Text);
            decimal euro = decimal.Parse(lbl_euroAlis.Text);
            decimal totalPrice = 0;
            if (rdb_dolar.Checked)
            {
                txt_result.Text = (unitPrice * dolar).ToString();
            }
            if (rdb_euro.Checked)
            {
                txt_result.Text = (unitPrice * euro).ToString();
            }
        }
    }
}
