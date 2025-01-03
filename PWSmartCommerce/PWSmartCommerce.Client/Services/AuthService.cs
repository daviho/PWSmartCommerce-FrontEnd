using System.Net.Http.Json;

namespace PWSmartCommerce.Client.Services
{
  public class AuthService(HttpClient httpClient)
  {
    public async Task<bool> LoginAsync(string username, string password)
    {
      var response = await httpClient.PostAsJsonAsync("api/auth/login", new { username, password });
      return response.IsSuccessStatusCode;
    }

    public async Task LogoutAsync()
    {
      await httpClient.PostAsync("api/auth/logout", null);
    }
  }
}
