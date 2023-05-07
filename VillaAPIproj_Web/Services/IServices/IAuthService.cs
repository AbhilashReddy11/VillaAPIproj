using VillaAPI_Web.Models.Dto;

namespace VillaAPI_Web.Services.IServices
{
	public interface IAuthService
	{
		Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
		Task<T> RegisterAsync<T>(RegistrationRequestDTO objToCreate);
	}
}
