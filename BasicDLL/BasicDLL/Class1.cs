using System;

namespace BasicDLL
{
    public class BasicClass
    {
        public BasicClass(){}
        public string GetHelloWorld(string message)
        {
            return "Hello World, I'm a DLL and I was loaded by an application!\nYour message: " + message;
        }
    }
}
