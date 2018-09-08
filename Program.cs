using System;
using System.ServiceModel;

namespace NAVWS
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length < 2)
            {
                Console.WriteLine("Please provide username and password.");
                return;
            }
            var username = args[0];
            var password = args[1];
            var client = new Services.ReportService_PortClient();
            var binding = client.Endpoint.Binding as BasicHttpBinding;
            binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            for (int i = 0; i < 10; i++)
            {
                var result = client.SaveToPDFAsync(311).Result;
                Console.WriteLine($"Result:{result.return_value}");
            }
        }
    }
}
