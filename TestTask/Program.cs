using Newtonsoft.Json;
using RestSharp;
using System.Configuration;
using System.Security.Policy;

namespace TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new();
            // Генерируем числа
            List<sbyte> randomNumbers = generator.NumbersGeneration();
            // Выводим на консоль
            generator.PrintNumbers(ref randomNumbers);
            // Сортируем рандомным алгоритмом
            generator.Sorting(ref randomNumbers);
            // Выводим отсортированный список чисел
            generator.PrintNumbers(ref randomNumbers);
            // Считываем адрес сервера из файла конфигурации
            string configvalue = ConfigurationManager.AppSettings["connectionString"] ?? string.Empty;
            Console.WriteLine("Отправка данных на сервер {0}...", configvalue);
            // Отправка на Rest Api сервер
            var client = new RestClient(configvalue);
            var request = new RestRequest("/resource/", Method.Post);
            request.AddHeader("token", "someToken");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            string serialisedData = JsonConvert.SerializeObject(randomNumbers);
            Console.WriteLine(serialisedData);
            request.AddBody(serialisedData);
            client.Execute(request);
            Console.WriteLine("Данные успешно отправлены");
        }
    }
}