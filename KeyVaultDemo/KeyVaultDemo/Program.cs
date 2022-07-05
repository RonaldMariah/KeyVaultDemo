using Azure.Identity;
using Azure.Security.KeyVault.Keys;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Rest;

namespace KeyVaultDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var azureServiceTokenProvider = new AzureServiceTokenProvider();
            var vaultUrl = "https://rm-keyvault-demo.vault.azure.net";
            var client = new SecretClient(vaultUri: new Uri(vaultUrl), credential: new DefaultAzureCredential());

            // Retrieve a key using the key client.
            var secret = (await client.GetSecretAsync("Flintstone")).Value.Value;

            Console.WriteLine(secret);
            Console.ReadKey();
        }
    }
}