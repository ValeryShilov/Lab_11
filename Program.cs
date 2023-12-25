using Lab_10_lib;
using System.Diagnostics;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_11
{
    public class Program
    {
        static T GetCenterValue<T>(LinkedList<T> list)
        {
            int center = list.Count() / 2;
            var item = list.First;
            for (int i = 0; i< center; i++)
            {
                item = item.Next;
            }
            return item.Value;
        }

        static void Main(string[] args)
        {
            TestCollections test = new (1000);
            string tics;
            bool flag;
            string strFindsGoods;

            var stopWatch1 = new Stopwatch();
            Goods findGoods = new(test.listGoods.First().Name, test.listGoods.First().Price, test.listGoods.First().Weight);
            stopWatch1.Start();
            flag = test.listGoods.Contains(findGoods);
            stopWatch1.Stop();
            tics = stopWatch1.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска первого элемента в LinkedList<Goods> = {tics} тиков, Найден: {flag}");

            var stopWatch2 = new Stopwatch();
            findGoods = new(GetCenterValue(test.listGoods).Name, GetCenterValue(test.listGoods).Price, GetCenterValue(test.listGoods).Weight);
            stopWatch2.Start();
            flag = test.listGoods.Contains(findGoods);
            stopWatch2.Stop();
            tics = stopWatch2.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска центрального элемента в LinkedList<Goods> = {tics} тиков, Найден: {flag}");

            var stopWatch3 = new Stopwatch();
            findGoods = new(test.listGoods.Last().Name, test.listGoods.Last().Price, test.listGoods.Last().Weight);
            stopWatch3.Start();
            flag = test.listGoods.Contains(findGoods);
            stopWatch3.Stop();
            tics = stopWatch3.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска последнего элемента в LinkedList<Goods> = {tics} тиков, Найден: {flag}");

            var stopWatch4 = new Stopwatch();
            findGoods = new Goods("None", 0, 0);
            stopWatch4.Start();
            flag = test.listGoods.Contains(findGoods);
            stopWatch4.Stop();
            tics = stopWatch4.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска отсутствующего элемента в LinkedList<Goods> = {tics} тиков, Найден: {flag}");

            Console.WriteLine();

            var stopWatch5 = new Stopwatch();
            strFindsGoods = (string)(test.listStrings.First.Value).Clone();
            stopWatch5.Start();
            flag = test.listStrings.Contains(strFindsGoods);
            stopWatch5.Stop();
            tics = stopWatch5.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска первого элемента в LinkedList<String> = {tics} тиков, Найден: {flag}");

            var stopWatch6 = new Stopwatch();
            strFindsGoods = (string)(GetCenterValue(test.listStrings)).Clone();
            //strFindsGoods = new(test.listStrings.ToArray()[test.listStrings.Count() / 2]);
            stopWatch6.Start();
            flag = test.listStrings.Contains(strFindsGoods);
            stopWatch6.Stop();
            tics = stopWatch6.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска центрального элемента в LinkedList<String> = {tics} тиков, Найден: {flag}");

            var stopWatch7 = new Stopwatch();
            strFindsGoods = (string)(test.listStrings.Last.Value).Clone();
            stopWatch7.Start();
            flag = test.listStrings.Contains(strFindsGoods);
            stopWatch7.Stop();
            tics = stopWatch7.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска последнего элемента в LinkedList<String> = {tics} тиков, Найден: {flag}");

            var stopWatch8 = new Stopwatch();
            stopWatch8.Start();
            flag = test.listStrings.Contains("test");
            stopWatch8.Stop();
            tics = stopWatch8.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска несуществующего элемента в LinkedList<String> = {tics} тиков, Найден: {flag}");

            Console.WriteLine();

            var stopWatch9 = new Stopwatch();
            Goods firstGoods = new Goods(test.dictGP.Keys.ToArray()[0]);
            stopWatch9.Start();
            flag = test.dictGP.ContainsKey(firstGoods);
            stopWatch9.Stop();
            tics = stopWatch9.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по ключу первого элемента в Dictionary<Goods,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch10 = new Stopwatch();
            Goods centralGoods = new Goods(test.dictGP.Keys.ToArray()[test.dictGP.Keys.Count() / 2]);
            stopWatch10.Start();
            flag = test.dictGP.ContainsKey(centralGoods);
            stopWatch10.Stop();
            tics = stopWatch10.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по ключу центрального элемента в Dictionary<Goods,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch11 = new Stopwatch();
            Goods lastGoods = new Goods(test.dictGP.Keys.ToArray()[test.dictGP.Keys.Count() - 1]);
            stopWatch11.Start();
            flag = test.dictGP.ContainsKey(lastGoods);
            stopWatch11.Stop();
            tics = stopWatch11.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по ключу последнего элемента в Dictionary<Goods,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch12 = new Stopwatch();
            stopWatch12.Start();
            flag = test.dictGP.ContainsKey(new Goods("None",999,999));
            stopWatch12.Stop();
            tics = stopWatch12.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по ключу несуществующего элемента в Dictionary<Goods,Product> = {tics} тиков, Найден: {flag}");

            Console.WriteLine();
            var stopWatch13 = new Stopwatch();
            Product firstProduct = new Product(test.dictGP.Values.ToArray()[0]);
            stopWatch13.Start();
            flag = test.dictGP.ContainsValue(firstProduct);
            stopWatch13.Stop();
            tics = stopWatch13.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по значению первого элемента в Dictionary<Goods,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch14 = new Stopwatch();
            Product centralProduct = new Product(test.dictGP.Values.ToArray()[test.dictGP.Keys.Count() / 2]);
            stopWatch14.Start();
            flag = test.dictGP.ContainsValue(centralProduct);
            stopWatch14.Stop();
            tics = stopWatch14.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по значению центрального элемента в Dictionary<Goods,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch15 = new Stopwatch();
            Product lastProduct = new Product(test.dictGP.Values.ToArray()[test.dictGP.Keys.Count() / 2]);
            stopWatch15.Start();
            flag = test.dictGP.ContainsValue(lastProduct);
            stopWatch15.Stop();
            tics = stopWatch15.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по значению последнего элемента в Dictionary<Goods,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch16 = new Stopwatch();
            stopWatch16.Start();
            flag = test.dictGP.ContainsValue(new Product("None", 100, 100, new DateOnly(2000,11,11)));
            stopWatch16.Stop();
            tics = stopWatch16.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по значению несуществующего элемента в Dictionary<Goods,Product> = {tics} тиков, Найден: {flag}");

            Console.WriteLine();

            var stopWatch17 = new Stopwatch();
            string firstString = new Product(test.dictSP.Values.ToArray()[0]).ToString();
            stopWatch17.Start();
            flag = test.dictSP.ContainsKey(firstString);
            stopWatch17.Stop();
            tics = stopWatch17.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по ключу первого элемента в Dictionary<string,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch18 = new Stopwatch();
            string centralString = new Product(test.dictSP.Values.ToArray()[test.listGoods.Count / 2]).ToString();
            stopWatch18.Start();
            flag = test.dictSP.ContainsKey(centralString);
            stopWatch18.Stop();
            tics = stopWatch18.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по ключу центрального элемента в Dictionary<string,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch19 = new Stopwatch();
            string lastString = new Product(test.dictSP.Values.ToArray()[test.listGoods.Count - 1]).ToString();
            stopWatch19.Start();
            flag = test.dictSP.ContainsKey(lastString);
            stopWatch19.Stop();
            tics = stopWatch19.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по ключу последнего элемента в Dictionary<string,Product> = {tics} тиков, Найден: {flag}");

            var stopWatch20 = new Stopwatch();
            stopWatch20.Start();
            flag = test.dictSP.ContainsKey(new Product("None", 100, 100, new DateOnly(2000,11,11)).ToString());
            stopWatch20.Stop();
            tics = stopWatch20.Elapsed.Ticks.ToString();
            Console.WriteLine($"Время поиска по ключу несуществующего элемента в Dictionary<string,Product> = {tics} тиков, Найден: {flag}");
        }
    }
}