using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> aylar = new MyDictionary<int, string>();
            aylar.Add(2, "Şubat");
            aylar.Add(3, "Mart");
            aylar.Add(6, "Haziran");
            aylar.Add(7, "Temmuz");

            Console.WriteLine("Dizimizdeki eleman sayısı: " + aylar.Count);
            aylar.GetAll();
            Console.ReadKey();
        }
    }
}
