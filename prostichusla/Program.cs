namespace prostichusla
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Vvestu N prostogo chusla:");
            int n = Int32.Parse(Console.ReadLine());

            int count = 0;
            int number = 1;

            while (count < n)
            {
                number++;
                if (IsPrime(number))
                {
                    count++;
                }
            }

            Console.WriteLine($"{n}-proste chuslo: {number}");
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num <= 3) return true;

          

            for (int i = 2;  i*i <=num; i += 1)
            {
                if (num % i == 0 )
                    return false;
            }

            return true;
        }
    }
}
