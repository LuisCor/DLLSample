# DLLSample
A project that has two projects: a simple app that is built into a DLL, a second that loads that DLL

The goal of this project is to have a process instance a DLL and serving as a basic example of its usage.

## BasicDLL
Is a project that has a simple C# class that is built into a DLL. The DLL is available at BasicDLL/bin/Release/netstandard2.0/BasicDLL.dll

This DLL has a class "Class1" and once instanced, the method "GetHelloWorld" can be requested. This method receives a string as parameter and returns a string with a message concatenated with the passed string.

## DLL_Loader
Is a project that has the BasicDLL as a dependancy and uses the DLL.

The build .exe is available at DLL_Loader/bin/Release/net6.0/DLL_Loader.exe, as well as a copy of BasicDLL, both are need for the process to run.

The process starts and runs a message, followed by the message from the DLL and ends its execution. (simple stuff 😉)