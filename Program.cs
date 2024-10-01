using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // strings
            string userName = "javad";
            string willBeTrimmedText = "    sample text           ";

            Console.WriteLine("Hello World!");
            Console.WriteLine($"my name is {userName}");

            Console.WriteLine(userName.Length);

            Console.WriteLine(willBeTrimmedText.Trim());
            Console.WriteLine(willBeTrimmedText.TrimStart());
            Console.WriteLine(willBeTrimmedText.TrimEnd());

            Console.WriteLine(willBeTrimmedText.ToUpper());
            Console.WriteLine(willBeTrimmedText.ToLower());

            Console.WriteLine(willBeTrimmedText.Replace("s", "z"));

            Console.WriteLine(userName.StartsWith("j"));
            Console.WriteLine(userName.EndsWith("j"));

            Console.WriteLine(userName.Contains("v"));

            Console.WriteLine(userName.PadLeft(10, '*')); // show be ' '

            // numbers 32 bit , 4 byte

            int age = 20;
            int age2 = 19;

            int min = int.MinValue;
            int max = int.MaxValue;

            byte minByte = byte.MinValue;
            byte maxByte = byte.MaxValue;

            short minShort = short.MinValue;
            short maxShort = short.MaxValue;

            sbyte minSbyte = sbyte.MinValue;
            sbyte maxSbyte = sbyte.MaxValue;

            long minLong = long.MinValue;
            long maxLong = long.MaxValue;

            // just posetive
            ulong minUlong = ulong.MinValue;
            ulong maxUlong = ulong.MaxValue;

            double myDouble = 123.12; // most number , low deghat
            decimal myDecimal = 121.2M; // less number , most deghat

            Console.WriteLine(minUlong);
            Console.WriteLine(maxUlong);

            Console.WriteLine(minLong);
            Console.WriteLine(maxLong);

            Console.WriteLine(minShort);
            Console.WriteLine(maxShort);

            Console.WriteLine(minSbyte);
            Console.WriteLine(maxSbyte);

            Console.WriteLine(minByte);
            Console.WriteLine(maxByte);

            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.WriteLine(age);
            Console.WriteLine(age + age2);
            Console.WriteLine(age / age2);
            Console.WriteLine(age % age2);
            Console.WriteLine((age + age2) * age * age2);

            // boolean
            bool isAlive = true;

            // condition and loops
            if (age > 18)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("not ok");
            }

            int count = 0;
            while (count <= 10)
            {
                count = count + 1;
                Console.WriteLine("hello :)");
            }

            do
            {
                count = count + 1;
                Console.WriteLine("hello :)");
            } while (count <= 10);

            for (int i = 1; i <= 100; i += 1)
            {
                Console.WriteLine(i);
            }

            // string password = Console.ReadLine();
            // Console.WriteLine(password);

            int parsedItem = int.Parse("5");
            Console.WriteLine(parsedItem);

            // aditional topic

            // array
            string[] names = new string[10];

            names[0] = "haj javad";

            Console.WriteLine(names[0]);

            // functions

            Console.WriteLine(Sum(1, 5));
        }

        public static int Sum(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }
    }
}
