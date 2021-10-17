using System;

namespace service
{
    public class DemoService : IDemoService
    {
        private readonly string serviceName;
        public  DemoService()
        {

            serviceName = "Create time: " + DateTime.Now + " Guid: " + Guid.NewGuid();
            Console.WriteLine(serviceName);
        }

        public override string ToString()
        {
            return serviceName;

        }
    }
}
