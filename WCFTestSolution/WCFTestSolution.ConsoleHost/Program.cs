using System;
using System.ServiceModel;
using WCFTestSolution.Services;

namespace WCFTestSolution.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var host = new ServiceHost(typeof(ZzaService));

                host.Open();

                Console.WriteLine("WCF host initialized. Hit any key to shut down...");
                Console.ReadKey();

                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}