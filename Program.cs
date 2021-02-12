using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            MyDictionary<string> isimler = new MyDictionary<string>();

            isimler.Add("Kubix");
            isimler.Add("Berkius");
            isimler.Add("Tivorlu Ismail");

            Console.WriteLine(isimler.Length + " isim bulundu;");

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
