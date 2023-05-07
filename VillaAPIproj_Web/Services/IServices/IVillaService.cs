

using VillaAPI_Web.Models.Dto;

namespace VillaAPI_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>(string Token);
        Task<T> GetAsync<T>(int id, string Token);
        Task<T> CreateAsync<T>(VillaCreateDTO dto, string Token);
        Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string Token);
        Task<T> DeleteAsync<T>(int id, string Token);

    }
}
