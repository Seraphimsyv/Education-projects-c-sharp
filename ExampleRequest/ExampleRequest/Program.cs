using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;


namespace ExampleRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://api.binance.com/api/v3/exchangeInfo");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            response.Close();
            Console.WriteLine("Запрос выполнен");
            Console.Read();
        }
    }
}