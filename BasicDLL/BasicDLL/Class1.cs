using System;

namespace BasicDLL
{
    public class Class1
    {
        public string GetHelloWorld(string message)
        {
            return "Hello World, I'm a DLL and I was loaded by an application!\nYour message: " + message;
        }
    }
}
