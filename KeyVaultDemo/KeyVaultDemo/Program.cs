using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Azure.Services.AppAuthentication;

namespace KeyVaultDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var vaultUrl = "https://rm-keyvault-demo.vault.azure.net";
            var client = new SecretClient(vaultUri: new Uri(vaultUrl), credential: new DefaultAzureCredential());

            var secret = (await client.GetSecretAsync("Flintstone")).Value.Value;

            Console.WriteLine(secret);
            Console.ReadKey();
        }
    }
}