using System;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var discovery = await client.GetDiscoveryDocumentAsync(
                new DiscoveryDocumentRequest
                {
                    Address = "http://192.168.0.180:5000",
                    Policy = new DiscoveryPolicy { RequireHttps = false }
                });
            if (discovery.IsError)
            {
                Console.WriteLine(discovery.Error);
                Console.ReadKey();
                return;
            }

            // request token
            //var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            //{
            //    Address = discovery.TokenEndpoint,
            //    ClientId = "pwd",
            //    ClientSecret = "511536EF-F270-4058-80CA-1C89C192F69A",
            //    Scope = "scope1 scope3",
            //});
            var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest()
            {
                Address = discovery.TokenEndpoint,
                ClientId="pwd",
                Scope = "scope1 scope3 profile openid",
                Password = "alice",
                UserName = "alice",
                ClientSecret = "511536EF-F270-4058-80CA-1C89C192F69A"
            });

            var userinfo = await client.GetUserInfoAsync(new UserInfoRequest()
            {
                Address = discovery.UserInfoEndpoint,
                Token = tokenResponse.AccessToken
            });

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                Console.ReadKey();
                return;
            }

            Console.WriteLine(tokenResponse.Json);

            // call api
            var apiClient = new HttpClient();
            apiClient.SetBearerToken(tokenResponse.AccessToken);

            var response = await apiClient.GetAsync("http://localhost:5002/WeatherForecast");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(JArray.Parse(content));
            }

            Console.ReadKey();
        }
    }
}
