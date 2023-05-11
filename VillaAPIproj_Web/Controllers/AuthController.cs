using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using VillaAPI_Utility;
using VillaAPI_Web.Models.Dto;
using VillaAPI_Web.Models;

using VillaAPI_Web.Services.IServices;
using System.IdentityModel.Tokens.Jwt;

namespace VillaAPI_Web.Controllers
{
	

	public class AuthController : Controller
	{
		private readonly IAuthService _authService;
		public AuthController(IAuthService authService)
		{
			_authService = authService;	
		}
		[HttpGet]
		public IActionResult Login()
		{
			LoginRequestDTO obj = new();
			return View(obj);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginRequestDTO obj)
		{
            APIResponse response = await _authService.LoginAsync<APIResponse>(obj);
			if(response !=null && response.IsSuccess)
			{

                

                
                LoginResponseDTO model = JsonConvert.DeserializeObject<LoginResponseDTO>(Convert.ToString(response.Result));

                var handler = new JwtSecurityTokenHandler();
                var jwt = handler.ReadJwtToken(model.Token);

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, model.User.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Role, jwt.Claims.FirstOrDefault(u => u.Type == "role").Value));
                var principal = new ClaimsPrincipal(identity);
                
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);

                HttpContext.Session.SetString(SD.SessionToken, model.Token);
				return RedirectToAction("Index","Home");
			
			}
			else
			{
				ModelState.AddModelError("CustomerError", response.ErrorMessages.FirstOrDefault());
                return View(obj);
            }
			
			
		}
		[HttpGet]
		public IActionResult Register()
		{
			
			return View();
		}
		[HttpPost]
		
		public async Task<IActionResult> Register(RegistrationRequestDTO obj)
		{
			APIResponse result= await _authService.RegisterAsync<APIResponse>(obj);
			if (result !=null && result.IsSuccess) {
				return RedirectToAction("login");
					}
			return View();
		}
		public async Task<IActionResult> Logout()
		{
            await HttpContext.SignOutAsync();
			HttpContext.Session.SetString(SD.SessionToken, "");
			return RedirectToAction("Index","Home");
		}
        public IActionResult AccessDenied()
        {
            return View();

        }


    }
}
