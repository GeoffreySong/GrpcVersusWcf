using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfService.Services;

namespace WcfService
{
    class Program
    {
        public static void Main(string[] args)
        {
            var serviceUrl = "net.tcp://localhost:9002/TestService";
            ServiceHost host = null;

            //var uri = new Uri(serviceUrl);
            //host = new ServiceHost(typeof(TestService), uri);

            //var metadataBehavior = new ServiceMetadataBehavior();
            //host.Description.Behaviors.Add(metadataBehavior);
            //host.AddServiceEndpoint(typeof (IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");  

            //var binding = new NetTcpBinding();
            //host.AddServiceEndpoint(typeof (ITestService), binding, serviceUrl);
			host = new ServiceHost(typeof(TestService));
            host.Open();

            Console.WriteLine("Service is live now at : {0}", serviceUrl);
            Console.ReadKey();
        }
    }
}
