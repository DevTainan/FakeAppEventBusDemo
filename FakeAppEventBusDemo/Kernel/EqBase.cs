using MyFirstNuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeAppEventBusDemo.Kernel
{
    class EqBase
    {
        private AppEventBus cv_AppEventBus;

        public EqBase()
        {
            cv_AppEventBus = new AppEventBus();
            cv_AppEventBus.OnMessageReceived += Cv_AppEventBus_OnMessageReceived;
        }

        private void Cv_AppEventBus_OnMessageReceived(object sender, NotifyMessageArgs e)
        {
            Console.WriteLine("EqBase Recev - Id: {0}, Message: {1}", e.Id, e.Message);
        }
    }
}
