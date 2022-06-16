using System;
using Newtonsoft.Json;

namespace MyMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("RomVR", "Testing", DateTime.Now);
            string output = JsonConvert.SerializeObject(message);
            Console.WriteLine(output);

            Message deserializedMessage = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMessage);
            //{ "UserName":"RomVR","MessageText":"Testing","TimeStamp":"2022-06-17T02:58:04.3024422+05:00"}
            //RomVR < 17.06.2022 2:58:04 >: Testing
            Console.ReadLine();
        }
    }
}