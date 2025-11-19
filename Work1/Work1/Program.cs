using System;

namespace Lab1
{
    public static class Input
    {
        public static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();

            if (int.TryParse(s, out int value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("ค่าที่ป้อนไม่ใช่จำนวนเต็ม — กรุณาลองอีกครั้ง.");
                return ReadInt(prompt);
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int a = Input.ReadInt("กรอก ค่า A: ");
            int b = Input.ReadInt("กรอก ค่า B: ");
            if (a > b)
            {
                Console.WriteLine("a มากกว่า b");
            }
            else
            {
                if (a == b)
                {

                    Console.WriteLine("a เท่ากับ b");
                }
                else
                {

                    Console.WriteLine("a น้อยกว่า b");
                }
            }
        }
    }
}


