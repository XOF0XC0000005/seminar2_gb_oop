using System.Security.Cryptography;

namespace Seminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (args.Length < 2) 
            //{
            //    Console.WriteLine("Недостаточно аргументов");
            //    return; 
            //}

            //int.TryParse(args[0], out int correctInt);
            //int.TryParse(args[1], out int correctInt1);

            //Console.WriteLine(correctInt + correctInt1);

            //if (args.Length == 0) 
            //{
            //    Console.WriteLine("Введите хотя бы один аргумент");
            //    return;
            //}
            //else if (args.Length == 1)
            //{
            //    double.TryParse(args[0], out double correctDouble);
            //    Console.WriteLine(correctDouble);
            //    return;
            //}

            //double result = 0;

            //foreach (var item in args)
            //{
            //    double.TryParse(item, out double correctDouble);
            //    result += correctDouble;
            //}

            //Console.WriteLine(result / args.Length);

            //int min = int.MaxValue;
            //bool isNum = false;

            //if (args.Length == 0)
            //{
            //    Console.WriteLine("Вы не ввели аргументы");
            //    return;
            //}
            //else if (args.Length == 1 && int.TryParse(args[0], out int num))
            //{
            //    isNum = true;
            //    Console.WriteLine(num);
            //    return;
            //}

            //foreach (var item in args)
            //{
            //    if (int.TryParse(item, out int num))
            //    {
            //        isNum = true;
            //        if (min > num) min = num;
            //    }
            //}

            //if (!isNum) Console.WriteLine(0);
            //else Console.WriteLine(min);

            int someInt = 1123123123;
            Bits bitsInt = someInt;

            byte someByte = 11;
            Bits bitsByte = someByte;

            long someLong = 1123123123;
            Bits bitsLong = someLong;
        }
    }
}