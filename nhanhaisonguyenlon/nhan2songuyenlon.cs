using System.Numerics;

namespace NhanHaiSoNguyenLon
{
    internal class Nhan2SoNguyenLon
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen lon thu nhat: ");
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen lon thu hai: ");
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            BigInteger result = num1 * num2;

            Console.WriteLine($"\nKet qua cua phep nhan la: {result}");
        }
    }
}
