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
            
        }
    }
}
