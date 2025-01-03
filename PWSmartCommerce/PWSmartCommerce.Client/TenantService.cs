using System.Net.Http.Json;

public class TenantService(HttpClient httpClient)
{
  public async Task<List<Tenant>> GetTenantsAsync()
  {
    return await httpClient.GetFromJsonAsync<List<Tenant>>("api/tenants");
  }
}