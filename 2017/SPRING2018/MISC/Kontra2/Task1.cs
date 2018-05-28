using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace KontraSerialize
{   
    class Program
    {
        static void Main(string[] args)
        {  
            // Скачивание картинок с сайта
            WebClient client = new WebClient();
            client.DownloadFile(@"https://jsonplaceholder.typicode.com/photos/",  @"C: \Users\кц\source\repos\KontraSerialize\KontraSerialize\hap.txt");

            var fs = JsonConvert.SerializeObject(client); // Список картинок в виде JSon
            Console.WriteLine("Загрузка изображений завершена");

            ThreadMethod(); // Вызов метода с потоком
            DownloadFileAsync().GetAwaiter();
            //RequestAsync().GetAwaiter();

            Console.WriteLine("Файл загружен");
            Console.Read();
        }
        public static void ThreadMethod()  //Реализация метода с потоком
        {
                WebClient client = new WebClient();

                using (Stream stream = client.OpenRead(@"https://jsonplaceholder.typicode.com/photos/"))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            var fs = JsonConvert.SerializeObject(client);
            Console.WriteLine("Файл загружен");
            Console.Read();
        }
        private static async Task DownloadFileAsync()  //Асинхронный режим
        {
            WebClient client = new WebClient();
            await client.DownloadFileTaskAsync(new Uri(@"https://jsonplaceholder.typicode.com/photos/"), @"C: \Users\кц\source\repos\KontraSerialize\KontraSerialize\hap.txt");
            var fs = JsonConvert.SerializeObject(client);
        }
        //private static async Task RequestAsync()
        //{
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://jsonplaceholder.typicode.com/photos/");
        //    HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
        //    WebHeaderCollection headers = response.Headers;
        //    response.Close();
        //}
    }
}
   

