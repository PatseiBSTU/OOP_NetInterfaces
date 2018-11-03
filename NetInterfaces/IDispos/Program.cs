using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDispos
{
    public class WithDispose : IDisposable
    {
        public WithDispose() => Console.WriteLine("The object was created...");
     
        public void DoSomething() =>      Console.WriteLine("I am doing...");
       
        public void Dispose()
        {
            // здесь должен быть код освобождения управляемых ресурсов    
            Console.WriteLine("The work finished! The object will be destroy");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (WithDispose x = new WithDispose())
            {
                x.DoSomething();
                // компилятор C# поместит сюда вызов x.Dispose()
            }
            WithDispose y = new WithDispose();

        }
    }
}
