using System;
using System.Reflection;

namespace DLL_Loader
{
    public class DLLLoader
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> Program started");

            //DLL path based on execution path
            string DLLLocation = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\BasicDLL.dll";
            Console.WriteLine("  > Loading the DLL from: " + DLLLocation);

            ;           //Try to instance the DLL dynamically
            try
            {
                //Load the assembly from the determined location
                Assembly BasicAssembly = Assembly.LoadFrom(DLLLocation);

                Console.WriteLine("  > Instancing method from DLL");
                //Get an object instance of the BasicClass from the BasicDLL
                Object o = BasicAssembly.CreateInstance("BasicDLL.BasicClass");
                //Get the assembly's available types, specifically the BasicDLL class, and the method from that class
                Type tp = BasicAssembly.GetType("BasicDLL.BasicClass");
                MethodInfo m = tp.GetMethod("GetHelloWorld");


                Console.WriteLine("  > Running method from DLL");
                //Invoke the method from the intanced method of the BasicDLL class and get the return as "ret"
                Object ret = m.Invoke(o, new Object[] { "Passing argument to DLL" });
                Console.WriteLine(ret);
                Console.WriteLine("  > Finished");

                //Wait so output is readable
                System.Threading.Thread.Sleep(2300);
            }
            //Catch any raised exception and warn of DLL placement, display Exception message
            catch (Exception ex)
            {
                Console.WriteLine("  FATAL: Could not load DLL, make sure it is in .exe directory");
                Console.WriteLine("  Exception: " + ex.Message);
            }
        }
    }
}
