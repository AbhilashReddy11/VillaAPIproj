﻿using VillaAPI_Utility;
using VillaAPI_Web.Models;
using VillaAPI_Web.Models.Dto;
using VillaAPI_Web.Services.IServices;

namespace VillaAPI_Web.Services
{
	public class AuthService : BaseService ,IAuthService
	{
		private readonly IHttpClientFactory _clientFactory;
		private string villaUrl;

		public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
		{
			_clientFactory = clientFactory;
			villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");

		}

		public Task<T> LoginAsync<T>(LoginRequestDTO obj)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.POST,
				Data = obj,
				Url = villaUrl + "/api/v1/UsersAuth/login"
            });
		}

		public Task<T> RegisterAsync<T>(RegistrationRequestDTO obj)
		{
			return SendAsync<T>(new APIRequest()
			{
				ApiType = SD.ApiType.POST,
				Data = obj,
				Url = villaUrl + "/api/v1/UsersAuth/register"
            });
		}
	}

	
		
			
		
	}
