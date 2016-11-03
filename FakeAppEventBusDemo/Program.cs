using FakeAppEventBusDemo.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeAppEventBusDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var eq = new EqBase();
            var otherForm = new OtherForm();
            otherForm.Send("Hello Fake AppEventBus.");

            // 暫停畫面
            Console.ReadLine();
        }
    }
}
