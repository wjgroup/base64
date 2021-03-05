using System;

namespace base64
{
    class Program
    {
        static void Main(string[] args)
        {   
            if (args.Length != 2) {
                return;
            }

            if (args[0] == "--encode" || args[0] == "-e") {
                var bytes = System.Text.Encoding.UTF8.GetBytes(args[1]);
                var text = Convert.ToBase64String(bytes);
                Console.WriteLine(text);

            }
            else if (args[0] == "--decode" || args[0] == "-d") {
                var bytes = Convert.FromBase64String(args[1]);
                var text = System.Text.Encoding.UTF8.GetString(bytes);
                Console.WriteLine(text);
            } 
            else {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
