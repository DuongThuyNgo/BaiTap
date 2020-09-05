using System;
using System.Text;

namespace UCLN
{
    class Program
    {
        static int a;
        static int b;
        static void Nhap()
        {
            Console.Write("Nhập số thứ nhất: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            b = int.Parse(Console.ReadLine());
        }

        static int UCLN()
        {
            int tmp;
            while (b!=0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("\t\t\tƯớc chung lớn nhất giữa hai số ");

            while (true)
            {
                Nhap();
                Console.Write("Ước chung lớn nhất giữa hai số " + a + " và " + b + " là: "+UCLN()+"\n");
                Console.WriteLine("\t\t\t****************************");
                Console.WriteLine("Bạn có muốn nhập tiếp không???");
                Console.WriteLine("Nhấn A để nhập tiếp, nhấn phím bất kỳ để thoát!!!! ");
                string tiep = Console.ReadLine();
                if (tiep != "A") break;
                Console.WriteLine("\t\t\t****************************");
            }
            
        }
    }
}
