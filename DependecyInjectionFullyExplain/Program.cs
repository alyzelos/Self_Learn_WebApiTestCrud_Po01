using System;

namespace DependecyInjectionFullyExplain
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new HelloService();
            var consumer = new ServiceConsumer(service);
            service.Print();
            consumer.Print();
        }
        public class ServiceConsumer
        {
            private readonly HelloService hello;

            public ServiceConsumer(HelloService hello)
            {
                this.hello = hello;
            }
            public void Print()
            {
                this.hello.Print();
            }
        }
        public class HelloService
        {
            public void Print()
            {
                Console.WriteLine("hello word");
            }
        }
    }

}
