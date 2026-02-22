using CalculatorServiceLibrary;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace CalculatorServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri baseurl = new Uri("http://localhost:5000/CalculatorService");
            using (ServiceHost host = new ServiceHost(typeof(CalcService), baseurl))
            {
                host.AddServiceEndpoint(typeof(ICalcSOAPService), new BasicHttpBinding(), "CalcSOAP");
                var restEndpoint = host.AddServiceEndpoint(typeof(ICalcRESTService), new WebHttpBinding(), "CalcREST");
                restEndpoint.EndpointBehaviors.Add(new WebHttpBehavior());
                host.Open();

                Console.WriteLine("WCF Service Running...");
                Console.WriteLine("http://localhost:5000/CalculatorService/CalcSOAP");
                Console.WriteLine("http://localhost:5000/CalculatorService/CalcREST/addition?a={a}&b={b}");
                Console.WriteLine("http://localhost:5000/CalculatorService/CalcREST/mul-rest");
                Console.WriteLine("Press Enter to stop service");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
 