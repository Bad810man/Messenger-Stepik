using System;
using ConsoleMessenger;
using Newtonsoft.Json;

namespace MyMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Valera", "Hello", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializeMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializeMsg);

        }
    }
}
