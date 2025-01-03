using System.Net.Http.Json;
using PWSmartCommerce.Domain.Models;

namespace PWSmartCommerce.Client.Services
{
  public class TenantService(HttpClient httpClient)
  {
    public async Task<List<Tenant>?> GetTenantsAsync()
    {
      return await httpClient.GetFromJsonAsync<List<Tenant>>("api/tenants");
    }

    public async Task CreateTenantAsync(Tenant tenant)
    {
      await httpClient.PostAsJsonAsync("api/tenants", tenant);
    }

    public async Task UpdateTenantAsync(Tenant tenant)
    {
      await httpClient.PutAsJsonAsync($"api/tenants/{tenant.TenantId}", tenant);
    }

    public async Task DeleteTenantAsync(int id)
    {
      await httpClient.DeleteAsync($"api/tenants/{id}");
    }
  }
}
