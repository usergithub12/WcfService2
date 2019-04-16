using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.CallbackNS;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ClientCallback cc = new ClientCallback())
            {
                for (int i = 0; i < 10; i++)
                {
                    cc.CallService(i);
                }
                Console.Read();

            }
        }

    }
    class ClientCallback : IService1Callback, IDisposable
    {
        Service1Client client;
        public void CallbackFunction(string message)
        {
            Console.WriteLine($" Msg from Server {message}");
        }

        public void CallService(int y)
        {
            InstanceContext ic = new InstanceContext(this);
            client = new Service1Client(ic);
            client.UselessFunction(y);
        }
        public void Dispose()
        {
            client.Close();
        }
    }
}
