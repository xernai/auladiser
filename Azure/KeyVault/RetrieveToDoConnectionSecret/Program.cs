using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Linq;

namespace RetrieveToDoConnectionSecret
{
    internal class Program
    {
        const string keyVaultURI = "https://todo-keyvault-02.vault.azure.net/";
        static SecretClient azureKeyVaultSecretClient;
        static void Main(string[] args)
        {
            var credentials = new DefaultAzureCredential();

            azureKeyVaultSecretClient = new SecretClient( new Uri(keyVaultURI), credentials);

            // Leer todos los secretos
            Console.WriteLine("Mostrando todos los secretos del KeyVault");
            Console.WriteLine("----------------------------------------");
            var azureKeyVaultSecrets = azureKeyVaultSecretClient.GetPropertiesOfSecrets();

            foreach (var secret in azureKeyVaultSecrets)
            {
                var secretValue = azureKeyVaultSecretClient.GetSecret(secret.Name);
                Console.WriteLine($"{secret.Name} | {secretValue.Value.Value}");
            }

            // Leer un secreto en específico utilizando LINQ (Language Integrated Query)
            var singleSecret = azureKeyVaultSecrets.SingleOrDefault(x => x.Name == "token-base");
            var singleSecretValue = azureKeyVaultSecretClient.GetSecret(singleSecret.Name);

            var singleSecretContent = singleSecretValue.Value.Value;

            Console.WriteLine();

            Console.WriteLine("Mostrando secreto de token-base");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{singleSecretContent}");
        }
    }
}
