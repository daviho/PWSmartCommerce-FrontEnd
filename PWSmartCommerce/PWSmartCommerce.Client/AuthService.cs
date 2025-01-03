using System.Net.Http.Json;

public class AuthService(HttpClient httpClient)
{
  public async Task<string?> Login(string username, string password)
  {
    var response = await httpClient.PostAsJsonAsync("api/auth/login", new { Username = username, Password = password });
    if (response.IsSuccessStatusCode)
    {
      var result = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
      return result?["Token"];
    }
    return null;
  }
}