#region Menü_Başlangıcı
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;
using System.Threading.Channels;

Console.WriteLine("Api Consume İşlemine Hoşgeldiniz");
Console.WriteLine();
Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1- Şehir Listesini Getir");
Console.WriteLine("2- Yeni Şehir Ekle");
Console.WriteLine("3- Şehir Sil");
Console.WriteLine("4- Şehir Güncelleme İşlemi");
Console.WriteLine("5- ID'ye Göre Şehir Getir");
Console.WriteLine();
#endregion

string secim;

Console.Write("Seçiminiz: ");
secim = Console.ReadLine();
Console.WriteLine();

switch (secim)
{
    case "1":
        string url = "https://localhost:7150/api/Weathers";
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage message = await client.GetAsync(url);
            string response = await message.Content.ReadAsStringAsync();
            JArray jArray = JArray.Parse(response);
            foreach (var item in jArray)
            {
                Console.WriteLine("ID: " + item["cityId"] + " Şehir: " + item["cityName"] + " Sıcaklık: " + item["temprature"]);
            }
        }
        break;
    case "2":
        Console.WriteLine("Yeni Şehir Ekle");
        Console.WriteLine();
        string url2 = "https://localhost:7150/api/Weathers";

        Console.Write("Şehir Adı: ");
        string cityName = Console.ReadLine();

        Console.Write("Ülke Adı: ");
        string countryName = Console.ReadLine();

        Console.Write("Sıcaklık: ");
        decimal temprature = decimal.Parse(Console.ReadLine());

        Console.Write("Hava Durumu Detayı: ");
        string detail = Console.ReadLine();

        var newWeather = new
        {
            CityName = cityName,
            Country = countryName,
            Temprature = temprature,
            Detail = detail
        };
        using (HttpClient client = new HttpClient())
        {
            string json = JsonConvert.SerializeObject(newWeather);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync(url2, content);
            message.EnsureSuccessStatusCode();
        }
        break;
    case "3":
        Console.Write("Silmek isteğiniz şehrin ID'si: ");
        int cityId = int.Parse(Console.ReadLine());
        string url3 = "https://localhost:7150/api/Weathers?id=";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage message = await client.DeleteAsync(url3 + cityId);
            message.EnsureSuccessStatusCode();
        }
        break;
    case "4":
        Console.WriteLine("Şehir Güncelle");
        Console.WriteLine();

        Console.Write("Şehir ID: ");
        string cityId2 = Console.ReadLine();

        Console.Write("Şehir Adı: ");
        string cityName2 = Console.ReadLine();

        Console.Write("Ülke Adı: ");
        string countryName2 = Console.ReadLine();

        Console.Write("Sıcaklık: ");
        decimal temprature2 = decimal.Parse(Console.ReadLine());

        Console.Write("Hava Durumu Detayı: ");
        string detail2 = Console.ReadLine();

        using (HttpClient client = new HttpClient())
        {
            string url4 = "https://localhost:7150/api/Weathers";
            var updateWeather = new
            {
                CityId = cityId2,
                CityName = cityName2,
                Country = countryName2,
                Temprature = temprature2,
                Detail = detail2
            };

            string json = JsonConvert.SerializeObject(updateWeather);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PutAsync(url4, content);
            message.EnsureSuccessStatusCode();
        }

        break;
    case "5":
        Console.Write("ID'ye Göre Şehir Getir");
        Console.WriteLine();
        Console.Write("Şehir ID: ");
        int cityId3 = int.Parse(Console.ReadLine());

        string url5 = "https://localhost:7150/api/Weathers?id=";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage message = await client.GetAsync(url5 + cityId3);
            string response = await message.Content.ReadAsStringAsync();

            JArray jArray = JArray.Parse(response);

            JObject jObject = (JObject)jArray[0];

            string cityName5 = jObject["cityName"].ToString();
            string countryName5 = jObject["country"].ToString();
            decimal temprature5 = decimal.Parse(jObject["temprature"].ToString());
            string detail5 = jObject["detail"].ToString();

            Console.WriteLine($"Şehir Adı: {cityName5}\n" +
                              $"Ülke Adı: {countryName5}\n" +
                              $"Sıcaklık: {temprature5}\n" +
                              $"Detay: {detail5}");
        }

        break;
    default:
        Console.WriteLine("Geçersiz Seçim");
        break;
}

Console.Read();