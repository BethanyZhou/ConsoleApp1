using Azure.Core;
using Azure.ResourceManager;

using System;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            var accessToken = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "../../../", "accessToken.txt"));
            TokenCredential token = new AzureTokenCredential(accessToken, null);
            ArmClient armClient = new ArmClient(token);
           
            foreach (var provider in armClient.GetTenantProviders())
            {
                Console.WriteLine(provider.Namespace);
            }
        }
    }
}
