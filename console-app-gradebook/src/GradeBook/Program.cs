using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0) {
                Console.WriteLine("Hey BUDDY! " + args[0] + ", you got the job!");
            } else {
                Console.WriteLine("Hello");
            }
            
            if(args.Length > 1) {
                Console.WriteLine($"Hey Buddy! {args[1]}, you got the job!");
            } else {
                Console.WriteLine("Hello");
            }

            double x = 64.28;
            double y = 74.24;

            double z = x + y;

            Console.WriteLine(z);

            double[] numbers = new double[3];
            numbers[0] = 34.17;
            numbers[1] = 77.45;
            numbers[2] = 54.10;

            double sum = numbers[0] + numbers[1] + numbers[2];

            Console.WriteLine(sum);
            
        }
    }
}
