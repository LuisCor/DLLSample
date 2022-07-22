using System;
using BasicDLL;


namespace DLL_Loader
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> Program started");
            Console.WriteLine("  > Running method from DLL:");
            BasicDLL.Class1 BDLL = new BasicDLL.Class1();
            Console.WriteLine(BDLL.GetHelloWorld("Passing argument to DLL"));
            Console.WriteLine("  > DLL command run");
            System.Threading.Thread.Sleep(1500);

        }
    }
}
