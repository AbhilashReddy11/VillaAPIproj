﻿

using VillaAPI_Web.Models.Dto;

namespace VillaAPI_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>(string Token);
        Task<T> GetAsync<T>(int id, string Token);
        Task<T> CreateAsync<T>(VillaNumberCreateDTO dto, string Token);
        Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto, string Token);
        Task<T> DeleteAsync<T>(int id, string Token);
 
    }
}
